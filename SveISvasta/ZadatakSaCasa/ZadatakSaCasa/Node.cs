using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
    class Node {
        public int vrednost;
        public Node sledeci;

        public Node(int i) {
            vrednost = i;
            sledeci = null;
        }
        public void AddPoslednji(int vrednost) {
            if (sledeci == null) {
                sledeci = new Node(vrednost);
            }
            else {
                sledeci.AddPoslednji(vrednost);
            }
        }
        public void AddSortovano(int vrednost) {
            if (sledeci == null) {
                sledeci = new Node(vrednost);
            }
            else if (vrednost < sledeci.vrednost) {
                Node temp = new Node(vrednost);
                temp.sledeci = this.sledeci;
                this.sledeci = temp;
            }
            else {
                sledeci.AddSortovano(vrednost);
            }
        }




    }
}
