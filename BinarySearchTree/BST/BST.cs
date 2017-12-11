using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BST
    {
        Node head = null;

        public BST()
        {

        }

        public BST(int value)
        {
            Add(value);
        }

        public void Add(int newNodeValue)
        {
            Node newNode = new Node(newNodeValue);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currentNode = head;

            while (currentNode.GetLeftChild() != null || currentNode.GetRightChild() != null) 
            {
                if (newNodeValue > currentNode.GetValue())
                {
                    if (currentNode.GetRightChild() != null)
                    {
                        currentNode = currentNode.GetRightChild();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (newNodeValue < currentNode.GetValue())
                {
                    if (currentNode.GetLeftChild() != null)
                    {
                        currentNode = currentNode.GetLeftChild();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The Node already exists");
                    return;
                }
            }

            if (newNodeValue > currentNode.GetValue())
            {
                currentNode.SetRightChild(newNode);
            }
            else
            {
                currentNode.SetLeftChild(newNode);
            }
        }

        public bool Search(int searchValue)
        {
            string searchPath = "Your value has been found! The path was ";
            if (head == null)
            {
                Console.WriteLine("Your value could not be found. There is no tree");
                return false;
            }
            if (head.GetValue() == searchValue)
            {
                Console.WriteLine("Your value has been found! It was the head");
                return true;
            }

            Node currentNode = head;

            while (currentNode.GetLeftChild() != null || currentNode.GetRightChild() != null)
            {
                if (searchValue > currentNode.GetValue())
                {
                    if (currentNode.GetRightChild() == null)
                    {
                        Console.WriteLine("The value could not be found");
                        return false;
                    }
                    searchPath += "right ";
                    currentNode = currentNode.GetRightChild();
                }
                else if (searchValue < currentNode.GetValue())
                {
                    if (currentNode.GetLeftChild() == null)
                    {
                        Console.WriteLine("The value could not be found");
                        return false;
                    }
                    searchPath += "left ";
                    currentNode = currentNode.GetLeftChild();
                }
                else
                {
                    Console.WriteLine(searchPath);
                    return true;
                }
            }
            Console.WriteLine("The value could not be found");
            return false;
        }
    }
}
