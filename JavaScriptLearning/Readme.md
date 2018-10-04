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

