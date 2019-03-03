#include <iostream>

using namespace std;

//mrzi me da pisem optimizovano, ne treba mi mnogo za prolaz

bool daLiJeVeci(string &x, string &y){
  char duzina;
  duzina = y.length();
  for (char i = 0; i < duzina; ++i){
    if (x[i] > y[i]){
      return true;
    }
    else if (x[i] < y[i]){
      return false;
    }
  }
  return false;
}

int main(){
  string Sa, Sb, Sc;
  {
  long long a, b, c;
  cin >> a >> b >> c;

  Sa = to_string(a);
  Sb = to_string(b);
  Sc = to_string(c);
  }

  string najveci = Sa + Sb + Sc;
  string tmp = Sa + Sc + Sb;

  if (daLiJeVeci(tmp, najveci)){
    najveci = tmp;
  }
  tmp = Sb + Sc + Sa;
  if (daLiJeVeci(tmp, najveci)){
    najveci = tmp;
  }
  tmp = Sb + Sa + Sc;
  if (daLiJeVeci(tmp, najveci)){
    najveci = tmp;
  }
  tmp = Sc + Sa + Sb;
  if (daLiJeVeci(tmp, najveci)){
    najveci = tmp;
  }
  tmp = Sc + Sb + Sa;
  if (daLiJeVeci(tmp, najveci)){ 
    najveci = tmp; 
  }

  cout << najveci;

  return 0;
}
