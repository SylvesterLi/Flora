window.onload = function () {
    var timerId;
    //document.getElementById('btn').value = 'aaa';
    //找到btn 绑定开始事件
    document.getElementById('intervalStart').onclick = function () {
        //开始计时
        timerId = setInterval(function () {
            //++
            document.getElementById('txt').value++;
        }, 500);
        
        console.log(timerId);

    };
    document.getElementById('intervalStop').onclick = function () {
        //停止计时
        window.clearInterval(timerId);
        console.log(timerId);
    };

}