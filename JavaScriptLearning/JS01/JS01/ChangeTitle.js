window.onload = function () {
    setInterval(function () {
        var title = document.title;
        var firstChar = title.charAt(0);
        var othChar = title.substring(1);
        document.title = othChar + firstChar;

        //尾换头
    }, 1000);

    //需要有标题没有标题就没有效果

    

};

window.onbeforeunload = function () {
    //window.event.returnValue = false;
    return '你真的要离开吗emmmmm....';
};