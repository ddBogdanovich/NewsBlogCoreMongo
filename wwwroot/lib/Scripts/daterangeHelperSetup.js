<script type="text/javascript">
    $(document).ready(function () {

            $("#input-44").fileinput({
                uploadUrl: 'asdf/adf',
                showCaption: true,
                maxFilePreviewSize: 10240,
                maxFileCount: 5,
                allowedFileExtensions: ["jpg", "gif", "png"],
                elErrorContainer: "#errorBlock",
                showUpload: false,
                layoutTemplates: {
                    main1: "{preview}\n" +
                        "<div class=\'input-group {class}\' style=\"position: inherit\">\n" +
                        "   <div class=\'input-group-btn\'>\n" +
                        "       {browse}\n" +
                        "       {remove}\n" +
                        "   </div>\n" +
                        "   {caption}\n" +
                        "</div>",
                    actions: '<div class="file-actions">\n' +
                        '    <div class="file-footer-buttons">\n' +
                        '        {delete} {zoom}' +
                        '    </div>\n' +
                        '    {drag}\n' +
                        '    <div class="file-upload-indicator" title="{indicatorTitle}">{indicator}</div>\n' +
                        '    <div class="clearfix"></div>\n' +
                        '</div>',

                }
            });

            $('.deleteItem').click(function (e) {
                e.preventDefault();
                var $ctrl = $(this);
                if (confirm('Do you really want to delete this file?')) {
                    $.ajax({
                        url: '@Url.Action("DeleteFile")',
                        type: 'POST',
                        data: { id: $(this).data('id') }
                    }).done(function (data) {
                        if (data.Result == "OK") {
                            $ctrl.closest('li').remove();
                            $ctrl.closest('div').remove();
                        }
                        else if (data.Result.Message) {
                            alert(data.Result.Message);
                        }
                    }).fail(function () {
                        alert("There is something wrong. Please try again.");
                    })

                }
            });
        }
    )
    </script>