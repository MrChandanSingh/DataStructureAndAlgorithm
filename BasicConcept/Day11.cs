using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcept
{
    public class Day11
    {
        public List<int> GetReassignedPriority(List<int> prioritiest)
        {
            int[] counts = new int[100];

            foreach(var priority in prioritiest)
                counts[priority]++;

            int reducedPriority = 1;
            for(int i = 0; i < counts.Length; i++)
            {
                if(counts[i]>0)
                {
                    counts[i] = reducedPriority++;
                }
            }

            for(int i = 0; i < prioritiest.Count; i++)
            {
                prioritiest[i] = counts[prioritiest[i]];
            }
            return prioritiest;
        }

        public List<int> rotateLeft(int d, List<int> arr)
        {
            //int temp =0;
            List<int> num = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i + d < arr.Count)
                {
                    int wm = i + d;
                    num.Add(arr[wm]);
                }
            }

            for (int i = 0; i < d; i++)
            {
                num.Add(arr[i]); ;
            }

            return num;
        }


        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();
            var count= strings.GroupBy(x=>x).ToDictionary(x => x.Key, x => x.ToList().Count);
            foreach(string s in queries)
            {
                if(count.ContainsKey(s))
                    result.Add(count[s]);
                else
                    result.Add(0);
            }

            return result;
        }

        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
                return null;
            List<int> result = new List<int>();
            int alice=0, bob=0;
            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                    continue;
                if(a[i] > b[i])
                    alice++;
                if(a[i] < b[i])
                    bob++;
            }
            result.Add(alice);
            result.Add(bob);
            return result;
        }

        public string PostFixToInfix(string str)
        {
            if(str == null)
                return null;
            Stack<string> stack = new Stack<string>();
            
            foreach(char s in str)
            {
                if((s>='a' && s<='z')|| (s>='A' && s<='Z'))
                {
                    stack.Push(s.ToString());
                }
                else
                {
                   var first = stack.Peek();
                    stack.Pop();
                    var second = stack.Peek();
                    stack.Pop();
                    var temp = "("+second+s+first+")";
                    stack.Push(temp);
                }
            }
            Console.WriteLine(stack.Peek().ToString());
            return stack.Peek().ToString();
        }

        public bool Anagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            var charArr1 = str1.ToCharArray();
            var charArr2 = str2.ToCharArray();
            Array.Sort(charArr1);
            Array.Sort(charArr2);
            if (charArr2.ToString() == charArr1.ToString())
                return true;
            return false;
        }

        public void Permutation()
        {
            int[] num = new int[] {1,2,3};
            List<List<int>> ans = new List<List<int>>();
            var ds = new List<int>();
            bool[] freq = new bool[num.Length];
            recurPermutation(num,ds,ans, freq);
            foreach(var item in ans)
            {
                foreach(var item2 in item)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine(",");
            }
        }

        private void recurPermutation(int[] num, List<int> ds, List<List<int>> ans, bool[] freq)
        {
            if(ds.Count == num.Length)
            {
                ans.Add(ds);
                return;
            }

            for(int i = 0; i < num.Length; i++)
            {
                if(!freq[i])
                {
                    freq[i] = true;
                    ds.Add(num[i]);
                    recurPermutation(num, ds, ans, freq);
                    ds.Remove(ds.Count-1);
                    freq[i] = false;
                }
            }
        }

        public void ReverseLinkedList()
        {
            Node node = new Node(2);
            node.Next = new Node(1);
            node.Next.Next = new Node(2);

            Node prev = null, next = null, current = node;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            if (prev == node)
                Console.WriteLine(true);
            
        }

        public void TreeTraversal()
        {
            TreeNode treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.left.left = new TreeNode(4);
            treeNode.left.right = new TreeNode(5);
            treeNode.right = new TreeNode(3);
            treeNode.right.right = new TreeNode(7);
            treeNode.right.right.left = new TreeNode(6);

            PostOrderTraversal(treeNode);
            PreOrderTraversal(treeNode);
            InOrderTraversal(treeNode);

        }

        private void InOrderTraversal(TreeNode treeNode)
        {
            if(treeNode !=null)
            {
                InOrderTraversal(treeNode.left);
                Console.WriteLine(treeNode.key);
                InOrderTraversal(treeNode.right);
            }
        }

        private void PreOrderTraversal(TreeNode treeNode)
        {
            if(treeNode != null)
            {
                Console.WriteLine(treeNode.key);
                PreOrderTraversal(treeNode.left);
                PreOrderTraversal(treeNode.right);
            }
        }

        private void PostOrderTraversal(TreeNode treeNode)
        {
            if(treeNode != null)
            {
                //Console.WriteLine(treeNode.left.key);
                PostOrderTraversal(treeNode.left);
                //Console.WriteLine(treeNode.right.key);
                PostOrderTraversal(treeNode.right);
                Console.WriteLine(treeNode.key);
            }
        }
    }

    class TreeNode
    {
        public int key;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
