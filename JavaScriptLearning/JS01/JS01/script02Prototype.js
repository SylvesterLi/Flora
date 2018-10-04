function Person(name, age, address) {
    this.user_name = name;
    this.user_age = age;
    this.user_address = address;
}

Person.prototype.sayHi = function () {
    alert(this.user_name + '  ' + this.user_age + '   ' + this.user_address + '   ' + this.email);
    //必须要加this
};
Person.prototype.email = 'default@prototype.com';
Person.prototype.phoneNumber = '1234567890';


var v1 = new Person();
v1.user_address = '地址1';
v1.user_age = 10;
v1.user_name = 'USR1';
v1.email = 'ccc@a.com';

var v2 = new Person();
v2.user_address = '地址2';
v2.user_age = 12;
v2.user_name = 'USR2';

v1.sayHi();
//v2.sayHi();

//-----------继承------------
var v3 = new Person();

function Student() { }
//原型为v3
Student.prototype = v3;

var s1 = new Student();
console.log(s1.phoneNumber);



//可以通过prototype给系统自带的String等添加函数