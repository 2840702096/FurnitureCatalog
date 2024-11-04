function AddFurniture() {

    $.ajax({
        url: "/Admin/AddOrEditFurniture",
        type: "Get",
        data: {},
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddOrEditFurnitureForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddOrEditFurnitureForm');

            $('#ModalTitle').html('افزودن مبلمان');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}


function AddOrEditFurnitureResult(data) {
    if (data.isSuccess == true) {
        swal.fire({
            title: data.title,
            text: data.message,
            icon: data.icon,
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'باشه'
        }).then(function (isConfirm) {
            location.replace("/Admin/Furnitures");
        });
    }
    else {
        swal.fire({
            title: data.title,
            text: data.message,
            icon: data.icon,
            showCancelButton: false,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'باشه'
        });
    }
}