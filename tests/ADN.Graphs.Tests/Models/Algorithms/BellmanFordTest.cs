using System;
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
    }
}
