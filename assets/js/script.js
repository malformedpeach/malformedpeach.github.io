
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