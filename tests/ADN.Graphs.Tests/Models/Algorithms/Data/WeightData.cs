using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Graphs.Tests
{
    public class WeightData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var graph = GraphGenerator.GetGraph();

            yield return new object[] { graph, 0, 9, 42 };
            yield return new object[] { graph, 0, 2, 26 };
            yield return new object[] { graph, 0, 10, double.MaxValue };
            yield return new object[] { graph, 0, 11, 31 };
            yield return new object[] { graph, 0, 1, 37 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
