using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ADN.Graphs.Tests
{
    public class DijkstraTest
    {
        [Theory]
        [ClassData(typeof(DijkstraData))]
        public void Compute(double[,] graph, int sourceNode, int destinationNode, int[] expected)
        {
            var result = Dijkstra.Compute(graph, sourceNode, destinationNode);
            Assert.Equal(expected, result);
        }

        public class DijkstraData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                var graph = new double[,]
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

                yield return new object[] { graph, 0, 9, new int[] { 0, 8, 5, 4, 11, 1, 9 } };
                yield return new object[] { graph, 0, 2, new int[] { 0, 8, 2 } };
                yield return new object[] { graph, 0, 10, new int[] { } };
                yield return new object[] { graph, 0, 11, new int[] { 0, 8, 5, 4, 11 } };
                yield return new object[] { graph, 0, 1, new int[] { 0, 8, 5, 4, 11, 1 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
