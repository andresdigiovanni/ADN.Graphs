using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Graphs.Tests
{
    public class ShortestPathData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var graph = GraphGenerator.GetGraph();

            yield return new object[] { graph, 0, 9, new int[] { 0, 8, 5, 4, 11, 1, 9 } };
            yield return new object[] { graph, 0, 2, new int[] { 0, 8, 2 } };
            yield return new object[] { graph, 0, 10, new int[] { } };
            yield return new object[] { graph, 0, 11, new int[] { 0, 8, 5, 4, 11 } };
            yield return new object[] { graph, 0, 1, new int[] { 0, 8, 5, 4, 11, 1 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
