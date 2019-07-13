using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublyLinkedList
{
    static class Project3
    {
        /// <summary>
        /// Michael Zulfekar n00929403
        /// Project 3
        /// Due Date: 11-29-18
        /// 
        /// Collarorated or Guided:
        /// 
        /// Jonathan Fuentes
        /// Arron Lipper
        /// Rachel Leaptrott
        /// Farhana Haque
        /// 
        /// The goal of the project is to learn and apply linked list 
        /// (Doubly and Singly). We created a linked list that prints out 
        /// 100 nodes forwards, backwards, and backwards with an extra 10
        /// nodes. 
        /// 
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DoublyLinkedListForm());
        }
    }
}
