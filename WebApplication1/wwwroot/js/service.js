function Service(serviceId, servicePriority, serviceWorker,personalNameSurname, servisStatus,serviceDelayStatus
    , deviceStatus, guaranteeStatus, deviceServiceReason, deviceChangingParts
    , deviceServiceHistory, deviceDateEntry, deviceDeliverEntry
    , deviceProcessingTime, computerId) {


    this.ServiceId = serviceId;
    this.ServicePriority = servicePriority;
    this.ServiceWorker = serviceWorker;
    this.PersonalNameSurname = personalNameSurname;
    this.ServisStatus = servisStatus;
    this.ServiceDelayStatus = serviceDelayStatus;
    this.DeviceStatus = deviceStatus;
    this.GuaranteeStatus = guaranteeStatus;
    this.DeviceServiceReason = deviceServiceReason;
    this.DeviceChangingParts = deviceChangingParts;
    this.DeviceServiceHistory = deviceServiceHistory;
    this.DeviceDateEntry = new Date(deviceDateEntry);
    this.DeviceDeliverEntry = new Date(deviceDeliverEntry);
    this.DeviceProcessingTime = this.calculateProcessingTime();
    this.ComputerId = computerId;
}
Service.prototype.calculateProcessingTime = function () {
    var diff = new Date(this.DeviceDeliverEntry - this.DeviceDateEntry);
    var days = diff / 1000 / 60 / 60 / 24;
    return days + " gün";
}
let serviceList = [];

let service1 = new Service("1", "abc", "abc","abc", "True", "False", "asdasd",
    "True", "asdas", "adasds", "adsd", "2023-05-23 00:00:00.0000000"
    , "2023-05-23 00:00:00.0000000", "1", "1");

serviceList.push(service1);
let table = document.getElementById('serviceTable').getElementsByTagName('tbody')[0];

serviceList.forEach(service => {
    let row = table.insertRow();

    let cell1 = row.insertCell(0);
    let cell2 = row.insertCell(1);
    let cell3 = row.insertCell(2);
    let cell4 = row.insertCell(3);
    let cell5 = row.insertCell(4);
    let cell6 = row.insertCell(5);
    let cell7 = row.insertCell(6);
    let cell8 = row.insertCell(7);
    let cell9 = row.insertCell(8);
    let cell10 = row.insertCell(9);
    let cell11 = row.insertCell(10);
    let cell12 = row.insertCell(11);
    let cell13 = row.insertCell(12);
    let cell14 = row.insertCell(13);
    let cell15 = row.insertCell(14);


    cell1.innerHTML = service.ServiceId;
    cell2.innerHTML = service.ServicePriority;
    cell3.innerHTML = service.ServiceWorker;
    cell4.innerHTML = service.ServisStatus
    cell5.innerHTML= service.ServiceDelayStatus;
    cell6.innerHTML = service.DeviceStatus;
    cell7.innerHTML = service.GuaranteeStatus;
    cell8.innerHTML = service.DeviceServiceReason;
    cell9.innerHTML = service.DeviceChangingParts;
    cell10.innerHTML = service.DeviceServiceHistory;
    cell11.innerHTML = service.DeviceDateEntry;
    cell12.innerHTML = service.DeviceDeliverEntry;
    cell13.innerHTML = service.DeviceProcessingTime;
    cell14.innerHTML = service.ComputerId;
    cell15.innerHTML = service.Computer.Personal.PersonalNameSurname;
});
$(document).ready(function () {
    $('.toggleSwitch').change(function () {
        var checkBox = $(this);
        swal({
            title: "Are you sure?",
            text: "Once deleted, you will not be able to recover this imaginary file!",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    swal("Poof! Your imaginary file has been deleted!", {
                        icon: "success",
                    });
                    checkBox.closest('form').attr('action', '/Service/DeleteService/' + checkBox.data('id')); 
                    checkBox.closest('form').submit();
                } else {
                    swal("Your imaginary file is safe!");
                    checkBox.prop('checked', !checkBox.is(':checked')); 
                    if (checkBox.is(':checked')) {
                        checkBox.siblings('#openBtn').prop('disabled', true);
                        checkBox.siblings('#closeBtn').prop('disabled', false);
                    }
                    else {
                        checkBox.siblings('#openBtn').prop('disabled', false);
                        checkBox.siblings('#closeBtn').prop('disabled', true);
                    }
                }
            });
    });
});
