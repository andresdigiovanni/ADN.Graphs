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

        private List<Edge> _edges;
        private double[,] _matrix;
        private bool _directed;

        public Graph(int verticesCount, bool directed = false)
        {
            _edges = new List<Edge>();
            _matrix = new double[verticesCount, verticesCount];
            _directed = directed;

            for (int i = 0; i < verticesCount; i++)
            {
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

        public int EdgesCount
        {
            get { return Edges.Length; }
        }

        public Edge[] Edges
        {
            get { return _edges.ToArray(); }
        }

        public void AddEdge(Edge edge)
        {
            _edges.Add(edge);
            _matrix[edge.Source, edge.Destination] = edge.Weight;
            if (!_directed)
            {
                _matrix[edge.Destination, edge.Source] = edge.Weight;
            }
        }

        public double[,] GetMatrix()
        {
            return _matrix;
        }

        public Edge[] Adjacency(int edge)
        {
            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                if (_matrix[edge, i] != 0)
                {
                    edges.Add(new Edge
                    {
                        Source = edge,
                        Destination = i,
                        Weight = _matrix[edge, i]
                    });
                }
            }

            return edges.ToArray();
        }
    }
}
