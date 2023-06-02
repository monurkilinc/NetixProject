function Computer(computerBrand, computerSerialNo, computerYearOfProduction, operatingSystem, ram, cpu, graphicCard, serviceId) {
    this.ComputerBrand = computerBrand;
    this.ComputerSerialNo = computerSerialNo;
    this.ComputerYearOfProduction = computerYearOfProduction;
    this.OperatingSystem = operatingSystem;
    this.Ram = ram;
    this.CPU = cpu;
    this.GraphicCard = graphicCard;
    this.ServiceId = serviceId;
}

let computerList = [];

let computerList1 = new Computer("Lenovo IdeaPad 3", "81X800ENUS", "2022", "Windows", "8", " Intel Core i3-1115G4 Dual-Core 3.0GHz Processor", "1");


computerList.push(computerList1);

let table = document.getElementById('computerTable').getElementsByTagName('tbody')[0];

computerList.forEach(computer => {
    let row = table.insertRow();

    let cell1 = row.insertCell(0);
    let cell2 = row.insertCell(1);
    let cell3 = row.insertCell(2);
    let cell4 = row.insertCell(3);
    let cell5 = row.insertCell(4);
    let cell6 = row.insertCell(5);
    let cell7 = row.insertCell(6);
    let cell8 = row.insertCell(7);
    
    cell1.innerHTML = computer.ComputerBrand;
    cell2.innerHTML = computer.ComputerSerialNo;
    cell3.innerHTML = computer.ComputerYearOfProduction;
    cell4.innerHTML = computer.OperatingSystem;
    cell5.innerHTML = computer.Ram;
    cell6.innerHTML = computer.CPU;
    cell7.innerHTML = computer.GraphicCard;
    cell8.innerHTML = computer.ServiceId;
});