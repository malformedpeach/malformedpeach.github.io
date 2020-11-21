

let foo = 0;

function checkTodo(element) {
    if(element.checked) {
        document.querySelector("#foo").classList = "todo-text-crossed";
    }
    else {
        document.querySelector("#foo").classList = "todo-text";
    }
}

function newElement() {

    // Get todo text input
    let inputText = document.querySelector("#new-todo").value;

    // Get todo template
    let template = document.querySelector("#todo-template").cloneNode();

    // Set text content on template
    template.textContent = inputText;
    template.removeAttribute("hidden");

    // add template to todo list
    document.querySelector("#todo-list-items").append(template);

        //< !--Template -->
        //    < !--< li id = "todo-template" hidden >
        //        <input type="checkbox" />
        //        <p class="todo-text"></p>
        //    </li > -->
}