using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Programs
{
    public static class NodeLoopSize
    {
        /// <summary>
        /// when given a starting node, finds the size of a loop of the node structure
        /// </summary>
        /// <param name="startNode"></param>
        /// <returns></returns>
        public static int getLoopSize(Node startNode){
            HashSet<Node> allNodes =  new HashSet<Node>();
            var indicedNodes = new Dictionary<int, Node>();

            allNodes.Add(startNode);
            indicedNodes.Add(0, startNode);

            startNode = startNode.next;
            var temp = 0;
            var count = 1;
            while(true)
            {
                if(allNodes.Contains(startNode))
                {
                    temp = indicedNodes.FirstOrDefault(x => x.Value.Equals(startNode)).Key;
                    return allNodes.Count - temp;
                }

                allNodes.Add(startNode);
                indicedNodes.Add(count, startNode);
                startNode = startNode.next;
                count++;
            }
        }

        
    }
    public class Node
    {
        public Node next { get; set; }
    }
}