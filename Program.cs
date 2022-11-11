using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singly_Linked_List

{
    //each node_consist of the information part and lik to the next mode

    class Node
    {
        public int rolNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;

        public List()
        {
            START = null;
        }
        public void addNote() //add a note in the list
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student :");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rolNumber = nim;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if (START == null || nim <= START.rolNumber)
            {
                if ((START == null) && (nim == START.rolNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            //locate the position of the new node in the list
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rolNumber))
            {
                if (nim == current.rolNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            /*once the above for loop is executed, prev and current are positioned in such a manner that the position for the new node*/
            newnode.next = current;
            previous.next = newnode;

        }
        public void traverse()
        {
            if (listEmpty())
            {
                Console.WriteLine("\nList is empt,\n");
            }
            else
            {
                Console.WriteLine("\nThe records in the List are : ");
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rolNumber + "" + currentNode.name + "\n");

                Console.WriteLine();
            }
        }
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            //check if the spesified node is present in the list or not
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;

        }
        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while ((current != null) && (nim != current.rolNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return (false);
            else
                return (true);
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;

        }

    }
}
class Program
{
    //check wheter te specified node is present in the list or not
    static void Main(string[] args)
    {
        List obj = new List();
        while (true)
        {
            try
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Adda record to the list");
                Console.WriteLine("2. Delete a record ftom the list");
                Console.WriteLine("3. View all the records in the list");
                Console.WriteLine("4. Search for a record in the  list");
                Console.WriteLine("5.EXIT");
                Console.Write("\nEnter your choice (1-5): ");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        {
                            obj.addNote();
                        }
                        break;
                    case '2':
                        {
                            if (obj.listEmpty())
                            {
                                Console.WriteLine("\nList is empty");
                                break;
                            }
                            Console.Write("\nEnter the roll number of" + " the student whose record is to be delected: ");
                            int nim = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (obj.delNote(nim) == false)
                                Console.WriteLine("\nRecord not found.");
                            else
                                Console.WriteLine("Record with roll number " + nim + " Deleted");
                        }
                        break;
                    case '3':
                        {
                            obj.traverse();
                        }
                        break;
                    case '4':
                        {
                            if (obj.listEmpty() == true)
                            {
                                Console.WriteLine("\nList is empty !");
                                break;
                            }
                            Node previous,current;
                            previous = current = null;
                            Console.Write("\nEnter the roll number of the " + "student whose record is to be searched :");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if (obj.Search(num, ref previous, ref current) == false)
                                Console.WriteLine("\nRecord not found.");
                            else
                            {
                                Console.WriteLine("\nRecord found");
                                Console.WriteLine("\nRoll number: " + current.rolNumber);
                                Console.WriteLine("\nNama: " + current.name);
                            }
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("\nInvalid Option");
                            break;
                        }
                   }
            }
            catch (Exception e)
                {
                Console.WriteLine("\nCheck for the value enterd.");
                }
            }
        }
    }

