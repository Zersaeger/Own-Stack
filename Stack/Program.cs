class Program
{
    public static void Main(string[] args)
    {
        
        Stack.StackL firstStack = new(100000);
        for(int i = 0; i < 50; i++)
        {
            firstStack.Push(i);
        }
        firstStack.Clear();
        firstStack.Push(10);
        int length = firstStack.Length();
        Console.WriteLine(length);
    }
}
