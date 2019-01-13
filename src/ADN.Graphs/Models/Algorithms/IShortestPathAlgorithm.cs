using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Graphs
{
    public interface IShortestPathAlgorithm
    {
        int[] GetShortestPath(int destinationNode);

        double GetWeight(int destinationNode);
    }
}
