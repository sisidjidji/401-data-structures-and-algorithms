namespace Data_Structures
{
    public class LinkedList
    {

        private Node head;

        public void Insert(int numb)
        {
            Node newNode = new Node(numb);

            // Point newNode to rest of the old list
            if (head != null)
            {
                newNode.Next = head;
            }

            head = newNode;
        }

        public bool Include(int val)
        {
            Node newNode = new Node(val);

            while (head != null)
            {
                if (newNode.Value != val)
                {
                    return true;

                }
                else
                {
                    newNode.Next = head;
                }

            }
            return false;
        }

        public string toString()
        {
            Node current = head;

            string result = "";
            while (current != null)
            {
                result += $"{{{current.Value}}} -> ";

                // Traverse
                current = current.Next;
            }

            return result + "NULL";
        }
    }
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Next = null;


        }

        public int Value { get; set; }
        public Node Next { get; set; }

    }


}
