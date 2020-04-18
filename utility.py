import requests , os , re , csv

basePath = r"./media/database"
certificatePath = basePath+"/SRID_SSLSELF_CRT.cer"
backup_database_csv= basePath+"/backup_database.csv"
proxy = "http://107.108.167.20:80"
def makeFolder(path):
    try:
        #different funtion to windows & linux 
        root_path = basePath#'./database'
        folders = path.split("/")
        #access_rights = 0o755
        for folder in folders:
            if not os.path.exists(root_path):
                os.mkdir(root_path)
            root_path=root_path+"/"+folder  
        return root_path
        
    except Exception as e:
        print("Error in makeFolder function ->"+str(e))
  

def checkURL(url):
    try:
        #different funtion to windows & linux 
        r = requests.get(url)#, proxies={"http": proxy}, cert=["",certificatePath]) ##proxy need for windows
        if r.status_code != 200:
            print(url+" not found")
            return 0
        else:
            #print("url found")
            return 1
    except Exception as e :
        print("Error in checkURL folder -->"+str(e))
    

def downloadFile(urlWithExtension,location,fileName):
    try:
        #different funtion to windows & linux 
        if( not os.path.isfile(location+fileName)):
            command = "wget -P "+location+" "+urlWithExtension
            #command = "axel -a -n 20 "+ urlWithExtension +" -o "+location+fileName
            os.system(command)
            return 1
        return 1
    except Exception as e :
        print("Error in downloadFile function -->"+str(e))
        return 0

def readVersionFile(pathVersion):
    try:
        regionDict ={"AKUC":"ATSC","DEUC":"DVB","UABC":"ISDB"}
        with  open(pathVersion,'r') as f:
                for row in f:
                    if "SNAPSHOT" in row:
                        mainVersion=row.split(":")[1].strip()
                        model=mainVersion.split("-")[2].strip()
                        year=mainVersion.split("-")[1].strip()[-4:]
                        dateVersion=mainVersion.split("_")[1].strip()
                    if "VERSION" in row:
                        relVersion=row.split(":")[1].strip()
                        tempVersion=relVersion.split("-")
                        relVersionNumber=tempVersion[2].strip()
                        region=tempVersion[1].strip()[-4:]
                        region=regionDict[region]
                        relVersion=tempVersion[0]+"-"+tempVersion[1]+"_"+tempVersion[2]
                version=dateVersion+"("+relVersionNumber+")"
        #removing version.txt from latest
        os.remove(os.path.join(pathVersion.split("versions.txt")[0],"versions.txt"))
        return mainVersion,relVersion,model,year,version,region
    except Exception as e:
        print("Error in readVersionFile funtion -->"+str(e))

def readCSVDatabse(model,year,version,region,path):
    try:
        found=0
        if( os.path.isfile(backup_database_csv)):
            with open(backup_database_csv, 'r') as csvfile:
                for r in csvfile:
                    dataset=str(r).split(",")
                    if(year==dataset[0].strip() and model==dataset[1].strip() and region==dataset[2].strip() and version==dataset[3].strip()):
                        found = 1
                        return found
                    else :
                        found = 0
        return found
    except Exception as e:
        print("Error in readCSVDatabse funtion -->"+str(e))
def getOTNPrerequisite(path):
    try:
        OTNPrerequisite=""
        if(os.path.isfile(path)):
            flag=0
            relVer=""
            debugVer=""
            with open(path,'r') as otnfile:
                for r in otnfile:
                    if "source" in r:
                        flag=1
                    if "target" in r:
                        flag=0
                    if (flag==1) :
                        if "version" in r:
                            relVer=r.split(": ")[1].strip()
                        if "location:" in r:
                            debugVer=r.split("RELEASE_")[1].split("/")[0].strip()
                            flag=2
                    if (flag==2) :
                        if not relVer == "" and not debugVer == "" :
                            if not OTNPrerequisite == "" :
                                OTNPrerequisite=OTNPrerequisite+"_" 
                            OTNPrerequisite=OTNPrerequisite+debugVer+"("+relVer+")"
                            flag=1
                            relVer=""
                            debugVer=""
                        
        return OTNPrerequisite
    except Exception as e:
        print("Error in getOTNPrerequisite funtion -->"+str(e))

@app.route('/blog_post', methods=['POST'])
def create():
  
    createLink(request.get_data('parameter1'), request.get_data('parameter2'))

def createLink(link,serialImageName):
    try:
        if(checkURL(link)==1):
            path=link.split("/archive/")[1]
            path=makeFolder(path) # making latest directory
            downloadFile(link+"versions.txt",path,"versions.txt")
            pathVersion=path+"versions.txt"
            #print(pathVersion)
            mainVersion,relVersion,model,year,version,region = readVersionFile(pathVersion)
            if "latest" in link:
                prefix=link.split("latest/")[0].strip()
                postfix=link.split("latest/")[1].strip()
                mainLink=prefix+mainVersion+"/"+postfix
            else:
                mainLink=link

            mainPath = mainLink.split("/archive/")[1]
            mainPath=makeFolder(mainPath)
            
            found = readCSVDatabse(model,year,version,region,mainPath)
            if(found==0):
                if(checkURL(mainLink)==1):
                    #downloading version.txt
                    mainLinkVersion=mainLink + "versions.txt"
                    downloadSuccess=downloadFile(mainLinkVersion,mainPath,"versions.txt")
                    if(downloadSuccess==1):
                        versionPath=mainPath+"versions.txt"
                    else:
                        versionPath="NA"
                    #print("\n version.txt compeleted for version = " + relVersion)

                    #downloading serial images
                    mainLinkSerialImage=mainLink + serialImageName         # link for serial image zip file
                    downloadSuccess=downloadFile(mainLinkSerialImage,mainPath,serialImageName)
                    if(downloadSuccess==1):
                        serialImagePath=mainPath+serialImageName
                    else:
                        serialImagePath="NA"
                    #print("\n serial image downloaded for version = " + relVersion)

                    #downloading USB images
                    mainLinkUSBImage=mainLink + relVersion + "_USB/" + relVersion + "_USB.zip"
                    downloadSuccess=downloadFile(mainLinkUSBImage,mainPath, relVersion + "_USB.zip")
                    if(downloadSuccess==1):
                        usbImagePath=mainPath+relVersion + "_USB.zip"
                    else:
                        usbImagePath="NA"
                    #print("\n USB image downloaded for version = " + relVersion)

                    #downloading OTN info
                    mainLinkOTNInfo=mainLink+ relVersion + "_OTN/" + relVersion + "_OTN_info.txt"
                    downloadSuccess=downloadFile(mainLinkOTNInfo,mainPath,relVersion + "_OTN_info.txt")
                    #print("\n OTN info downloaded for version = " + relVersion)
                                        
                    OTNPrerequisite=getOTNPrerequisite(mainPath+relVersion + "_OTN_info.txt")   

                    with open(backup_database_csv, 'a', newline='') as csvfile:
                        row_writer = csv.writer(csvfile, delimiter=',')
                        row_writer.writerows([[ year,model,region, version,serialImagePath,usbImagePath,OTNPrerequisite]])
                        #row_writer.writerows([[ year,model,region, version,mainPath,OTNPrerequisite]]) ##without path
                        
                    
                else:
                    print("please check wrong URL -->"+mainLink)
            else:
                print("\nData already exist ")
        else:
            print("wrong link ->"+ link+" !!!!!!!!!!!!!!!!!!!!")
    except Exception as e :
        print("Error in createlink function ->"+str(e))
