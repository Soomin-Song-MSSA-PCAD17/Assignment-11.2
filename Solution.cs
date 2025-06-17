/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) { return null; }
        Stack<int> nodeValues = new Stack<int>();
        ListNode ptr = head;
        // iterate through listnode and push into stack
        while (ptr != null)
        {
            nodeValues.Push(ptr.val);
            ptr = ptr.next;
        }

        // iterate through listnode second time and pop from stack
        ptr = head;
        while (ptr != null)
        {
            ptr.val = nodeValues.Pop();
            ptr = ptr.next;
        }

        return head;
    }
}


// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public ListNode(int[] valueArray)
    {
        if (valueArray == null) { return; }
        val = valueArray[0];

        ListNode ptr = this;
        for (int i = 0; i < valueArray.Length-1; i++)
        {
            ptr.next = new ListNode(valueArray[i+1]);
            ptr= ptr.next;
        }
        ptr.next = null;
    }
}
