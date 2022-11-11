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

            while ((current!= null) && (nim >= current.rolNumber))
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
            if (ListEmpty())
                Console.WriteLine("\nList is empt,\n");
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

    }
}
