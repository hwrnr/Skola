#include <iostream>
#include <ctime>
#include <cstdlib>

#define BROJ_POKUSAJA 3500000000

using namespace std;

class Karta{
  public:
    int vrednost;
    char znak;
    
    Karta(){
      int temp = 0;
      while (temp == 0){
        temp = rand() % 5;
      }
      switch (temp){
        case 1:
          znak = 's';
          break;
        case 2:
          znak = 'k';
          break;
        case 3:
          znak = 'l';
          break;
        case 4:
          znak = 'm';
          break;
      }
      vrednost = 0;
      while (vrednost == 0){
        vrednost = rand() % 14;
      }
    }

};

int main(){
  srand(time(NULL));

  unsigned long long i = BROJ_POKUSAJA;
  unsigned long long brojUspesnih = 0;
  for (; i > 0; --i){
    Karta k1, k2;
    if (k1.znak == k2.znak) ++brojUspesnih;
  }

  cout << brojUspesnih << " / " << BROJ_POKUSAJA << " = " << (double)brojUspesnih / (double) BROJ_POKUSAJA << endl;
  return 0;
}
