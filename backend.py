import requests , os , re , csv
import datetime
from time import sleep
from datetime import date, timedelta
from utility import createLink
#import wget #import for windows

basePath = r"./media/database"
certificatePath = basePath+"/SRID_SSLSELF_CRT.cer"
proxy = "http://107.108.167.20:80"

class snapshotDetails:
    def __init__(self, link, serialImageFolder):
        self.link = link
        self.serialImageFolder=serialImageFolder

snapObj = []



def fetchLink():
    try:
        if( os.path.isfile(basePath+"/links.csv")):
            with open(basePath+"/links.csv", 'r') as csvfile:
                for r in csvfile:
                    dataset=str(r).split(",")
                    link=str(dataset[0].strip())
                    serialImageFolder=str(dataset[1].strip())
                    snapObj.append(snapshotDetails(link,serialImageFolder))
    except Exception as e:
        print("Error in fetchLink function ->"+str(e))
        
def init():
    try:
        fetchLink()
        count=0
        for count in range(0,len(snapObj)):
            createLink(snapObj[count].link,snapObj[count].serialImageFolder)
            print("Download complete for this link ->"+snapObj[count].link+snapObj[count].serialImageFolder)
            print("---------------------------------------------------------------------------------------------------------------------------")
    except Exception as e :
        print("Error in init function -> "+str(e))
    
def StartTimer():
    try:
        while True:
            x=datetime.datetime.now() 
            y=x.replace(day=x.day, hour=2, minute=0, second=0, microsecond=0)
            if x<y:
                delta=y-x
                se=delta.seconds
                print("sleep time(in Seconds) = "+str(se))
                sleep(se)
                init()
            else:
                #temp=((24-x.hour)%24)*60*60
                temp=3600
                print("sleep time(in Seconds) = "+str(temp))
                sleep(temp)
    except Exception as e:
        print("Error in StartTimer function -> "+str(e))
    

def main():
    try:
        print("-------------------------------- Starting backend --------------------------------")
        init()
        #StartTimer()
    except Exception as e :
        print("Error in main function -> "+str(e))

main()
