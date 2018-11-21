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

        public double GetWeight(int destinationNode)
        {
            return _distance[destinationNode];
        }
    }
}
