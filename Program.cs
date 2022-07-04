Console.WriteLine("Finding a value in a binary tree");

Node exampleTree = new(1, new(2, new(4), new(6)), new(3));

if (Solution.FindValueBFS(exampleTree, 1) == true)
    Console.WriteLine("Oook");
else
    Console.WriteLine("nooo ok");

if (Solution.FindValueBFS(exampleTree, 3) == true)
    Console.WriteLine("Oook");
else
    Console.WriteLine("nooo ok");

if (Solution.FindValueBFS(exampleTree, 4) == true)
    Console.WriteLine("Oook");
else
    Console.WriteLine("nooo ok");

if (!Solution.FindValueBFS(exampleTree, 8) == true)
    Console.WriteLine("Oook");
else
    Console.WriteLine("nooo ok");

if (!Solution.FindValueBFS(exampleTree, 7) == true)
    Console.WriteLine("Oook");
else
    Console.WriteLine("nooo ok");

public class Node
{
    public Node(int value, Node? left = null, Node? right = null)
    {
        this.value = value;
        Left = left;
        Right = right;
    }

    public int value { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }
}

public static class Solution
{
    public static bool FindValueDFS(Node? node, int targetValue)
    {
        if (node is null)
            return false;

        if (node.value == targetValue)
            return true;

        return FindValueDFS(node.Left, targetValue) || FindValueDFS(node.Right, targetValue);
    }
    public static bool FindValueBFS(Node? node, int targetValue)
    {
        var queue = new Queue<Node?>();
        queue.Enqueue(node);
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            if (currentNode is null)
                continue;

            if (currentNode.value == targetValue)
                return true;

            queue.Enqueue(currentNode.Left);
            queue.Enqueue(currentNode.Right);
        }
        return false;
    }
}
