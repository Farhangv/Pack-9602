//var johndoe = {
//    name: "John",
//    family: "Doe",
//    courses: ["C#", "Java", "PHP"],
//    address: {
//        city: "Tehran",
//        street: "Ebn Sina"
//    },
//    writeDetails: function(){
//        console.log(this.name + " " + this.family);
//    }
//};

//var johndoe = new Object();
//johndoe.name = "John";
//johndoe.family = "Doe";
//johndoe.courses = ["C#", "Java", "PHP"];
//johndoe.address = {
//    city: "Tehran",
//    street: "Ebn Sina"
//};
//johndoe.writeDetails = function () {
//    console.log(this.name + " " + this.family);
//};

function Person()
{
    this.name = "";
    this.family = "";
    this.courses = [];
    this.address = {
            city: "",
            street: ""
    };
    this.writeDetails = function () {
            console.log(this.name + " " + this.family);
    };
}

var johndoe = new Person();
johndoe.name = "John";
johndoe.family = "Doe";
johndoe.courses = ["C#", "Java", "PHP"];
johndoe.address = {
    city: "Tehran",
    street: "Ebn Sina"
};

console.log(johndoe instanceof Person);

johndoe.courses.push("HTML");
johndoe.courses.push("JavaScript");
console.log(typeof (johndoe));
johndoe.address.city = "Shiraz";
johndoe.writeDetails();
console.log(johndoe.address.city);
for (var i = 0; i < johndoe.courses.length; i++) {
    console.log(johndoe.courses[i]);
}
johndoe.courses.splice(1, 1);
for (var i = 0; i < johndoe.courses.length; i++) {
    console.log(johndoe.courses[i]);
}
