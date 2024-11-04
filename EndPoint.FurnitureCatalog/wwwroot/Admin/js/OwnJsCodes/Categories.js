function EditCategory(id) {
    var PostData = {
        'editId': id
    };

    $.ajax({
        url: "/Admin/AddCategory",
        type: "Get",
        data: PostData,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddCategoryForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddCategoryForm');

            $('#ModalTitle').html('ویرایش گروه');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}

function DeleteCategory(id) {
    var PostData = {
        'id': id
    };

    swal.fire({
        title: 'حذف گروه',
        text: "آیا از حذف این گروه مطمعا هستید؟",
        icon: 'info',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله ',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {

            $.ajax({
                type: 'Post',
                url: '/Admin/DeleteCategory',
                data: PostData,
                success: function (data) {
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
                            if (data.isEdit == false) {
                                location.replace("/Admin/Categories");
                            }
                            else {
                                location.replace("/Admin/Categories?parentId=" + data.data);
                            }
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
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }

            });

        }
    })
}

function AddCategory(id) {
    var PostData = {
        'id': id
    };

    $.ajax({
        url: "/Admin/AddCategory",
        type: "Get",
        data: PostData,
        success: function (result) {
            $('#ModalBody').html(result);

            $('#AddCategoryForm').data('validator', null);
            $.validator.unobtrusive.parse('#AddCategoryForm');

            $('#ModalTitle').html('افزودن گروه');

            $('#Main').modal('show');
        },
        error: function () {

        }
    });
}


function ExecuteAddCategory(data) {
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
            if (data.isEdit == true) {
                location.replace("/Admin/Categories?parentId=" + data.data);
            }
            else {
                location.replace("/Admin/Categories");
            }
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