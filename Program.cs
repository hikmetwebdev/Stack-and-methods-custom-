
using Stack_and_queue;

MyStack<string> test =new MyStack<string>();

test.Push("s");
test.Push("d");
test.Push("g");
test.Push("f");
Console.WriteLine("\n");
Console.WriteLine("Before methods : \n");
foreach (var item in test)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Popped element: {test.Pop()} \n");

Console.WriteLine("List of the elements :");
foreach (var item in test)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Peeked element: {test.Peek()} \n");

Console.WriteLine($"Capacity of list : {test.Capacity}");
Console.WriteLine($"Count of elements: {test.Count}");
