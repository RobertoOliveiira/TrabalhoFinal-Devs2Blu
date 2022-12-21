let searchbtn = document.querySelector("#search");
let searchPizza = document.querySelector(".head .search-bar");
searchbtn.onclick = () => {
  searchPizza.classList.toggle("active");
  menu.classList.remove('active');
};

let menu = document.querySelector(".head .navbar");
document.querySelector('#bars').onclick = () =>{
  menu.classList.toggle('active');
  searchPizza.classList.remove('active')
}
window.onscroll = () => {
    menu.classList.remove('active');
    searchPizza.classList.remove('active')
}

