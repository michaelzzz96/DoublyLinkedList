using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    // Node Class
    class Node
    {
        // Access Modifiers
        public double data;
        public Node next;
        public Node previous;

        // Constructor
        public Node(double d)
        {
            data = d;
            next = null;
            previous = null;
        }//end Constructor


    }//end class

}// end namespace
