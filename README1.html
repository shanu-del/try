<!DOCTYPE html>
<!-- saved from url=(0041)http://107.108.175.239:8000/mrt/universal -->
<html><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link rel="stylesheet" type="text/css" href="./mrtcompare_files/MRTstyle.css">
<!-- <link rel="stylesheet" type="text/css" href="/static/bootstrap.css"> -->
   </head><body><div class="Header">
	  <a class="navbar-brand" href="http://107.108.175.239:8000/">Product Intelligence Portal</a>
	 <a class="nav-item" href="http://107.108.175.239:8000/mrt/">Home</a>
	 <h1>MRT/PRT Comparison Tool</h1>
	 <a class="nav-item1" href="http://107.108.175.239:8000/mrt/universal">User Input</a>
	 <h2>  </h2>
	 <a class="nav-item2" href="http://107.108.175.239:8000/mrt/universal_server">System Input</a>
</div>

	<!--<div id="PujaTool" class="p-3" >-->
		<div class="compare">
			<p>Select files to compare</p>
		</div>
		<div id="firstPageButtons">
			<div class="uploadfile">
            <form id="files" class="fisrt_form" method="post" enctype="multipart/form-data">
                <input type="hidden" name="csrfmiddlewaretoken" value="mghfvex3Q9Dp6DhJ6dAEGugUHdLitW2D5nLN3b8t946xZpr0RInZnQfkxQRnCuSh">
                <p><label for="id_file_source_1">Enter Reference File:</label> <input type="file" name="file_source_1" required="" id="id_file_source_1"></p>
<p><label for="id_file_source_2">Enter Current File:</label> <input type="file" name="file_source_2" required="" id="id_file_source_2"></p>
                <br>
                <button class="button btn-secondary" id="decrpyt_file" type="submit">Process</button>
            </form>
            <div id="toprocess"></div>
            <input type="button" id="upload" value="Process" onclick="Process()" hidden="hidden">
        </div>
	</div>


    

        
        <div class="loader" id="loaderDiv" style="display: none;"></div>
        <div id="filterDiv" style="display:none">
            <div id="selectDiv" class="container">
                <div class="row w-100">
                    <div class="col-4">
                        <span id="refregion">Ref Region</span>
                        <span><select id="filter1" class="form-control" onchange="refgetSelect(this.value);"></select></span>
					</div>
					<div class="col-4">
                        <span id="refcountry">Ref Country</span>
                        <span><select id="filter2" class="form-control"></select></span>
					</div>
					<div class="col-4">
                        <span id="tarregion">Cur Region</span>
                        <span><select id="filter3" class="form-control" onchange="targetSelect(this.value);"></select></span>
					</div>
					<div class="col-4">
                        <span id="tarcountry">Cur Country</span>
                        <span><select id="filter4" class="form-control"></select></span>
					</div>
                        <span id="selecttask">Action</span>
                        <span><select id="Select" class="form-control"></select></span>
                    </div>
                </div>
                <div class="mt-4"></div>
                <input type="button" id="upload1" value="Show Data" onclick="Compare()">
                <button id="button1" onclick="exportTableToExcel()">Export Table Data To Excel File</button>
                <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for detail.." title="Type in a name" style="display: none;">
                <div class="row">
                        <div id="result">Result</div>
                    </div>
                 <div id="Legend"></div>
				<label for="Legend" id="label">Different Items</label>
				<div id="REFFILE">Reference File : </div>
				<div id="CURRFILE">Current File : </div> 
				<div id="REFFILEVal"></div>
				<div id="CURRFILEVal"></div>				
            </div>
        
        <div id="hdExcel"></div>
        <div id="dvExcel"></div>
    
    






    <script type="text/javascript" src="./mrtcompare_files/xlsx.full.min.js.download"></script>
    <script type="text/javascript" src="./mrtcompare_files/jszip.js.download"></script>
    <script src="./mrtcompare_files/jquery-3.4.1.min.js.download"></script>
    <script type="text/javascript">
var file_1_path
var file_2_path
var url1
var url2

