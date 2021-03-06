﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Root;
        public void AddNodeToTree(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            if (value.CompareTo(Root.Value) < 0)
            {
                if (Root.Left == null)
                {
                    Root.Left = newNode;
                }
                else
                {
                    AddNodeToTree(Root.Left.Value);
                }
            }
            else
            {
                if (Root.Right == null)
                {
                    Root.Right = newNode;
                }
                else
                {
                    AddNodeToTree(Root.Right.Value);
                }
            }
        }

        public bool Contain(T value)
        {

            if (value.CompareTo(Root.Value) == 0)
            {
                return true;
            }

            else if (value.CompareTo(Root.Value) < 0)
            {
                Root = Root.Left;
                Contain(Root.Value);
            }
            else
            {
                Root = Root.Right;
                Contain(Root.Value);
            }




            return false;

        }


    }   
    


    public class Node<T>
    { 
        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }


    }
}

