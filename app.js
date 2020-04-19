function getData() {
    return [
        {
            "id": 1,
            "year": 2020,
            "model": "KANTS2",
            "region": "ATSC",
            "version": "version1"
        },
        {
            "id": 2,
            "year": 2020,
            "model": "KANTS2",
            "region": "ATSC",
            "version": "version2"
        }
    ];
};

function getSerielUsbData(id) {
    return false;
}


var app = new Vue(
    {
        el: "#app",
        data: {
            myData: getData(),
            text1: "",
            dropdown: "dropdown"
        },
        methods: {
            fn: function () {
                let str1 = this.text1;
                let str2 = this.dropdown;
                if (str2 == 'dropdown') {
                    alert('Gaand mara')
                } else {
                    fetch('http://107.108.167.20:80/blog_post', {
                        method: 'POST',
                        body: JSON.stringify( {
                            parameter1: str1,
                            parameter2: str2
                        })
                    })
                }
                this.dropdown = "dropdown";
            },
            seriel: function (id) {
                let ans = getSerielUsbData(id).seriel;
                if (ans == true) {
                    uploadSeriel(id);
                }
                else {
                    alert("image already present");
                }
            },
            usb: function (id) {
                let ans = getSerielUsbData(id).usb;
                if (ans == true) {
                    uploadUsb(id);
                }
                else {
                    alert("image already present");
                }
            }
        }
    }

);