function upload(event) {
    event.preventDefault();
    var data = new FormData($('form').get(0));
	console.log($('form').get(0));
    console.log("Working");
	console.log(data)

	$.ajax({
		// url: $(this).attr('action'),
		url: "/mrt/upload",
		type: $(this).attr('method'),
		data: data,
		dataType: 'json',
		cache: false,
		processData: false,
		contentType: false,
		success: function(data) {
			// console.log(data);
			file_1_path = data['path_first_file'];
			file_2_path = data['path_second_file'];
			console.log(file_1_path, file_2_path);
			console.log('success');

			$('#upload').click();
		}
	});
	
	
    return false;
}

$(function() {
	// console.log(file_1_path, file_2_path);
    $('form').submit(upload);
	
});
        var data1 = null;
        var data2 = null;
        var timer = null;
        var filterValues = {};
        var tableData = null;
        var multipleNameCountriesMap = {};
        var refDetailHeaderCol = null;
        var tarDetailHeaderCol = null;
        var refRegionRow = -1;
        var tarRegionRow = -1;
	var refRow = -1;
	var tarRow = -1;
	var refCol = null;
	var tarCol = null;
        var fileName1 = 'Refernce';
        var fileName2 = 'Target';
       
        document.getElementById('loaderDiv').style.display = 'none';
        function myFunction() {
            console.log('hello');
            var input,
                filter,
                table,
                tr,
                td,
                i,
                txtValue;
            input = document.getElementById("myInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[0];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }

        function Process() {            
            document.getElementById('loaderDiv').style.display = 'block';
            //Reference the FileUpload element.
            var fileUpload1 = document.getElementById("id_file_source_1");
			var fileUpload2 = document.getElementById("id_file_source_2");
			document.getElementById("REFFILEVal").innerHTML=fileUpload1.files[0].name;
            document.getElementById("CURRFILEVal").innerHTML=fileUpload2.files[0].name;
            
            var refReq = new XMLHttpRequest();
            refReq.open("GET", file_1_path, true);
            refReq.responseType = "arraybuffer";
            refReq.onload = function (e) {
                var arraybuffer = refReq.response;
                var data = new Uint8Array(arraybuffer);
                var arr = new Array();
                for (var i = 0; i != data.length; ++i)
                    arr[i] = String.fromCharCode(data[i]);
                var bstr = arr.join("");
                data1 = ProcessExcel(bstr);
            }
            refReq.send();

            var tarReq = new XMLHttpRequest();
            tarReq.open("GET", file_2_path, true);
            tarReq.responseType = "arraybuffer";
            tarReq.onload = function (e) {
                var arraybuffer = tarReq.response;
                var data = new Uint8Array(arraybuffer);
                var arr = new Array();
                for (var i = 0; i != data.length; ++i)
                    arr[i] = String.fromCharCode(data[i]);
                var bstr = arr.join("");
                data2 = ProcessExcel(bstr);
            }
            tarReq.send();

            
          /*  var selectArr = [{
				name: 'All Items',
				value: 0
			}, {
				name: 'Deleted Items',
				value: 1
			}, {
				name: 'New Items',
				value: 2
			}, {
				name: 'Different Items',
				value: 3
			}, {
				name: 'Similar Items',
				value: 4
			}
            ];
            for (var i = 0; i < selectArr.length; i++) {
                var option = document.createElement("option");
                option.text = selectArr[i].name;
                option.value = selectArr[i].value;
                var select = document.getElementById("Select");
                select.appendChild(option);
            }*/
            timer = setInterval(()=>{
                if(data1 && data2){
                    console.log(data1, data2);
                    clearInterval(timer);
                    navigate();
                }
            }, 100);

        };
        function navigate() {
                if(data1.type == 'invalid' || data2.type == 'invalid'){
                    document.getElementById('loaderDiv').style.display = 'none';
                    document.getElementById('firstPageButtons').style.display = 'blocks';
                    alert('Please select valid MRT/PRT Excel files.');
                }
                else {
				var fileUpload1 = document.getElementById("id_file_source_1");
				var fileUpload2 = document.getElementById("id_file_source_2");
				localStorage.setItem("url1", file_1_path); // Storing file1 path which returned from server after file decryption in localstorage
				localStorage.setItem("url2", file_2_path); // Storing file2 path which returned from server after file decryption in localstorage
				localStorage.setItem("f1", fileUpload1.files[0].name);// Storing file1 name in localstorage
				localStorage.setItem("f2", fileUpload2.files[0].name);// Storing file2 name in localstorage
                localStorage.setItem("reverse", 'false');
				
				//Above parameters will be used when we redirected to new page. selected files path and name will be picked from localstorage.
				// check loadcomplete() function which call on <body> onload event.
                
			
				if ((data1.type == 'MRT' && data2.type == 'PRT') || (data1.type == 'PRT' && data2.type == 'MRT')){
					if(data1.type == 'PRT') {
						localStorage.setItem("url2", file_1_path); // Storing file1 path which returned from server after file decryption in localstorage
				        localStorage.setItem("url1", file_2_path);
                        localStorage.setItem("f2", fileUpload1.files[0].name);// Storing file1 name in localstorage
                        localStorage.setItem("f1", fileUpload2.files[0].name);
				        localStorage.setItem("reverse", 'true');
                        
                    }
					window.location.href = "/mrt/mrt_prt_uni";
				}
				else if(data1.type == 'MRT' && data2.type == 'MRT'){
					window.location.href = "/mrt/mrt_mrt_uni";
				}
				else if(data1.type == 'PRT' && data2.type == 'PRT'){
					window.location.href = "/mrt/prt_prt_uni";
				}
                }

		}

    function ProcessExcel(data, fileNmae) {
        try{
        var workbook = XLSX.read(data, {
            type: 'binary'
        });
 
        //Fetch the name of First Sheet.
        var sheetsName = workbook.SheetNames;
        console.log(sheetsName);
		for(var i = 0;i < sheetsName.length; i++){
			if(sheetsName[i].toUpperCase().indexOf('DD LIST') >= 0 || sheetsName[i].toUpperCase().indexOf('OWNER INFO') >= 0){
				return { type: 'PRT' };
			}
            else if(sheetsName[i].toUpperCase() == 'MASTER SPECS ' || sheetsName[i].toUpperCase() == 'MASTER SPECS' || sheetsName[i] == 'Master 사양' || sheetsName[i].toUpperCase() == 'MASTER SPEC' || sheetsName[i].toUpperCase() == 'MASTER' ||sheetsName[i] == 'Master ì‚¬ì–‘'){
				return { type: 'MRT' };
			}
		}
		return { type: 'invalid' };
        } catch(err) { return {type: 'invalid'}}
    };
</script>


</body></html><!DOCTYPE html>
<!-- saved from url=(0041)http://107.108.175.239:8000/mrt/universal -->
<html><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link rel="stylesheet" type="text/css" href="./mrtcompare_files/MRTstyle.css">
<!-- <link rel="stylesheet" type="text/css" href="/static/bootstrap.css"> -->
   </head><body><div class="Header">
	  <a class="navbar-brand" href="http://107.108.175.239:8000/">Product Intelligence Portal</a>
	 <a class="nav-item" href="http://107.108.175.239:8000/mrt/">Home</a>
	 <h1>MRT/PRT Comparison Tool</h1>
	 <a class="nav-item1" href="http://107.108.175.239:8000/mrt/universal">User Input</a>
	 <h2>  </h2>
	 <a class="nav-item2" href="http://107.108.175.239:8000/mrt/universal_server">System Input</a>
</div>

	<!--<div id="PujaTool" class="p-3" >-->
		<div class="compare">
			<p>Select files to compare</p>
		</div>
		<div id="firstPageButtons">
			<div class="uploadfile">
            <form id="files" class="fisrt_form" method="post" enctype="multipart/form-data">
                <input type="hidden" name="csrfmiddlewaretoken" value="mghfvex3Q9Dp6DhJ6dAEGugUHdLitW2D5nLN3b8t946xZpr0RInZnQfkxQRnCuSh">
                <p><label for="id_file_source_1">Enter Reference File:</label> <input type="file" name="file_source_1" required="" id="id_file_source_1"></p>
<p><label for="id_file_source_2">Enter Current File:</label> <input type="file" name="file_source_2" required="" id="id_file_source_2"></p>
                <br>
                <button class="button btn-secondary" id="decrpyt_file" type="submit">Process</button>
            </form>
            <div id="toprocess"></div>
            <input type="button" id="upload" value="Process" onclick="Process()" hidden="hidden">
        </div>
	</div>


    

        
        <div class="loader" id="loaderDiv" style="display: none;"></div>
        <div id="filterDiv" style="display:none">
            <div id="selectDiv" class="container">
                <div class="row w-100">
                    <div class="col-4">
                        <span id="refregion">Ref Region</span>
                        <span><select id="filter1" class="form-control" onchange="refgetSelect(this.value);"></select></span>
					</div>
					<div class="col-4">
                        <span id="refcountry">Ref Country</span>
                        <span><select id="filter2" class="form-control"></select></span>
					</div>
					<div class="col-4">
                        <span id="tarregion">Cur Region</span>
                        <span><select id="filter3" class="form-control" onchange="targetSelect(this.value);"></select></span>
					</div>
					<div class="col-4">
                        <span id="tarcountry">Cur Country</span>
                        <span><select id="filter4" class="form-control"></select></span>
					</div>
                        <span id="selecttask">Action</span>
                        <span><select id="Select" class="form-control"></select></span>
                    </div>
                </div>
                <div class="mt-4"></div>
                <input type="button" id="upload1" value="Show Data" onclick="Compare()">
                <button id="button1" onclick="exportTableToExcel()">Export Table Data To Excel File</button>
                <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for detail.." title="Type in a name" style="display: none;">
                <div class="row">
                        <div id="result">Result</div>
                    </div>
                 <div id="Legend"></div>
				<label for="Legend" id="label">Different Items</label>
				<div id="REFFILE">Reference File : </div>
				<div id="CURRFILE">Current File : </div> 
				<div id="REFFILEVal"></div>
				<div id="CURRFILEVal"></div>				
            </div>
        
        <div id="hdExcel"></div>
        <div id="dvExcel"></div>
    
    






    <script type="text/javascript" src="./mrtcompare_files/xlsx.full.min.js.download"></script>
    <script type="text/javascript" src="./mrtcompare_files/jszip.js.download"></script>
    <script src="./mrtcompare_files/jquery-3.4.1.min.js.download"></script>
    <script type="text/javascript">
var file_1_path
var file_2_path
var url1
var url2

function upload(event) {
    event.preventDefault();
    var data = new FormData($('form').get(0));
	console.log($('form').get(0));
    console.log("Working");
	console.log(data)

	$.ajax({
		// url: $(this).attr('action'),
		url: "/mrt/upload",
		type: $(this).attr('method'),
		data: data,
		dataType: 'json',
		cache: false,
		processData: false,
		contentType: false,
		success: function(data) {
			// console.log(data);
			file_1_path = data['path_first_file'];
			file_2_path = data['path_second_file'];
			console.log(file_1_path, file_2_path);
			console.log('success');

			$('#upload').click();
		}
	});
	
	
    return false;
}

$(function() {
	// console.log(file_1_path, file_2_path);
    $('form').submit(upload);
	
});
        var data1 = null;
        var data2 = null;
        var timer = null;
        var filterValues = {};
        var tableData = null;
        var multipleNameCountriesMap = {};
        var refDetailHeaderCol = null;
        var tarDetailHeaderCol = null;
        var refRegionRow = -1;
        var tarRegionRow = -1;
	var refRow = -1;
	var tarRow = -1;
	var refCol = null;
	var tarCol = null;
        var fileName1 = 'Refernce';
        var fileName2 = 'Target';
       
        document.getElementById('loaderDiv').style.display = 'none';
        function myFunction() {
            console.log('hello');
            var input,
                filter,
                table,
                tr,
                td,
                i,
                txtValue;
            input = document.getElementById("myInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[0];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }

        function Process() {            
            document.getElementById('loaderDiv').style.display = 'block';
            //Reference the FileUpload element.
            var fileUpload1 = document.getElementById("id_file_source_1");
			var fileUpload2 = document.getElementById("id_file_source_2");
			document.getElementById("REFFILEVal").innerHTML=fileUpload1.files[0].name;
            document.getElementById("CURRFILEVal").innerHTML=fileUpload2.files[0].name;
            
            var refReq = new XMLHttpRequest();
            refReq.open("GET", file_1_path, true);
            refReq.responseType = "arraybuffer";
            refReq.onload = function (e) {
                var arraybuffer = refReq.response;
                var data = new Uint8Array(arraybuffer);
                var arr = new Array();
                for (var i = 0; i != data.length; ++i)
                    arr[i] = String.fromCharCode(data[i]);
                var bstr = arr.join("");
                data1 = ProcessExcel(bstr);
            }
            refReq.send();

            var tarReq = new XMLHttpRequest();
            tarReq.open("GET", file_2_path, true);
            tarReq.responseType = "arraybuffer";
            tarReq.onload = function (e) {
                var arraybuffer = tarReq.response;
                var data = new Uint8Array(arraybuffer);
                var arr = new Array();
                for (var i = 0; i != data.length; ++i)
                    arr[i] = String.fromCharCode(data[i]);
                var bstr = arr.join("");
                data2 = ProcessExcel(bstr);
            }
            tarReq.send();

            
          /*  var selectArr = [{
				name: 'All Items',
				value: 0
			}, {
				name: 'Deleted Items',
				value: 1
			}, {
				name: 'New Items',
				value: 2
			}, {
				name: 'Different Items',
				value: 3
			}, {
				name: 'Similar Items',
				value: 4
			}
            ];
            for (var i = 0; i < selectArr.length; i++) {
                var option = document.createElement("option");
                option.text = selectArr[i].name;
                option.value = selectArr[i].value;
                var select = document.getElementById("Select");
                select.appendChild(option);
            }*/
            timer = setInterval(()=>{
                if(data1 && data2){
                    console.log(data1, data2);
                    clearInterval(timer);
                    navigate();
                }
            }, 100);

        };
        function navigate() {
                if(data1.type == 'invalid' || data2.type == 'invalid'){
                    document.getElementById('loaderDiv').style.display = 'none';
                    document.getElementById('firstPageButtons').style.display = 'blocks';
                    alert('Please select valid MRT/PRT Excel files.');
                }
                else {
				var fileUpload1 = document.getElementById("id_file_source_1");
				var fileUpload2 = document.getElementById("id_file_source_2");
				localStorage.setItem("url1", file_1_path); // Storing file1 path which returned from server after file decryption in localstorage
				localStorage.setItem("url2", file_2_path); // Storing file2 path which returned from server after file decryption in localstorage
				localStorage.setItem("f1", fileUpload1.files[0].name);// Storing file1 name in localstorage
				localStorage.setItem("f2", fileUpload2.files[0].name);// Storing file2 name in localstorage
                localStorage.setItem("reverse", 'false');
				
				//Above parameters will be used when we redirected to new page. selected files path and name will be picked from localstorage.
				// check loadcomplete() function which call on <body> onload event.
                
			
				if ((data1.type == 'MRT' && data2.type == 'PRT') || (data1.type == 'PRT' && data2.type == 'MRT')){
					if(data1.type == 'PRT') {
						localStorage.setItem("url2", file_1_path); // Storing file1 path which returned from server after file decryption in localstorage
				        localStorage.setItem("url1", file_2_path);
                        localStorage.setItem("f2", fileUpload1.files[0].name);// Storing file1 name in localstorage
                        localStorage.setItem("f1", fileUpload2.files[0].name);
				        localStorage.setItem("reverse", 'true');
                        
                    }
					window.location.href = "/mrt/mrt_prt_uni";
				}
				else if(data1.type == 'MRT' && data2.type == 'MRT'){
					window.location.href = "/mrt/mrt_mrt_uni";
				}
				else if(data1.type == 'PRT' && data2.type == 'PRT'){
					window.location.href = "/mrt/prt_prt_uni";
				}
                }

		}

    function ProcessExcel(data, fileNmae) {
        try{
        var workbook = XLSX.read(data, {
            type: 'binary'
        });
 
        //Fetch the name of First Sheet.
        var sheetsName = workbook.SheetNames;
        console.log(sheetsName);
		for(var i = 0;i < sheetsName.length; i++){
			if(sheetsName[i].toUpperCase().indexOf('DD LIST') >= 0 || sheetsName[i].toUpperCase().indexOf('OWNER INFO') >= 0){
				return { type: 'PRT' };
			}
            else if(sheetsName[i].toUpperCase() == 'MASTER SPECS ' || sheetsName[i].toUpperCase() == 'MASTER SPECS' || sheetsName[i] == 'Master 사양' || sheetsName[i].toUpperCase() == 'MASTER SPEC' || sheetsName[i].toUpperCase() == 'MASTER' ||sheetsName[i] == 'Master ì‚¬ì–‘'){
				return { type: 'MRT' };
			}
		}
		return { type: 'invalid' };
        } catch(err) { return {type: 'invalid'}}
    };
</script>


</body></html>
