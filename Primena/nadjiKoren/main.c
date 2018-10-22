#include <stdio.h>
#include <stdlib.h>
#include <time.h>

double nadjiKoren(double x){
  //radi za x > 1
  long long brojilo = 10000000;
  double levi = 1;
  double desni = x;
  double pokusaj = (levi + desni)/2;
  while (pokusaj * pokusaj != x){
    if (pokusaj * pokusaj > x){
      desni = pokusaj;
    }
    else (levi = pokusaj);
    pokusaj = (levi + desni)/2;
    if (brojilo < 0) break;
    else brojilo--;
  }
  return pokusaj;
}

int main(){
  printf("%1.19lf\n", nadjiKoren(2));
  return 0;
}
