using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Graphs
{
    /// <summary>
    /// A class that represents a graph.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Represents an edge of the graph.
        /// </summary>
        public struct Edge
        {
            public int Source;
            public int Destination;
            public double Weight;
        }

        private List<Edge>[] _adjacencyEdges;
        private double[,] _matrix;
        private bool _directed;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="verticesCount">Number of vertices in the graph.</param>
        /// <param name="directed">True if is a direct graph, false otherwise.</param>
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

        /// <summary>
        /// Number of vertices in the graph.
        /// </summary>
        public int VerticesCount
        {
            get { return _matrix.GetLength(0); }
        }

        /// <summary>
        /// Number of edges in the graph.
        /// </summary>
        public int EdgesCount { get; private set; }

        /// <summary>
        /// Add an edge in the graph.
        /// </summary>
        /// <param name="edge">Edge to add.</param>
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

        /// <summary>
        /// Get a mtatrix that represents the graph.
        /// </summary>
        /// <returns>A mtatrix that represents the graph.</returns>
        public double[,] GetMatrix()
        {
            return _matrix;
        }

        /// <summary>
        /// Gets the edges that connects a given vertex to the adjancency vertices.
        /// </summary>
        /// <param name="vertex">Origen vertex.</param>
        /// <returns>Edges that connects with the adjancency vertices.</returns>
        public Edge[] Adjacency(int vertex)
        {
            return _adjacencyEdges[vertex].ToArray();
        }
    }
}
