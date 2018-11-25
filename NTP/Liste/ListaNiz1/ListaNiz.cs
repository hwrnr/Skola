using System;

class ListaNiz<T>{
  private T[] niz;
  private uint length;
  uint Duzina { get{return length;}}

  public ListaNiz() {
    length = 0;
    niz = new T[8];
  }

  private bool changeSize(){
    if (length != niz.Length){
      return false;
    }
    Array.Resize(ref niz, niz.Length * 2);
    return true;
  }

  public bool Add(T t, uint index){
    this.changeSize();
    if (index > length) return false;
    for (uint i = length; i > index; --i){
      niz[i] = niz[i - 1];
    }
    niz[index] = t;
    ++length;
    return true;
  }

  public bool AddLast(T t){
    return this.Add(t, length);
  }

  public bool AddFirst(T t){
    return this.Add(t, 0);
  }

  public bool Delete(int index){
    if (index >= length) return false;
    for (int i = index; i < length - 1; ++i){
      niz[i] = niz[i + 1];
    }
    --length;
    return true;
  }

  public bool Push(T t){
    return this.AddLast(t);
  }

  public T Pop(){
    if (length == 0) throw new System.InvalidOperationException("Can't pop from empty list");
    T tmp = niz[length - 1];
    this.Delete((int)length - 1);
    return tmp;
  }

  public void Clear(){
    niz = new T[8];
    length = 0;
  }
  
  public bool isEmpty(){
    return length == 0;
  }

  public override string ToString(){
    string str = "";
    for (int i = 0; i < this.length; ++i){
      str += niz[i] + Environment.NewLine;
    }
    return str;
  }
}
