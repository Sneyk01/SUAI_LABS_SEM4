#include <iostream>
#include <cstdlib>
#include <ctime>


class cyl_jeff {
protected:
    std::string str_base = "QWERTYUIOPLKJHGFDSAZXCVBNM";
    int disks_index[32] = {0};
    std::string disks_value[32] = {""};
public:
    cyl_jeff() {
        //srand(time(NULL));
        char temp;

        for(int i = 0; i < 32; i++) {
            for(int j = 0; j < 26; j++) {
                temp = this->str_base[rand() % 26];
                while(this->disks_value[i].find(temp) != std::string::npos)
                    temp = this->str_base[rand() % 26];
                this->disks_value[i] += temp;
            }
        }
    }

    std::string create_cipher(int* index) {
        std::string src, work_str = "";
        std::cout << "Enter your message (max 32 symbols)\n";
        std::cin >> src;

        for (int i = 0; i < src.length(); i++)
            if (src[i] != ' ') {
                src[i] = std::toupper(src[i]);
                work_str.push_back(src[i]);
            }

        int len = work_str.length() < 33 ? work_str.length() : 32;

        for(int i = 0; i < len; i++) {
            int j = 0;
            while(work_str[i] != this->disks_value[i][j])
                j++;
            this->disks_index[i] = j;
        }

        int rnd = rand() % 25;
        std::string answer = "";
        for(int i = 0; i < 32; i++) {
            answer += this->disks_value[i][(this->disks_index[i] + rnd) % 26];
            index[i] = (this->disks_index[i] + rnd) % 26; // save our cipher indices
        }

        return answer;
    }


    void print_disk(int num) {
        std::cout << this->disks_value[num] << "\n";
    }

    void decipher(const int* index) {

        for(int i = 0; i < 26; i++) {
            for (int j = 0; j < 32; j++)
                std::cout << this->disks_value[j][(index[j]+i)%26];

            std::cout << "\n";
        }

    }
};

int main() {
    std::cout << "Hello, World!" << std::endl;
    cyl_jeff cyl;

    int* cip_data = new int[32];
    std::string cip_str = cyl.create_cipher(cip_data);


    std::cout << "Our cipher:\n"<< cip_str << "\n";

    std::cout << "Letter indices: \n";
    for(int i = 0; i < 32; i++)
        std::cout << i << ": " << cip_data[i] << " | ";
    std::cout << "\n";

    std::cout << "Ciphers: \n";

    cyl.decipher(cip_data);

    delete[] cip_data;
    return 0;
}
