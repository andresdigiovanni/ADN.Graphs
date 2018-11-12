using System;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Graphs
{
    /// <summary>
    /// A static class that implements Dijkstra algorithm.
    /// </summary>
    public static class Dijkstra
    {
        /// <summary>
        /// Get the minimum path using Dijkstra algorithm.
        /// </summary>
        /// <param name="graph">Graph to calculate the minimum path.</param>
        /// <param name="sourceNode">Source graph node.</param>
        /// <param name="destinationNode">Destination graph node.</param>
        /// <returns>Minimum path.</returns>
        public static int[] Compute(Graph graph, int sourceNode, int destinationNode)
        {
            return Compute(graph.GetMatrix(), sourceNode, destinationNode);
        }

        /// <summary>
        /// Get the minimum path using Dijkstra algorithm.
        /// </summary>
        /// <param name="graph">Graph to calculate the minimum path.</param>
        /// <param name="sourceNode">Source graph node.</param>
        /// <param name="destinationNode">Destination graph node.</param>
        /// <returns>Minimum path.</returns>
        public static int[] Compute(double[,] graph, int sourceNode, int destinationNode)
        {
            var length = graph.GetLength(0);
            var distance = new double[length];

            for (int i = 0; i < length; i++)
            {
                distance[i] = double.MaxValue;
            }

            distance[sourceNode] = 0;

            var used = new bool[length];
            var previous = new int?[length];

            while (true)
            {
                var minDistance = double.MaxValue;
                var minNode = 0;
                for (int i = 0; i < length; i++)
                {
                    if (!used[i] && minDistance > distance[i])
                    {
                        minDistance = distance[i];
                        minNode = i;
                    }
                }

                if (minDistance == double.MaxValue)
                {
                    break;
                }

                used[minNode] = true;

                for (int i = 0; i < length; i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        var shortestToMinNode = distance[minNode];
                        var distanceToNextNode = graph[minNode, i];

                        var totalDistance = shortestToMinNode + distanceToNextNode;

                        if (totalDistance < distance[i])
                        {
                            distance[i] = totalDistance;
                            previous[i] = minNode;
                        }
                    }
                }
            }

            if (distance[destinationNode] == double.MaxValue)
            {
                return new int[0];
            }

            var path = new LinkedList<int>();
            int? currentNode = destinationNode;
            while (currentNode != null)
            {
                path.AddFirst(currentNode.Value);
                currentNode = previous[currentNode.Value];
            }

            return path.ToArray();
        }
    }
}
