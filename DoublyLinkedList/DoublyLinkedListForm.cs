using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublyLinkedList
{
    public partial class DoublyLinkedListForm : Form
    {
        public DoublyLinkedListForm()
        {
            InitializeComponent();
        }//end Constructor

        private void btnStart_Click(object sender, EventArgs e)
        {

            lstOutput.Items.Clear();

            #region Linked List Created
            //Random Object
            Random rand = new Random();
            int size = 3;

            //list object
            DoublyLinkedList list = new DoublyLinkedList();
            
            //iterate list from last
            for (int i = 0; i < size; i++ )
            {
                list.InsertLast(list, Math.Round(RandomDouble(rand, 0, 100.00), 2));
            }//end loop

            int numNodes = list.GetNumNodes(list);
            Console.WriteLine("Num Nodes is " + numNodes + ".");
            #endregion

            #region Print Linked List

            // Print Forward
            lstOutput.Items.Add(string.Format("{0}", "Nodes Printed Forwards:"));
            lstOutput.Items.Add(string.Format("{0}", "-----------------------------"));

            Node node = list.GetFirstNode(list);
            int index = 0;

            // Next Node
            while (node != null)
            {
                // Display Output
                lstOutput.Items.Add(string.Format("Node {0,2}:    {1:00.00}", index++, node.data));
                node = node.next;
            }//end loop

            lstOutput.Items.Add("");


            // Call node object
            node = list.GetLastNode(list);
            index = 0;

            // Print Backwards
            lstOutput.Items.Add(string.Format("{0}", "Nodes Printed Backwards:"));
            lstOutput.Items.Add(string.Format("{0}", "-----------------------------"));

            // Previous Node
            while (node != null)
            {
                // Display Output
                lstOutput.Items.Add(string.Format("Node {0,2}:    {1:00.00}", index++, node.data));
                node = node.previous;
            }//end loop

            #endregion

            // Print Backwards Plus 10
            lstOutput.Items.Add("");
            
            for (int i = 0; i < 10; i++)
            {
                list.InsertAfter(list.head.next, Math.Round(RandomDouble(rand, 0, 100.00), 2));

            }//end loop

            // Call node object
            node = list.GetLastNode(list);
            index = 0;

            // Print Backwards + 10
            lstOutput.Items.Add(string.Format("{0}", "Nodes Printed Backwards + 10:"));
            lstOutput.Items.Add(string.Format("{0}", "-----------------------------"));

            while (node != null)
            {
                lstOutput.Items.Add(string.Format("Node {0,2}:    {1:00.00}", index++, node.data));
                node = node.previous;
            }//end loop

        }// end method

        /// <summary>
        /// RandomDouble method to return range from min to max
        /// </summary>
        /// <param name="random"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double RandomDouble(Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;

        }//end method

        /// <summary>
        /// Restart the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }//end method

        private void DoublyLinkedListForm_Load(object sender, EventArgs e)
        {

        }
    }//end class

}//end namespace
