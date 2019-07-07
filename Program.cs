using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars.Programs;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncodeProgram.DuplicateEncode("(( @"));
        }

        public static int getLoopSize(LoopDetector.Node startNode){
            HashSet<LoopDetector.Node> allNodes =  new HashSet<LoopDetector.Node>();
            allNodes.Add(startNode);

            startNode = startNode.next;
            var temp = 0;
            var count = 0;
            while(true)
            {
                if(allNodes.Contains(startNode))
                {
                    temp = allNodes.FirstOrDefault(x => x.Equals(startNode))
                    return allNodes.Count - temp;
                }

                allNodes.Add(startNode);
                startNode = startNode.next;
            }
        }
    }
}
