using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sprint6.Taks1
{
    class CircleOfChildren
    {
        public List<string> Children;

        public CircleOfChildren(IEnumerable<string> _children)
        {
            Children = (List<string>)_children;
        }

        public void Print()
        {
            Console.WriteLine("----------------");
            foreach (var item in Children)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("----------------");
        }

        public IEnumerable GetChildrenInOrder(int syllablesCount = 0, int numberOfChildren = 0)
        {
            List<string> result = new List<string>();
            if (syllablesCount <= 0)
            {
                return new List<string>();
            }
            if (numberOfChildren >= Children.Count || numberOfChildren <= 0 )
            {
                int k = 0;
                while (Children.Count != 0)
                {  
                    for (int i = 0; i < Children.Count; i++)
                    {
                        if (k == syllablesCount)
                        {
                            if (i != 0) i--;
                            //Console.WriteLine(Children[i] + " ");
                            result.Add(Children[i]);
                            Children.Remove(Children[i]);
                            k = 0;
                        }
                        k++;
                        if (k == syllablesCount && i == Children.Count - 1)
                        {
                            //Console.WriteLine(Children[i] + " ");
                            result.Add(Children[i]);
                            Children.Remove(Children[i]);
                        }
                    }
                }
            }
            else
            {
                int k = 0, count = 0;
                while (Children.Count != 0 && count != numberOfChildren)
                {
                    for (int i = 0; i < Children.Count; i++)
                    {
                        if (count == numberOfChildren) break;
                        if (k == syllablesCount)
                        {
                            if (i != 0) i--;
                            //Console.WriteLine(Children[i] + " ");
                            result.Add(Children[i]);
                            Children.Remove(Children[i]);
                            k = 0; count++;
                        }
                        k++;
                        if (k == syllablesCount && i == Children.Count - 1)
                        {
                            //Console.WriteLine(Children[i] + " ");
                            result.Add(Children[i]);
                            Children.Remove(Children[i]);
                            count++;
                        }
                    }
                }
            }
            return result;
        }
    }

    class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren _children, int syllables = 0, int countOfChildren = 0)
        {
            IEnumerable result = _children.GetChildrenInOrder(syllables, countOfChildren);
            foreach (var child in result)
            {
                Console.Write(child + " ");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>()
            {
                "Halya1",
                "Olya2",
                "Ira3",
                "Andriy4",
                "Josh5"
            };
            CircleOfChildren children = new CircleOfChildren(list);
            OutputUtils.ExitOutput(children, 6, 100);
        }
    }
}
