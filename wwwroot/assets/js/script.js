
function getPreferedTheme() {

    let preferedTheme = "";

    if (window.matchMedia('(prefers-color-scheme: dark').matches) {
        preferedTheme = "dark";
    }
    else if (window.matchMedia('(prefers-color-scheme: light').matches) {
        preferedTheme = "light";
    }

    return preferedTheme;
}

function toggleExpand(button) {
    let expandable = button.nextElementSibling;

    if(expandable.style.maxHeight)
        expandable.style.maxHeight = null;
    else 
        expandable.style.maxHeight = expandable.scrollHeight + "px";
}


// window.addEventListener('scroll', function () {
//     // Scroll detection function, hide header on scroll down, show header on scroll up.
// });