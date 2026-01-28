/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        Node newHead = null;

        var mainDict1 = new Dictionary<Node, int>();
        var mainDict2 = new Dictionary<int, Node>();
        var newDict = new Dictionary<int, Node>();

        var node = head;
        Node prevNode = null;
        int idx = 0;


        while (node is not null)
        {
            var newItem = new Node(node.val);

            if (prevNode is null)
            {
                prevNode = newItem;
                newHead = prevNode;
            }
            else
            {
                prevNode.next = newItem;
                prevNode = newItem;
            }

            mainDict1.Add(node, idx);
            mainDict2.Add(idx, node.random);

            newDict.Add(idx, newItem);

            node = node.next;
            idx++;
        }

        foreach (var item in newDict)
        {
            var random = mainDict2[item.Key];
            if (random is not null)
            {
                var newIndex = mainDict1[random];
                item.Value.random = newDict[newIndex];
            }
        }

        return newHead;        
    }
}