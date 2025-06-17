namespace LeetCode206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var nodes = new ListNode([1, 2, 3, 4, 5]);

            PrintNodes(nodes);

            solution.ReverseList(nodes);
            PrintNodes(nodes);

            nodes = new ListNode([5, 4, 3, 2, 1]);
            PrintNodes(nodes);


            static void PrintNodes(ListNode head)
            {
                while (head != null)
                {
                    Console.WriteLine(head.val);
                    head = head.next;
                }
                Console.WriteLine();
            }
        }
    }
}
