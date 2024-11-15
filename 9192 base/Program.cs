using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9192_base
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        public static Node<int> Delete(int num, Node<int> lst)
        {
            // Create a dummy head node to simplify deletion, especially at the head of the list
            Node<int> dummy = new Node<int>(0); // The value here is arbitrary
            dummy.SetNext(lst);

            Node<int> current = dummy;

            // Traverse the list
            while (current.GetNext() != null)
            {
                // If the next node's value matches 'num', remove it
                if (current.GetNext().GetValue() == num)
                {
                    current.SetNext(current.GetNext().GetNext());
                }
                else
                {
                    // Move to the next node
                    current = current.GetNext();
                }
            }

            // Return the head of the modified list, skipping the dummy node
            return dummy.GetNext();
        }
    }

    public class BiList
    {
        private Node<int> lst1; // First linked list
        private Node<int> lst2; // Second linked list

        // Constructor initializes the lists as empty
        public BiList()
        {
            lst1 = null;
            lst2 = null;
        }

        // Method to add a number to the appropriate list based on `codeList`
        public void AddNum(int num, int codeList)
        {
            Node<int> newNode = new Node<int>(num);

            if (codeList == 1) // Add to lst1
            {
                newNode.SetNext(lst1);
                lst1 = newNode;
            }
            else if (codeList == 2) // Add to lst2
            {
                newNode.SetNext(lst2);
                lst2 = newNode;
            }
            else
            {
                Console.WriteLine("Invalid codeList value. Please use 1 or 2.");
            }
        }
    }




}
