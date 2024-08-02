const html = document.querySelector("#tema");
const htmlColorMode = document.querySelector("#btn-tema");
const btnImg = document.querySelector(".btn.img")

htmlColorMode.addEventListener("click", () => {
    if(html.getAttribute("data-bs-theme") === "dark"){
        html.setAttribute("data-bs-theme","light");
        btnImg.src ="../Images/Sol.png" }
    else
        html.setAttribute("data-bs-theme","dark");
})
