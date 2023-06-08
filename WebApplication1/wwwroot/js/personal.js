function Personal(personalId, personalNameSurname, personalAge, personalGender, personalDepartment, computerBrand, personalMail, personalCellPhoneNumber) {
    this.PersonalId = personalId;
    this.PersonalNameSurname = personalNameSurname;
    this.PersonalAge = personalAge;
    this.PersonalGender = personalGender;
    this.PersonalDepartment = personalDepartment;
    this.ComputerBrand = computerBrand;
    this.PersonalMail = personalMail;
    this.PersonalCellPhoneNumber = personalCellPhoneNumber;
}

personalList.push(Personal);

let table = document.getElementById('personalTable').getElementsByTagName('tbody')[0];

personalList.forEach(personal => {
    let row = table.insertRow();

    let cell1 = row.insertCell(0);
    let cell2 = row.insertCell(1);
    let cell3 = row.insertCell(2);
    let cell4 = row.insertCell(3);
    let cell5 = row.insertCell(4);
    let cell6 = row.insertCell(5);
    let cell7 = row.insertCell(6);
    let cell8 = row.insertCell(7);

    cell1.innerHTML = personal.PersonalId;
    cell2.innerHTML = personal.PersonalNameSurname;
    cell3.innerHTML = personal.PersonalAge;
    cell4.innerHTML = personal.PersonalGender;
    cell5.innerHTML = personal.PersonalDepartment;
    cell6.innerHTML = personal.ComputerBrand;
    cell7.innerHTML = personal.PersonalMail;
    cell8.innerHTML = personal.PersonalCellPhoneNumber;
});

$(document).ready(function () {
    $.ajax({
        url: '/PersonalController/GetPersonelDifferences',
        type: 'GET',
        success: function (data) {
            let table = document.getElementById('personalTable').getElementsByTagName('tbody')[0];

            data.forEach(personal => {
                let row = table.insertRow();

                let cell1 = row.insertCell(0);
                let cell2 = row.insertCell(1);
                let cell3 = row.insertCell(2);
                let cell4 = row.insertCell(3);
                let cell5 = row.insertCell(4);
                let cell6 = row.insertCell(5);
                let cell7 = row.insertCell(6);
                let cell8 = row.insertCell(7);

                cell1.innerHTML = personal.PersonalId;
                cell2.innerHTML = personal.PersonalNameSurname;
                cell3.innerHTML = personal.PersonalAge;
                cell4.innerHTML = personal.PersonalGender;
                cell5.innerHTML = personal.PersonalDepartment;
                cell6.innerHTML = personal.ComputerBrand;
                cell7.innerHTML = personal.PersonalMail;
                cell8.innerHTML = personal.PersonalCellPhoneNumber;
            });
        }
    });
});
