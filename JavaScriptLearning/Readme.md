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



