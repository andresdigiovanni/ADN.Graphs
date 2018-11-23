using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Graphs.Tests
{
    public class GraphTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        public void VerticesCount(int verticesCount)
        {
            Graph graph = new Graph(verticesCount);
            var result = graph.VerticesCount;
            Assert.Equal(verticesCount, result);
        }

        [Theory]
        [ClassData(typeof(EdgesData))]
        public void EdgesCount(List<Graph.Edge> edges, int numVertices, int expected)
        {
            Graph graph = new Graph(numVertices);
            foreach (Graph.Edge edge in edges)
            {
                graph.AddEdge(edge);
            }

            var result = graph.EdgesCount;
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(MatrixData))]
        public void GetMatrix(List<Graph.Edge> edges, int numVertices, double[,] expected)
        {
            Graph graph = new Graph(numVertices);
            foreach (Graph.Edge edge in edges)
            {
                graph.AddEdge(edge);
            }

            var result = graph.GetMatrix();
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(AdjacencyData))]
        public void Adjacency(List<Graph.Edge> edges, int numVertices, int source, Graph.Edge[] expected)
        {
            Graph graph = new Graph(numVertices);
            foreach (Graph.Edge edge in edges)
            {
                graph.AddEdge(edge);
            }

            var result = graph.Adjacency(source);
            Assert.Equal(expected, result);
        }

        public class EdgesData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                int numVertices = 10;
                int numEdges = 0;
                List<Graph.Edge> edges = new List<Graph.Edge>();

                for (int i = 0; i < numVertices; i++)
                {
                    numEdges++;
                    int source = i;
                    int destination = (i == 0) ? numVertices - 1 : i - 1;
                    int weight = i;

                    edges.Add(new Graph.Edge
                    {
                        Source = source,
                        Destination = destination,
                        Weight = weight
                    });
                }

                yield return new object[] { edges, numVertices, numEdges };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class MatrixData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                int numVertices = 10;
                List<Graph.Edge> edges = new List<Graph.Edge>();
                double[,] matrix = new double[numVertices, numVertices];

                for (int i = 0; i < numVertices; i++)
                {
                    for (int j = 0; j < numVertices; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }

                for (int i = 0; i < numVertices; i++)
                {
                    int source = i;
                    int destination = (i == 0) ? numVertices - 1 : i - 1;
                    int weight = i;

                    matrix[source, destination] = weight;
                    matrix[destination, source] = weight;

                    edges.Add(new Graph.Edge
                    {
                        Source = source,
                        Destination = destination,
                        Weight = weight
                    });
                }

                yield return new object[] { edges, numVertices, matrix };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class AdjacencyData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                int numVertices = 10;

                for (int i = 0; i < numVertices; i++)
                {
                    List<Graph.Edge> edges = new List<Graph.Edge>();
                    int source = i;
                    int destination = (i == 0) ? numVertices - 1 : i - 1;
                    int weight = i;

                    edges.Add(new Graph.Edge
                    {
                        Source = source,
                        Destination = destination,
                        Weight = weight
                    });

                    yield return new object[] { edges, numVertices, source, edges.ToArray() };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
