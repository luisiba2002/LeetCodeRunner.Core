namespace LeetCodeRunner.Core.LinkedLists
{
    public static class LinkedListBuilder
    {
        public static ListNode BuildList(params int[] values)
        {
            ListNode dummy = new(0);
            ListNode current = dummy;

            foreach (var v in values)
            {
                current.next = new ListNode(v);
                current = current.next;
            }
            if (dummy.next == null)
            {
                return new ListNode();
            }
            return dummy.next;
        }

        /// <summary>
        /// Generador de un nuevo objeto ListNode que es una copia del objeto ListNode original.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode? Clone(ListNode? head)
        {
            if (head == null)
                return null;

            var clonedHead = new ListNode(head.val);

            var source = head.next;
            var currentClone = clonedHead;

            while (source != null)
            {
                currentClone.next = new ListNode(source.val);

                currentClone = currentClone.next;
                source = source.next;
            }

            return clonedHead;
        }
    }
}
