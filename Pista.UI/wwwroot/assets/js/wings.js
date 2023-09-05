$(document).ready(function () {
    var sideMenu = $('#side-menu').metisMenu();

    new DataTable('.wingsDataTable');

    feather.replace();

    assignContentArea()

    // profile
    $(".aggrement, .resume, .job-description").css("height", $(".profile-info").height() + 44);

    // profile edit
    $(document).on('click', '.profile-edit', function () {
        $(".form-control.editable").prop("readonly", false);
        $(".profile-edit").hide();
    })
});

function assignContentArea() {
    // Caculate Height of Content div
    var windowHeight = window.innerHeight;

    var panel = document.querySelector(".panel");
    var panelHeight = panel.offsetHeight - 30;

    var header = document.querySelector(".header");
    var headerHeight = header.offsetHeight + 30;

    var subMenu = document.querySelector(".sub-menu-tab");
    var subMenuHeight = 0;
    if (subMenu?.checkVisibility()) {
        subMenuHeight = subMenu.offsetHeight + 25;
    }

    var interactionBar = document.querySelector("#interactionBar");
    var interactionBarHeight = 0;
    if (interactionBar?.checkVisibility()) {
        interactionBarHeight = interactionBar.offsetHeight + 25;
    }

    var contentHeight = windowHeight - (headerHeight + subMenuHeight + interactionBarHeight) - 30;

    console.log(windowHeight);
    console.log(headerHeight + subMenuHeight + interactionBarHeight);

    var contentDiv = document.querySelector("#contentDiv");
    contentDiv.style.height = contentHeight + "px";
}
