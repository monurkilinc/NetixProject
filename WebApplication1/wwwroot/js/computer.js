function Computer(computerId, computerBrand, computerSerialNo, computerYearOfProduction, operatingSystem, ram, cpu, graphicCard) {
    this.ComputerId = computerId;
    this.ComputerBrand = computerBrand;
    this.ComputerSerialNo = computerSerialNo;
    this.ComputerYearOfProduction = computerYearOfProduction;
    this.OperatingSystem = operatingSystem;
    this.Ram = ram;
    this.Cpu = cpu;
    this.GraphicCard = graphicCard;
}

let computerList = [];

let computer1 = new Computer("1", "Lenovo", "81X800ENUS", "2022", "Windows", "8", "Intel Core i3-1115G4 Dual-Core 3.0GHz Processor", "Intel UHD Graphics");
let computer2 = new Computer("2", "Asus", "81X800eeee", "2021", "Windows", "16", "+Intel Core i5 Dual-Core 3.2GHz","Intel UHD Graphics");

computerList.push(computer1);
computerList.push(computer2);

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


    cell1.innerHTML = computer.ComputerId;
    cell2.innerHTML = computer.ComputerBrand;
    cell3.innerHTML = computer.ComputerSerialNo;
    cell4.innerHTML = computer.ComputerYearOfProduction;
    cell5.innerHTML = computer.OperatingSystem;
    cell6.innerHTML = computer.Ram;
    cell7.innerHTML = computer.Cpu;
    cell8.innerHTML = computer.GraphicCard;
});