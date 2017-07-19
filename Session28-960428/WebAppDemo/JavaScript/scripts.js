//console.log("From JS File");
//console.log(1 == 1);
//console.log(1 == "1");
//console.log(1 === "1");

var john;
console.log(typeof (john));
//console.log(typeof (sarah));
john = "John Doe";
console.log(typeof (john));
john = 123;
console.log(typeof (john));

var david = "David Doe";
console.log(typeof (david));

var siavash = null;
console.log(typeof (siavash));//Object
console.log(siavash);//null

//function authenticate(username, password)
//{
//    if (username == "admin" && password == "admin")
//    {
//        console.log("Welcome");
//        return true;
//    }
//}

var authenticate = function(username, password) {
    if (username == "admin" && password == "admin") {
        console.log("Welcome");
        return true;
    }
}

var authenticationResult = authenticate("admin", "admin");
console.log(typeof (authenticationResult));
console.log(typeof (authenticate));

