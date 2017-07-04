using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class Node
    {
        public int data;
        public int node;
        public Node next;

        public Node(int data, int node, Node next)
        {
            this.data = data;
            this.node = node;
            this.next = next;
        }

        public Node Next()
        {
            return next;
        }
    }


}
