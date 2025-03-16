using System;

public class Node
{

    public Node(string element)
    {
        Element = element;
        Next = null;
    }

    public string Element { get; set; }

    public Node Next { get; set; }

    public override string ToString()
    {
        return "{" + Element + "}";
    }

}

public class MyList
{

    private Node Head { get; set; }

    public MyList()
    {
        Head = null;
    }

    public void AddHead(string el)
    {
        Node n = new Node(el);
        n.Next = Head;
        Head = n;
    }

    public void AddTail(string el)
    {
        Node n = new Node(el);

        //se la lista è vuota
        if (Head == null)
        {
            Head = n;
            return;
        }

        //se la lista non è vuota
        //trovo l'ultimo elementi
        Node i = Head;
        while (i.Next != null)
        {
            i = i.Next;
        }
        //i punta all'ultimo elemento
        i.Next = n;

    }

    public void AddPos(string el, int index)
    {
        if (index == 0)
        {
            AddHead(el);
            return;
        }
        if (Head == null && index != 0)
        {
            throw new Exception("index is not valid");
        }
        Node n = new Node(el);
        Node j = Head;
        int i = 0;
        for (i = 0; i < index - 1 && j.Next != null; i++)
        {
            j = j.Next;
        }
        if (i < (index - 1))
        {
            throw new Exception("index is not valid");
        }

        Node temp = j.Next;
        j.Next = n;
        n.Next = temp;

    }

    //metodi da fare come esercizio

    public string RemoveHead()
    {
        if (Head == null)
            return "Head does not exist";

        Head = Head.Next; //punta alla ref successiva
        return $"New Head is {Head.ToString()}";
    }

    public string RemoveTail()
    {
        //trovo il penultimo degli elementi
        Node i = Head;
        while (i.Next.Next != null)
        {
            i = i.Next; //scorro fino al penultimo elemento
        }
        i.Next = null; //concettualmente l'ultimo nodo non ha più valore
        return $"New Tail is {i.ToString()}";
    }

    public string RemovePos(int index)
    {
        return "da fare a casa";
    }

    public int IndexOf(string el)
    {
        return 0; //da fare
    }

    public string getHead()
    {
        return "da fare";
    }

    public string getTail()
    {
        return "da fare";
    }

    public string getElement(int index)
    {
        return "da fare";
    }

    public int Count()
    {
        return 0;//da fare
    }

    public void sort()
    {
        //da fare
    }



    public override string ToString()
    {
        string s = "[";

        Node i = Head;
        while (i != null)
        {
            s = s + " " + i.ToString() + " ";
            i = i.Next;
        }

        s = s + "]";

        return s;
    }

}

public class Program
{

    public static void Main(string[] args)
    {
        MyList l = new MyList();
        l.AddTail("Aronne");
        l.AddTail("tomas");
        l.AddTail("Domenico");
        l.AddTail("Duna");
        l.AddTail("Angelo");
        l.AddTail("Samuele");
        l.AddTail("Gaffuri");
        Console.WriteLine(l.ToString());

        //l.AddPos("Patelli", 1);
        Console.WriteLine( l.RemoveHead());

        Console.WriteLine(l.ToString());

        Console.WriteLine(l.RemoveTail());

        Console.WriteLine(l.ToString());


        l = new MyList();
        


    }
}