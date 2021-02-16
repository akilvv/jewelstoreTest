function ExcelUpload(files) {
    var formData = new FormData();
    formData.append("file", files[0]);
    if (files.length == 0)
        return;
    $.ajax({
        url: 'Image/ExcelImportData',
        data: formData,
        type: "POST",
        dataType: 'json',
        contentType: false,
        processData: false,
        cache :false,
        success: function (data) {
            alert("image uploaded successfully");
            $("#fillbtn").click();
        },
        error: function (data) {
            alert("Please Try Again, Make sure the instructions given on the right are followed");
        }
    })
}       
