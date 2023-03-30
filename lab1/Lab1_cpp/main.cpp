#include <iostream>
#include <clocale>
#include <windows.h>
#include <string.h>


void binary(char symbol, char output[9]);

int main() {
    register char output[9] = {0};
    register char symbol;
    register std::string str = "null";

    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    setlocale(LC_ALL, "");

    while (str.length() != 1) {
        std::cout << "Введите символ " << "\n";
        std::cin >> str;
    }

    symbol = str[0];

    binary(symbol, output);

    std::cout << "Ваш символ: " << symbol << " ("<< output << ")" <<"\n";

    for (register int i = 1; i < 5; i++) {
        symbol = symbol << 1;
        binary(symbol, output);
        std::cout << "Ваш символ со сдвигом на " << i << ": " << symbol << " ("<< output << ")" <<"\n";
    }

    system("pause");
    return 0;
}


void binary(char symbol, char output[9]) {
    std::fill_n(output, 9, 0);
    itoa((unsigned char)symbol, output, 2);

    register int i = 0;
    while (output[7] == 0) {
        for (register int j = 7 - 1; j != -1; j--)
            output[j + 1] = output[j];
        output[i++] = '0';
    }
}
