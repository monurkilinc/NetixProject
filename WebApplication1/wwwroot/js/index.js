const sideMenu = document.querySelector("aside");
const menuBtn = document.querySelector("#menu-btn");
const closeBtn = document.querySelector("#close-btn");
const themeToggler = document.querySelector(".theme-toggler");
menuBtn.addEventListener("click", () => {
  sideMenu.style.display = "block";
});

closeBtn.addEventListener("click", () => {
  sideMenu.style.display = "none";
});

//change theme

themeToggler.addEventListener("click", () => {
  document.body.classList.toggle("dark-theme-variables");

  themeToggler.querySelector("span:nth-child(1)").classList.toggle("active");
  classList.toggle("active");
  themeToggler.querySelector("span:nth-child(2)").classList.toggle("active");
  classList.toggle("active");
});
const { Personal, PersonalList } = require('~/js/personal.js');

let personalList = new PersonalList();

let personal1 = new Personal("1", "Onur Kilinc", "28", "Male", "IT", "monurkilinc@gmail.com", "5372855545");
personalList.addPersonal(personal1);
personalList.printAllPersonals(); 
personalList.removePerson("1234"); 
personalList.printAllPersonals(); 
