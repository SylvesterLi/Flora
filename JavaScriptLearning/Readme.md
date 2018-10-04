# JavaScript Learning Note

### 预解析问题：
```javascript
var user_name='steve';

function f1(){
    alert(user_name);
    var user_name='yzk';
    alert(user_name);
}

f1();
alert(user_name);
//结果：
//Undefine->yzk->steve
//原因：
//在f1函数中，预解析变量user_name，所以第一次alert出来是undefined，而第二次是yzk。第三次alert出来的是当前块的user_name，所以是steve
```
> 一般会在头部提前声明要使用的变量

```javascript
//匿名函数
//  1.不写函数名
var f1=function(){alert('hi');};
//  2.定义的同时直接调用
(function (x,y){alert(x+y);})(10,50);
//  3.使用Eval或者new Function
//      推荐使用new Function.Eval中的变量外部可访问到
var f1=new Function('x,y,z','alert(x+y+z);');
f1(1,2,3);
```

### 原型理解笔记Prototype

![](./NotePics/prototypeNote1.png)

> 给系统类型注册原型

> ![](./NotePics/stringPrototype.png)

### 继承

![](./NotePics/pt2.png)

### 动态注册事件

> 尽量多使用匿名函数
> 尽量使用动态注册事件

```html
<input type="button" id="onbtn" value="动态注册事件"/>
```

```javascript
window.onload = function () {
    //document.getElementById('btn').value = 'aaa';
    document.getElementById('onbtn').onclick = function () {
        //打印Date的正确方式
        alert(new Date().toLocaleDateString());
    };
}
```
``` xxx.onclick=fnClick;``` 与 ```xxx.onclick=fnClick();``` 的区别在于
> fnClick是赋值事件，fuClick()是赋值```函数处理后return```的结果(一般为undefined)

### SetInterval使用定时器

HTML代码：
```html
<input type="text" id="txt" value="0">
<input type="button" id="intervalStart" value="计时开始" />
<input type="button" id="intervalStop" value="计时结束" />
```

定时器使用代码：
```js
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
```

在使用时遇到一个问题：

![](./NotePics/errorStop.png)

当多次点击“计时开始”按钮时，“计时结束”按钮无法结束计时，并且计时速度明显增快，多点一次就更快一点。

为调查原因，使用了Console.log打印出TimerId。发现，clearInterval指定的id为7时才能停止Timer。


