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
        [ClassData(typeof(ShortestPathData))]
        public void GetShortestPath(Graph graph, int sourceNode, int destinationNode, int[] expected)
        {
            ShortestPath dijkstra = new Dijkstra(graph, sourceNode);
            var result = dijkstra.GetShortestPath(destinationNode);
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(WeightData))]
        public void GetWeight(Graph graph, int sourceNode, int destinationNode, double expected)
        {
            ShortestPath dijkstra = new Dijkstra(graph, sourceNode);
            var result = dijkstra.GetWeight(destinationNode);
            Assert.Equal(expected, result);
        }
    }
}
