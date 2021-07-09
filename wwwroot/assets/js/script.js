
document.addEventListener('DOMContentLoaded', (event) => {
    let approot = document.querySelector('#malformedpeach-github-io');

    if (window.matchMedia('(prefers-color-scheme: dark').matches) {
        approot.classList.add('dark');
        approot.classList.remove('light');
    }

    //document.querySelector('#theme-toggle').addEventListener('click', function () {
    //    console.log("Heyho!");

    //    if (approot.classList.contains('light')) {
    //        approot.classList.add('dark');
    //        approot.classList.remove('light');
    //    }
    //    else if (approot.classList.contains('dark')) {
    //        approot.classList.add('light');
    //        approot.classList.remove('dark');
    //    }
    //});
});