export function jsIsolation(value) {
    console.log(value);
} 

//export function rightClickArrow() {
//    const carousel = document.querySelector(".carousel");
//    const firstImg = carousel.querySelectorAll(".img")[0];
//    const arrowIcons = document.querySelectorAll(".wrapper i");

//    let firstImgWidth = firstImg.clientWidth + 14;

//    arrowIcons.forEach(icon => {
//        icon.addEventListener("click", () => {
//            carousel.scrollLeft += icon.id == "left" ? - firstImgWidth : firstImgWidth;
//        });
//    });
//}