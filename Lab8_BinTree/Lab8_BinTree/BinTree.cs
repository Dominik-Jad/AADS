using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinTree
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() +",";
                inOrder(tree.Right, ref buffer);
            }
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preOrder(tree.Left, ref buffer);             
                preOrder(tree.Right, ref buffer);
            }
        }
        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }
        private void insertItem(T item , ref Node<T>  tree)
        {
            if ( tree == null )
            tree = new Node<T>(item);

            else if ( item.CompareTo( tree.Data )< 0 )
            insertItem( item,  ref tree.Left );

            else if ( item.CompareTo( tree.Data ) >0 ) 
            insertItem( item,  ref tree.Right );
        }

        public void InsertItem (T item)
        {      
            insertItem( item, ref root );  
        }
     
        public int Height()
        {
            return height(ref root);
        }
   

        private int height(ref Node<T> root)
        {
            if (root == null){
            return 0;
            }
            else if (root.Left == null && root.Right == null){
            return 0; 
            }
            else{
            return 1 + Math.Max(height(ref root.Left), height(ref root.Right));
            }
        }   
        public int Count()
	    
            //Return the number of nodes in the tree
        {
            return count(ref root);
        }
      
        private int count(ref Node<T> root)
        {
            if (root == null){
            return 0;
            }  
            else
            {
            return (count(ref root.Left) + 1 + count(ref root.Right));
            }
        }
        


     	 public Boolean Contains(T item)
	  //Return true if the item is contained in the BSTree, false 	  //otherwise.
         {
             return contains(ref root, item);  
         }
         private Boolean contains(ref Node<T> root , T item)
         {
            if  (root == null){
            return false;
            }
            if (item.Equals(root.Data)){
            return true;
            }
            else if (item.CompareTo(root.Data) < 0)
            {
            return contains(ref root.Left, item);
            }else {
            return contains(ref root.Right, item);
            }
       }                                           
    
      public void RemoveItem(T item) //covered in lecture 16
      { 
         removeItem(item, ref root);
	  }

      private void removeItem(T item,ref Node<T>  root) //covered in lecture 16
      { 
            if(root == null){
            Console.WriteLine("No item in tree");
            }else {
             if(item.CompareTo(root.Data)< 0){
            removeItem(item, ref root.Left);
            }  
            if(item.CompareTo(root.Data)> 0){
            removeItem(item, ref root.Right);
            
            } if(item.Equals(root.Data)){
                if(root.Left == null && root.Right == null){
                    root = null;
                    Console.WriteLine("item deleted");
                }
                else if(root.Left == null){
                    root = root.Right;
                    Console.WriteLine("item deleted");
                }
                else if(root.Right == null){
                    root = root.Left;
                    Console.WriteLine("item deleted");
                }else {
                    T newRoot = leastItem(root.Right);
                    root.Data = newRoot;
                    removeItem( newRoot, ref root.Right );
                }
            }
        }
	  }
      public T leastItem (Node<T> newRoot){
          if(newRoot.Left == null){
            return newRoot.Data;
          }else{
            return leastItem(newRoot.Left);
          }
      }     
        
    }

}
