
var oHide = document.querySelector(".palette");
var hidden1 = document.querySelector(".hidden1");
var hidden2 = document.querySelector(".hidden2");
var hidden3 = document.querySelector(".hidden3");
var button1 = document.querySelector(".button1");
var button2 = document.querySelector(".button2");
var button3 = document.querySelector(".button3");
var wide = document.querySelector(".wide");

function a(){
 oHide.style.display = "block";
  hidden1.style.display = "block";
  wide.style.display = "block";
}
if(button1){
button1.addEventListener("click", a());
}
if(button2){
button2.addEventListener("click", function ab(){
  oHide.style.display = "block";
  hidden2.style.display = "block";
  wide.style.display = "block";
});
}
if(button3){
button3.addEventListener("click", function abc(){
  oHide.style.display = "block";
  hidden3.style.display = "block";
  wide.style.display = "block";
});
}

if(oHide){
oHide.addEventListener("click", function abcd(){
  oHide.style.display = "none";
  hidden1.style.display = "none";
  hidden2.style.display = "none";
  hidden3.style.display = "none";
  wide.style.display = "none";
});
}