namespace DoubleList;

public class DoublyLinkedList<T>
{
    private DoubleNode<T>? head;
    private DoubleNode<T>? tail;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
    }

    public void Add(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public string GetForward()
    {
        var output = string.Empty;
        var current = head;        
        while (current != null)
        {
            output += $"{current.Data} <=> ";
            current = current.Next;
        }
        return output.Substring(0, output.Length - 5);
    }

    public string GetBackward()
    {
        var output = string.Empty;
        var current = tail;        
        while (current != null)
        {
            output += $"{current.Data} <=> ";
            current = current.Prev;
        }
        return output.Substring(0, output.Length - 5);
    }


}
