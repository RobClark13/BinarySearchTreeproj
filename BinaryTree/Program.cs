using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();
            myTree.AddNode(new Node(13));
            myTree.AddNode(new Node(35));
            myTree.AddNode(new Node(44));
            myTree.AddNode(new Node(10));
            myTree.AddNode(new Node(6));
            myTree.AddNode(new Node(9));
            myTree.AddNode(new Node(56));
            myTree.AddNode(new Node(80));
            myTree.Print();
        }
    }
}
