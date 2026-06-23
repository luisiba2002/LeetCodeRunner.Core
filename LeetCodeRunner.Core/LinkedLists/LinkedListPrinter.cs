namespace LeetCodeRunner.Core.LinkedLists
{
    public static class LinkedListPrinter
    {
        public static void Print(ListNode? head)
        {
            Console.WriteLine(ToDisplayString(head));
        }

        public static string ToDisplayString(ListNode? head)
        {
            if (head == null)
                return "(empty)";

            var values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            return string.Join(" -> ", values);
        }

    }
}