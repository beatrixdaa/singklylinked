using System;


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
            if (START != null || nim <= START.rolNumber)
            {
            if ((START != null) && (nim == START.rolNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                }
            }
        }

    }
}
