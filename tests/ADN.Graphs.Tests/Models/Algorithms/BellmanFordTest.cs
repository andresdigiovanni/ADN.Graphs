﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ADN.Graphs.Tests
{
    public class BellmanFordTest
    {
        [Theory]
        [ClassData(typeof(ShortestPathData))]
        public void GetShortestPath(Graph graph, int sourceNode, int destinationNode, int[] expected)
        {
            ShortestPath bellmanFord = new BellmanFord(graph, sourceNode);
            var result = bellmanFord.GetShortestPath(destinationNode);
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(WeightData))]
        public void GetWeight(Graph graph, int sourceNode, int destinationNode, double expected)
        {
            ShortestPath bellmanFord = new BellmanFord(graph, sourceNode);
            var result = bellmanFord.GetWeight(destinationNode);
            Assert.Equal(expected, result);
        }

        public class ShortestPathData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                var graph = GetGraph();

                yield return new object[] { graph, 0, 9, new int[] { 0, 8, 5, 4, 11, 1, 9 } };
                yield return new object[] { graph, 0, 2, new int[] { 0, 8, 2 } };
                yield return new object[] { graph, 0, 10, new int[] { } };
                yield return new object[] { graph, 0, 11, new int[] { 0, 8, 5, 4, 11 } };
                yield return new object[] { graph, 0, 1, new int[] { 0, 8, 5, 4, 11, 1 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class WeightData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                var graph = GetGraph();

                yield return new object[] { graph, 0, 9, 42 };
                yield return new object[] { graph, 0, 2, 26 };
                yield return new object[] { graph, 0, 10, double.MaxValue };
                yield return new object[] { graph, 0, 11, 31 };
                yield return new object[] { graph, 0, 1, 37 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private static Graph GetGraph()
        {
            var matrix = GetMatrix();
            int verticesCount = matrix.GetLength(0);
            Graph graph = new Graph(verticesCount);

            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = i + 1; j < verticesCount; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        graph.AddEdge(new Graph.Edge
                        {
                            Source = i,
                            Destination = j,
                            Weight = matrix[i, j]
                        });
                    }
                }
            }

            return graph;
        }

        private static double[,] GetMatrix()
        {
            return new double[,]
            {
                // 0   1   2   3   4   5   6   7   8   9  10  11
                { 0,  0,  0,  0,  0,  0, 10,  0, 12,  0,  0,  0 }, // 0
                { 0,  0,  0,  0, 20,  0,  0, 26,  0,  5,  0,  6 }, // 1
                { 0,  0,  0,  0,  0,  0,  0, 15, 14,  0,  0,  9 }, // 2
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  7,  0 }, // 3
                { 0, 20,  0,  0,  0,  5, 17,  0,  0,  0,  0, 11 }, // 4
                { 0,  0,  0,  0,  5,  0,  6,  0,  3,  0,  0, 33 }, // 5
                {10,  0,  0,  0, 17,  6,  0,  0,  0,  0,  0,  0 }, // 6
                { 0, 26, 15,  0,  0,  0,  0,  0,  0,  3,  0, 20 }, // 7
                {12,  0, 14,  0,  0,  3,  0,  0,  0,  0,  0,  0 }, // 8
                { 0,  5,  0,  0,  0,  0,  0,  3,  0,  0,  0,  0 }, // 9
                { 0,  0,  0,  7,  0,  0,  0,  0,  0,  0,  0,  0 }, // 10
                { 0,  6,  9,  0, 11, 33,  0, 20,  0,  0,  0,  0 }, // 11
            };
        }
    }
}