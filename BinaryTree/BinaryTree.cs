using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        public Node RootNode;

        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = RootNode;
                while (true)
                {
                    if(nodeToAdd.data < focusNode.data)
                    {
                        if (focusNode.leftNode == null)
                        {
                            focusNode.leftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }
                    else
                    {
                        if(focusNode.rightNode == null)
                        {
                            focusNode.rightNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.rightNode;
                        }
                    }
                }
                
            }
        }
        public void Search (int value)
        {
            Node focusNode = RootNode;
            while (true)
            {
                if (value == focusNode.data)
                {
                    Console.WriteLine("Item found in Tree");
                }
                else if (value > focusNode.data)
                {
                    if (focusNode.rightNode == null)
                    {
                        
                    }

                }
            }
        }
    }
}
