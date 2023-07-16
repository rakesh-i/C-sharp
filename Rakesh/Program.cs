namespace Rakesh
{
    internal class Node
    {
        public int val;
        public Node next;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Node root = new Node();
            root = null;
            /*insert(ref root, 1);
            insert(ref root, 2);
            insert(ref root, 3);
            insert(ref root, 4);
            insert(ref root, 5);
            insert(ref root, 6);*/
            insertfront(ref root, 0);
            print(ref root);
            
        }

        static void insert(ref Node head, int n)
        {
            Node temp = head;
            Node temp1 = new Node();
            temp1.next = null;
            temp1.val = n;
            if (head == null)
            {
                head = temp1;
                return;
            }
            while (temp.next!=null)
            {
                   temp = temp.next;
            }
            temp.next = temp1;
        }

        static void insertfront(ref Node head, int n)
        {
            Node temp = head;
            Node temp1 = new Node();
            temp1.next = null;
            temp1.val = n;
            if (head == null)
            {
                head = temp1;
                return;
            }
            temp1.next = temp;
            head = temp1;
        }

        static void print(ref Node head)
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.val+ " ");
                temp = temp.next;
            }
        }

    }
}