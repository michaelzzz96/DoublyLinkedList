using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        /// <summary>
        /// The first node in the linked list
        /// </summary>
        public Node head = null;

        /// <summary>
        /// // Insert Nodes at front on the list 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="newData"></param>
        public void InsertFront(DoublyLinkedList list, double newData)
        {
            // Create Node object
            Node newNode = new Node(newData);
            newNode.next = list.head;
            newNode.previous = null;
            if (list.head != null)
            {
                list.head.previous = newNode;
            }// end if
            list.head = newNode;


        }//end Method

        /// <summary>
        ///  Insert Nodes at end on the list 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="newData"></param>
        public void InsertLast(DoublyLinkedList list, double newData)
        {
            // Create Node object
            Node newNode = new Node(newData);

            if (list.head == null)
            {
                newNode.previous = null;
                list.head = newNode;
                return;
            }// end if

            Node lastNode = GetLastNode(list);
            lastNode.next = newNode;
            newNode.previous = lastNode;




        }// end method

        /// <summary>
        /// // Get the last node in the list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Node GetLastNode(DoublyLinkedList list)
        {
            // Create Node object
            Node tempNode = list.head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
  
               
            }//end loop

            return tempNode;

        }//end method

        /// <summary>
        /// // Get the  first node in the list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Node GetFirstNode(DoublyLinkedList list)
        {

            Node tempNode = list.head;
            if(list.head == null)
            {
                return null;
            }//end if
            return tempNode;

        }//end method

        //Insert Nodes in the list
        public void InsertAfter(Node prevNode, double newData)
        {

            if(prevNode == null)
            {
                Console.WriteLine("No Previous node found.");
                return;

            }//end if

            Node newNode = new Node(newData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
            newNode.previous = prevNode;
            if (newNode.next != null)
            {
                newNode.next.previous = newNode;
            }

        }//end method

        /// <summary>
        /// // Get Number of Nodes
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int GetNumNodes(DoublyLinkedList list)
        {

            Node node = list.head;
            int result = 0;

            if (node != null)
            {

                result++;

                while (node.next != null)
                {
                    node = node.next;
                    result++;
                }//end loop

            }// end if

            return result;

        }//end method

       
    }//end class
}//end namespace
