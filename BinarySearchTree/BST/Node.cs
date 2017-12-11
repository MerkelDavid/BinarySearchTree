using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node
    {
        int value;

        Node leftChild;
        Node rightChild;

        public Node()
        {

        }
        public Node(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }
        
        public Node GetLeftChild()
        {
            return leftChild;
        }

        public Node GetRightChild()
        {
            return rightChild;
        }

        public void SetLeftChild(Node newChild)
        {
            leftChild = newChild;
        }
        public void SetRightChild(Node newChild)
        {
            rightChild = newChild;
        }
    }
}
