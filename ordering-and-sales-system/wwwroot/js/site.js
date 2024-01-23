$(".menu > ul > li").click(function (e) {
    e.stopPropagation();

    const isActive = $(this).hasClass("active");

    // Close other submenus and remove active class
    $(".menu > ul > li").not(this).removeClass("active").find("ul").slideUp();

    // Toggle active class for the clicked item
    $(this).toggleClass("active", !isActive);

    if (!isActive) {
        // If the item is not active, show its submenu
        $(this).find("ul").slideDown();
    }
});

$(".menu > ul > li > ul > li").click(function (e) {
    e.stopPropagation();

    // Toggle active class for the clicked submenu item
    $(this).toggleClass("active");

    // Prevent submenu from closing when clicking inside it
    e.stopPropagation();
});

$(document).click(function () {
    // Close all items and submenus when clicking outside the menu
    $(".menu > ul > li").removeClass("active").find("ul").slideUp();
});

// Preserve hover effect for active items
$(".menu > ul > li").hover(
    function () {
        if ($(this).hasClass("active")) {
            $(this).addClass("hover");
        }
    },
    function () {
        $(this).removeClass("hover");
    }
);
