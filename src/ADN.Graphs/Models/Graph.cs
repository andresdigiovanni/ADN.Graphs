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

        public Graph(int verticesCount)
        {
            _edges = new List<Edge>();
            _matrix = new double[verticesCount, verticesCount];

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
            _matrix[edge.Source, edge.Destination] = edge.Weight;
            _matrix[edge.Destination, edge.Source] = edge.Weight;
        }

        public double[,] GetMatrix()
        {
            return _matrix;
        }
    }
}
