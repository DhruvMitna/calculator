"use strict";
const ps = require("prompt-sync");
const input = ps();

var first = parseInt(input("Enter the first number: "));
var second = parseInt(input("Enter the second number: "));
var operation = input("Enter the operation to be done on the numbers (+ - * /): ");

switch (operation) {

    case "+":

        console.log(first + second)
        break;

    case "-":

        var order = parseInt(input("Enter 0 if you want to subtract the second number from the firstone and enter 0 if it is the oppostie: "));

        switch (order) {

            case 0:

                console.log(first - second);
                break;

            case 1:

                console.log(second - first);
                break;

            default:

                cosnole.log("Please enter a valid value.")
                break;

        }

        break;

    case "*":

        console.log(first * second);

    case "/":

        var order = parseInt(input("Enter 0 if you want to divide the first number by the second number and enter 1 if it is the opposite: "));

        switch (order) {

            case 0:

                console.log(first / second);
                break;

            case 1:

                console.log(second / first);
                break;

            default:

                console.log("Please enter a valid value.")
                break;

        }

    default:

        console.log("Please enter a valid value.");

}