# include <iostream>

int main() {

    double first,second;
    std::string operation;

    std::cout << "Enter the first number: ";
    std::cin >> first;

    std::cout << "Enter the second number: ";
    std::cin >> second;

    std::cout << "Enter the operation you want to apply to the numbers (+ - * /)\n\n>";
    std::cin >> operation;

    if (operation == "+") {

        std::cout << first + second;

    } else if (operation == "-") {

        if (first > second) {

            std::cout << first - second;

        } else {

            std::cout << second - first;

        }

    } else if (operation == "/") {

        if (second > first) {

            std::cout << second / first;

        } else {

            std::cout << first / second;

        }

    } else if (operation == "*") {

        std::cout << first * second;

    } else {

        std::cout << "Invalid opeartion.";

    }

    return 0;

}