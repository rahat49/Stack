class Program
{
  const int CAPACITY = 4;
    int[] stack = new int[CAPACITY];
    int top = -1;

    void push(int x)
    {
        if(top< CAPACITY-1)
        {
            top= top+1;
            stack[top] = x;
            Console.WriteLine($"Successfully added item: {x}");
        }
        else
        {
            Console.WriteLine("Exception! No Space");
        }
    }

    int pop()
    {
        if (top >= 0)
        {
            int val= stack[top];
            top= top-1;
            return val;
        }
        Console.WriteLine("Exception! Stack is Empty.");
        return -1;
    }

    int peek()
    {
        if( top >= 0 )
        {
            return stack[top];
        }
        Console.WriteLine("Exception! Stack is Empty.");
        return -1;
    }

    static void Main()
    {
        Console.WriteLine("IMPLEMENTING MY STACK IN C#.");

        Program stack= new Program();

        stack.peek();
        stack.push(10);
        stack.push(20);
        stack.push(30);
        stack.push(40);
        Console.WriteLine($"Peek Value:{stack.pop()}");
        stack.push(50);
        Console.WriteLine($"Peek Value: {stack.peek()}");

    }
}
