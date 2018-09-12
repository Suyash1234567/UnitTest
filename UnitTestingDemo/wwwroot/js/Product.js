$('[data-attr="search"]').on('click', function () {
    alert('working');

    var obj = { 'CustomerType': $('#CustomerType  option:selected').val(), 'ProductId': $('#product  option:selected').val()};
    //alert(obj);
    $.ajax(
        {
            type: "POST",
            url: "/Product/Index",
            data: obj,
            success: function (response) {
                console.log(response);
                debugger;
                //$('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html("Discounted Price: "+ response);
                
                // console.log(response);
            },
            error: function (err) {
                //console.log(err);
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(err.statusText);
            }
        });
});