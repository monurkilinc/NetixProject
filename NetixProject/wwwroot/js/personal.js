function Personal(personalId, personalNameSurname, personalAge, personalGender, personalDepartment, personalMail, personalCellPhoneNumber) {
    this.PersonalId = personalId;
    this.PersonalNameSurname = personalNameSurname;
    this.PersonalAge = personalAge;
    this.PersonalGender = personalGender;
    this.PersonalDepartment = personalDepartment;
    this.PersonalMail = personalMail;
    this.PersonalCellPhoneNumber = personalCellPhoneNumber;
}

let personalList = [];

let personal1 = new Personal("1234", "Ahmet Y�lmaz", "35", "Male", "IT", "ahmet.yilmaz@email.com", "+905551112233");
let personal2 = new Personal("5678", "Ay�e Kaya", "27", "Female", "Sales", "ayse.kaya@email.com", "+905551122334");

personalList.push(personal1);
personalList.push(personal2);

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

    cell1.innerHTML = personal.PersonalId;
    cell2.innerHTML = personal.PersonalNameSurname;
    cell3.innerHTML = personal.PersonalAge;
    cell4.innerHTML = personal.PersonalGender;
    cell5.innerHTML = personal.PersonalDepartment;
    cell6.innerHTML = personal.PersonalMail;
    cell7.innerHTML = personal.PersonalCellPhoneNumber;
});