const ps = require("prompt-sync");
const input = ps();

var first = input("Enter the first number: ");
var second = input("Enter the second number: ");
var operation = input("Enter the operation to be done on the numbers (+ - * /): ");

if (operation === "+") console.log(first + second);

else if (operation === "-") {

    var order = input("Enter 0 if you want to subtract the second number from the first one and enter 1 if it is the opposite: ")

    if (order === 0) console.log(first - second);
    else if (order === 1) console.log(second - first);
    else console.log("Please enter a valid value.");

} else if (operation === "*") console.log(first * second);

else if (operation === "/") {

    var order = input("Enter 0 if you want to divide the first number by the second number and enter 1 if it is the opposite: ")

    if (order === 0) console.log(first / second);
    else if (order === 1) console.log(second / first);
    else console.log("Please enter a valid value.");

} else console.log("Please enter a valid value.");