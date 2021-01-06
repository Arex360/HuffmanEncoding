using System;
using System.Collections;

namespace HuffmanEncodiong
{
  class HuffmanTreeList
  {
    private class ListNode
    {
      public HuffmanTree Tree;
      public ListNode Next;

      public ListNode(HuffmanTree tree)
      {
        Tree = tree;
      }
    }

    private ListNode First;

    public void Add(HuffmanTree tree)
    {
      ListNode newNode = new ListNode(tree);

      if (First == null)
      {
        First = newNode;
      }
      else if (tree.Frequency < First.Tree.Frequency)
      {
        newNode.Next = First;
        First = newNode;
      }
      else
      {
        ListNode curNode;

        for (curNode = First; curNode.Next != null; curNode = curNode.Next)
        {
          if (tree.Frequency < curNode.Next.Tree.Frequency)
          {
            newNode.Next = curNode.Next;
            curNode.Next = newNode;
            break;
          }
        }
        if (newNode.Next == null)
        {

          curNode.Next = newNode;
        }
      }
    }

    public HuffmanTree RemoveTopTree()
    {
      if (First == null)
      {
        return null;
      }

      HuffmanTree top = First.Tree;
      First = First.Next;
      return top;
    }

    public bool HasExactlyOneTree()
    {
      return First != null && First.Next == null;
    }
  }
}