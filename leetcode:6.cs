using System;
using System.Numerics;

public class Solution
{
    public static void Main()
    {
        InsertGreatestCommonDivisors(new ListNode(18, new ListNode(6, new ListNode(10, new ListNode(3)))));
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        ListNode currentListNode = head;
        while (currentListNode.next != null) 
        {
            BigInteger bigInteger = BigInteger.GreatestCommonDivisor(currentListNode.val, currentListNode.next.val);
            currentListNode.next = new ListNode((int)bigInteger, currentListNode.next);
            currentListNode = currentListNode.next.next;
        }

        return head;
    }
}
