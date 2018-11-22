using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Graphs
{
    public class Graph
    {
        public struct Edge
        {
            public int Source;
            public int Destination;
            public double Weight;
        }

        private List<Edge>[] _adjacencyEdges;
        private double[,] _matrix;
        private bool _directed;

        public Graph(int verticesCount, bool directed = false)
        {
            EdgesCount = 0;
            _adjacencyEdges = new List<Edge>[verticesCount];
            _matrix = new double[verticesCount, verticesCount];
            _directed = directed;

            for (int i = 0; i < verticesCount; i++)
            {
                _adjacencyEdges[i] = new List<Edge>();

                for (int j = 0; j < verticesCount; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }

        public int VerticesCount
        {
            get { return _matrix.GetLength(0); }
        }

        public int EdgesCount { get; private set; }

        public void AddEdge(Edge edge)
        {
            EdgesCount++;
            _adjacencyEdges[edge.Source].Add(edge);
            _matrix[edge.Source, edge.Destination] = edge.Weight;

            if (!_directed)
            {
                _adjacencyEdges[edge.Destination].Add(
                    new Edge() {
                        Source = edge.Destination,
                        Destination = edge.Source,
                        Weight = edge.Weight
                });
                _matrix[edge.Destination, edge.Source] = edge.Weight;
            }
        }

        public double[,] GetMatrix()
        {
            return _matrix;
        }

        public Edge[] Adjacency(int edge)
        {
            return _adjacencyEdges[edge].ToArray();
        }
    }
}
