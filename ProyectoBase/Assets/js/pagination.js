function addPaginationButtons(action,size) {
    var list = document.getElementsByClassName("pagination");
    list[0].insertAdjacentHTML("afterend", "<ul class='pagination' style='float:right'><li class='five'><a href='" + action + "?page=1&pageSize=5'>5</a></li><li class='ten'><a href='" + action + "?page=1&pageSize=10'>10</a></li><li class='twentyFive'><a href='" + action + "?page=1&pageSize=25'>25</a></li><li class='fifty'><a href='"+action+"?page=1&pageSize=50'>50</a></li><li class='hundred'><a href='" + action +"?page=1&pageSize=100'>100</a></li></ul>");
    switch (size) {
        case 5:
            $(".five").addClass("active");
            break;
        case 10:
            $(".ten").addClass("active");
            break;
        case 25:
            $(".twentyFive").addClass("active");
            break;
        case 50:
            $(".fifty").addClass("active");
            break;
        case 100:
            $(".hundred").addClass("active");
            break;
    }
} 