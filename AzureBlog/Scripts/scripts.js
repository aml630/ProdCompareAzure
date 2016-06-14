
$(".testButton").click(function () {
    console.log('working');
    $(".mainContainer").toggle("slow");

    $(".individualProduct").toggleClass("active", 500, "easeOutSine");
});

$(".learnMore").click(function () {

    $(".alignCenter").nextAll(".moreResources").eq(0).slideToggle();
})



function next(x) {

    var total = $(".productParent").children().length;
    for (var i = 0; i< total; i = i+x)
    {
        //debugger;
        if( $(".productParent").children().eq(i).is(":visible")===true)
        {
            console.log('true')
            $(".productParent").children().eq(i).hide();
            $(".productParent").children().eq(i + x).show();
            if (i+1 === total)
            {
                $(".productParent").children().eq(0).show();
            }


    

            return "working";
        }
    }
    $(".productParent").children().eq(0).show();

}


$(".next").click(function () {
    next(1);
});


$('.prev').click(function () {

    next(-1);

});

window.onload = next(1);

setInterval(function () {
    next(1);
}, 5000);


