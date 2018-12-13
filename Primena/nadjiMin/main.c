#include <stdio.h>
#include <stdlib.h>
#include <time.h>

double fRand(double fMin, double fMax)
{
    double f = (double)rand() / RAND_MAX;
    return fMin + f * (fMax - fMin);
}

double f(double x){
  // return x * x + 1/x;
  return  1 - x * x;
}

double monteKarlo(double pocetakIntervala, double krajIntervala, long long brojIteracija){
  double x, broj;
  broj = pocetakIntervala;
  for (long long i = 0; i < brojIteracija; ++i) {
    x = fRand(pocetakIntervala, krajIntervala);
    if (f(x) < f(broj)){
      broj = x;
    }
  }
  return broj;
}

int main(){
  srand(time(NULL));
  printf("%lf", monteKarlo(0, 1, 100000000));
  return 0;
}
