using System;
using System.Collections.Generic;
using System.Linq;

namespace Step7Project
{
    internal class Program
    {
        public static class QuestionClass
        {
            static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };


            static void Main(string[] args)
            {
                Iterator(NamesList);
            }

            private static void Iterator(List<string> list)
            {
                if (list.Count() == 0)
                    return;

                Console.WriteLine(list.FirstOrDefault());
                int first = 0;
                list.RemoveAt(first);
                Iterator(list);
            }
        }
    }
}
