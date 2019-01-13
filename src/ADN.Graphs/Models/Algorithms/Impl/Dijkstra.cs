using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Graphs
{
    /// <summary>
    /// A class that implements Dijkstra algorithm.
    /// </summary>
    public class Dijkstra : ShortestPath, IShortestPathAlgorithm
    {
        /// <summary>
        /// Dijkstra algorithm to get the minimum path.
        /// </summary>
        /// <param name="graph">Graph to calculate the minimum path.</param>
        /// <param name="sourceNode">Source graph node.</param>
        /// <example>
        /// <code lang="csharp">
        /// var graph = new double[,]
        /// {
        /// //    0   1   2   3
        ///     { 0,  3,  0,  0 }, // 0
        ///     { 0,  0,  5,  0 }, // 1
        ///     { 0,  0,  0,  9 }, // 2
        ///     { 0,  0,  0,  0 }, // 3
        /// };
        /// var sourceNode = 0;
        /// var dijkstra = new Dijkstra(graph, sourceNode);
        /// </code>
        /// </example>
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
