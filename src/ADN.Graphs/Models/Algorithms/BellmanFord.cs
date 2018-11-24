using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Graphs
{
    /// <summary>
    /// A class that implements BellmanFord algorithm.
    /// </summary>
    public class BellmanFord : ShortestPath
    {
        /// <summary>
        /// BellmanFord algorithm to get the minimum path.
        /// </summary>
        /// <param name="graph">Graph to calculate the minimum path.</param>
        /// <param name="sourceNode">Source graph node.</param>
        public BellmanFord(Graph graph, int sourceNode)
        {
            int verticesCount = graph.VerticesCount;
            int edgesCount = graph.EdgesCount;

            InitializeDistances(graph, sourceNode);

            for (int iter = 0; iter < verticesCount; ++iter)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    Graph.Edge[] adjacency = graph.Adjacency(i);
                    for (int j = 0; j < adjacency.Length; ++j)
                    {
                        int u = adjacency[j].Source;
                        int v = adjacency[j].Destination;
                        double weight = adjacency[j].Weight;

                        if (_distance[u] + weight < _distance[v])
                        {
                            _distance[v] = _distance[u] + weight;
                            _previous[v] = u;
                        }
                    }
                }
            }

            for (int i = 0; i < verticesCount; ++i)
            {
                Graph.Edge[] adjacency = graph.Adjacency(i);
                for (int j = 0; j < adjacency.Length; ++j)
                {
                    int u = adjacency[j].Source;
                    int v = adjacency[j].Destination;
                    double weight = adjacency[j].Weight;

                    if (_distance[u] + weight < _distance[v])
                    {
                        throw new Exception("Graph contains negative weight cycle.");
                    }
                }
            }
        }
    }
}
