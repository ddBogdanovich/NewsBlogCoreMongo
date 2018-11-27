var start = moment();
$(document).ready(function () {
    $('input[name=Created]').daterangepicker(
        {
            startDate: start,
            singleDatePicker: true,
            timePicker: true,
            timePicker24Hour: true,
            timePickerIncrement: 1,
            locale: {
                format: 'DD-MM-YYYY hh:mm:ss A'
            }
        });

});