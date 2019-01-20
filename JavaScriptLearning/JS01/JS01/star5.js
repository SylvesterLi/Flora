//星星评价：
window.onload = function () {
    //获取所有td
    var tds = document.getElementsByTagName('td');
    for (var i = 0; i < tds.length; i++) {
        tds[i].onmouseover = function () {
            for (var j = 0; j < tds.length; j++) {
                tds[j].style.backgroundImage = "url('src/star2.png')";
                if (tds[j] === this) {
                    break;
                }
            }


        };



        tds[i].onmouseout = function () {

            for (var j = 0; j < tds.length; j++) {
                tds[j].style.backgroundImage = "url('src/star.png')";
                if (tds[j] === this) {
                    break;
                }


            }
        };


        tds[i].onclick = function () {
            for (var j = 0; j < tds.length; j++) {
                tds[j].removeAttribute('isclicked');
            }
            this.setAttribute('isclicked', 'isclicked');
        };





    }//for循环


};