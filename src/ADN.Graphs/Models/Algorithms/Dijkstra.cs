using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Graphs
{
    /// <summary>
    /// A static class that implements Dijkstra algorithm.
    /// </summary>
    public class Dijkstra : ShortestPath
    {
        /// <summary>
        /// Get the minimum path using Dijkstra algorithm.
        /// </summary>
        /// <param name="graph">Graph to calculate the minimum path.</param>
        /// <param name="sourceNode">Source graph node.</param>
        /// <param name="destinationNode">Destination graph node.</param>
        /// <returns>Minimum path.</returns>
        public Dijkstra(Graph graph, int sourceNode)
        {
            double[,] matrix = graph.GetMatrix();
            var verticesCount = matrix.GetLength(0);
            var used = new bool[verticesCount];

            InitializeDistances(graph, sourceNode);

            while (true)
            {
                var minDistance = double.MaxValue;
                var minNode = 0;
                for (int i = 0; i < verticesCount; i++)
                {
                    if (!used[i] && minDistance > _distance[i])
                    {
                        minDistance = _distance[i];
                        minNode = i;
                    }
                }

                if (minDistance == double.MaxValue)
                {
                    break;
                }

                used[minNode] = true;

                for (int i = 0; i < verticesCount; i++)
                {
                    if (matrix[minNode, i] > 0)
                    {
                        var shortestToMinNode = _distance[minNode];
                        var distanceToNextNode = matrix[minNode, i];
                        var totalDistance = shortestToMinNode + distanceToNextNode;

                        if (totalDistance < _distance[i])
                        {
                            _distance[i] = totalDistance;
                            _previous[i] = minNode;
                        }
                    }
                }
            }
        }
    }
}
