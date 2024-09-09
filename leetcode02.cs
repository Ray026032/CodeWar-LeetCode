using System;

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

public class Solution
{
    public static void Main()
    {
        // 建立範例鏈結串列
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8))))))));
        SpiralMatrix(3, 3, head);
    }

    public static int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        // m = 3 , n = 5
        // XXXXX
        // XXXXX
        // XXXXX

        // m = 1 , n = 4
        // XXXX

        // m = 4 , n = 6
        // XXXXXX
        // XXXXXX
        // XXXXXX
        // XXXXXX

        int[][] matrix = new int[m][];

        //全部陣列中加入-1
        for (int i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = -1;
            }
        }
        //現在ListNode位置
        ListNode current = head;

        // 列最上層邊界位置，從0開始
        var rowtop = 0;
        // 列最下層邊界位置，從0開始所以減一
        var rowbottom = m - 1;
        // 行最左層邊界位置，從0開始
        var colleft = 0;
        // 行最右層邊界位置，從0開始所以減一
        var colright = n - 1;

        while (current != null)
        {
            //從左至右
            for (int i = colleft; i <= colright && current != null; i++)
            {
                WriteValue(rowtop, i);
            }
            //跑完最上層，縮小上邊界
            rowtop++;

            //從上至下
            for (int i = rowtop; i <= rowbottom && current != null; i++)
            {
                WriteValue(i, colright);
            }
            //跑完最右層，縮小右邊界
            colright--;

            //從右至左
            for (int i = colright; colleft <= i && current != null; i--)
            {
                WriteValue(rowbottom, i);
            }
            //跑完最下層，縮小下邊界
            rowbottom--;

            //從下至上
            for (int i = rowbottom; rowtop <= i && current != null; i--)
            {
                WriteValue(i, colleft);
            }
            //跑完最左層，縮小左邊界
            colleft++;
        }

        return matrix;

        void WriteValue(int m, int n)
        {
            matrix[m][n] = current.val;
            current = current.next;
        }
    }
}
