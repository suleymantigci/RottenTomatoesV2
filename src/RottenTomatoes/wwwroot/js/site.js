$('#txtmovieName').on('focus', function () {
    $('.offerList').show();
    $(".offerList").css("position", "absolute");
}).on('blur', function () {
    $('.offerList').hide();
});

$('ul').on('mousedown', function (event) {
    event.preventDefault();
}).on('click', 'li', function () {
    $('#txtmovieName').val(this.textContent).blur();
});
