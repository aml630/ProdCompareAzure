
$(".testButton").click(function () {
    console.log('working');
    $(".mainContainer").toggle("slow");

    $(".individualProduct").toggleClass("active", 500, "easeOutSine");
});

$(".learnMore").click(function () {

    $(".alignCenter").nextAll(".moreResources").eq(0).slideToggle();
})