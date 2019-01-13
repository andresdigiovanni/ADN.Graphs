using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Graphs
{
    public abstract class ShortestPath
    {
        protected double[] _distance;
        protected int?[] _previous;

        protected void InitializeDistances(Graph graph, int sourceNode)
        {
            int verticesCount = graph.VerticesCount;
            _distance = new double[verticesCount];
            _previous = new int?[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                _distance[i] = double.MaxValue;
                _previous[i] = null;
            }

            _distance[sourceNode] = 0;
        }

        /// <summary>
        /// Get the minimum path.
        /// </summary>
        /// <param name="destinationNode">Destination graph node.</param>
        /// <returns>Minimum path.</returns>
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
        /// var destinationNode = 3;
        /// var bellmanFord = new BellmanFord(graph, sourceNode);
        /// var result = bellmanFord.GetShortestPath(destinationNode);
        /// 
        /// /*
        /// result is { 0, 1, 2, 3 }
        /// */
        /// </code>
        /// </example>
        public int[] GetShortestPath(int destinationNode)
        {
            if (_distance[destinationNode] == double.MaxValue)
            {
                return new int[0];
            }

            var path = new LinkedList<int>();
            int? currentNode = destinationNode;
            while (currentNode != null)
            {
                path.AddFirst(currentNode.Value);
                currentNode = _previous[currentNode.Value];
            }

            return path.ToArray();
        }

        /// <summary>
        /// Get the minimum weight.
        /// </summary>
        /// <param name="destinationNode">Destination graph node.</param>
        /// <returns>Minimum weight.</returns>
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
        /// var destinationNode = 3;
        /// var bellmanFord = new BellmanFord(graph, sourceNode);
        /// var result = bellmanFord.GetWeight(destinationNode);
        /// 
        /// /*
        /// result is 17
        /// */
        /// </code>
        /// </example>
        public double GetWeight(int destinationNode)
        {
            return _distance[destinationNode];
        }
    }
}
