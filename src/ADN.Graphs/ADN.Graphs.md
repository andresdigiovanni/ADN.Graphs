<a name='assembly'></a>
# ADN.Graphs

## Contents

- [BellmanFord](#T-ADN-Graphs-BellmanFord 'ADN.Graphs.BellmanFord')
  - [#ctor(graph,sourceNode)](#M-ADN-Graphs-BellmanFord-#ctor-ADN-Graphs-Graph,System-Int32- 'ADN.Graphs.BellmanFord.#ctor(ADN.Graphs.Graph,System.Int32)')
- [Dijkstra](#T-ADN-Graphs-Dijkstra 'ADN.Graphs.Dijkstra')
  - [#ctor(graph,sourceNode)](#M-ADN-Graphs-Dijkstra-#ctor-ADN-Graphs-Graph,System-Int32- 'ADN.Graphs.Dijkstra.#ctor(ADN.Graphs.Graph,System.Int32)')
- [Edge](#T-ADN-Graphs-Graph-Edge 'ADN.Graphs.Graph.Edge')
- [Graph](#T-ADN-Graphs-Graph 'ADN.Graphs.Graph')
  - [#ctor(verticesCount,directed)](#M-ADN-Graphs-Graph-#ctor-System-Int32,System-Boolean- 'ADN.Graphs.Graph.#ctor(System.Int32,System.Boolean)')
  - [EdgesCount](#P-ADN-Graphs-Graph-EdgesCount 'ADN.Graphs.Graph.EdgesCount')
  - [VerticesCount](#P-ADN-Graphs-Graph-VerticesCount 'ADN.Graphs.Graph.VerticesCount')
  - [AddEdge(edge)](#M-ADN-Graphs-Graph-AddEdge-ADN-Graphs-Graph-Edge- 'ADN.Graphs.Graph.AddEdge(ADN.Graphs.Graph.Edge)')
  - [Adjacency(vertex)](#M-ADN-Graphs-Graph-Adjacency-System-Int32- 'ADN.Graphs.Graph.Adjacency(System.Int32)')
  - [GetMatrix()](#M-ADN-Graphs-Graph-GetMatrix 'ADN.Graphs.Graph.GetMatrix')
- [ShortestPath](#T-ADN-Graphs-ShortestPath 'ADN.Graphs.ShortestPath')
  - [GetShortestPath(destinationNode)](#M-ADN-Graphs-ShortestPath-GetShortestPath-System-Int32- 'ADN.Graphs.ShortestPath.GetShortestPath(System.Int32)')
  - [GetWeight(destinationNode)](#M-ADN-Graphs-ShortestPath-GetWeight-System-Int32- 'ADN.Graphs.ShortestPath.GetWeight(System.Int32)')

<a name='T-ADN-Graphs-BellmanFord'></a>
## BellmanFord `type`

##### Namespace

ADN.Graphs

##### Summary

A class that implements BellmanFord algorithm.

<a name='M-ADN-Graphs-BellmanFord-#ctor-ADN-Graphs-Graph,System-Int32-'></a>
### #ctor(graph,sourceNode) `constructor`

##### Summary

BellmanFord algorithm to get the minimum path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| graph | [ADN.Graphs.Graph](#T-ADN-Graphs-Graph 'ADN.Graphs.Graph') | Graph to calculate the minimum path. |
| sourceNode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Source graph node. |

##### Example

```csharp
var graph = new double[,]
{
//    0   1   2   3
    { 0,  3,  0,  0 }, // 0
    { 0,  0,  5,  0 }, // 1
    { 0,  0,  0,  9 }, // 2
    { 0,  0,  0,  0 }, // 3
};
var sourceNode = 0;
var bellmanFord = new BellmanFord(graph, sourceNode); 
```

<a name='T-ADN-Graphs-Dijkstra'></a>
## Dijkstra `type`

##### Namespace

ADN.Graphs

##### Summary

A class that implements Dijkstra algorithm.

<a name='M-ADN-Graphs-Dijkstra-#ctor-ADN-Graphs-Graph,System-Int32-'></a>
### #ctor(graph,sourceNode) `constructor`

##### Summary

Dijkstra algorithm to get the minimum path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| graph | [ADN.Graphs.Graph](#T-ADN-Graphs-Graph 'ADN.Graphs.Graph') | Graph to calculate the minimum path. |
| sourceNode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Source graph node. |

##### Example

```csharp
var graph = new double[,]
{
//    0   1   2   3
    { 0,  3,  0,  0 }, // 0
    { 0,  0,  5,  0 }, // 1
    { 0,  0,  0,  9 }, // 2
    { 0,  0,  0,  0 }, // 3
};
var sourceNode = 0;
var dijkstra = new Dijkstra(graph, sourceNode); 
```

<a name='T-ADN-Graphs-Graph-Edge'></a>
## Edge `type`

##### Namespace

ADN.Graphs.Graph

##### Summary

Represents an edge of the graph.

<a name='T-ADN-Graphs-Graph'></a>
## Graph `type`

##### Namespace

ADN.Graphs

##### Summary

A class that represents a graph.

<a name='M-ADN-Graphs-Graph-#ctor-System-Int32,System-Boolean-'></a>
### #ctor(verticesCount,directed) `constructor`

##### Summary

Class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| verticesCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of vertices in the graph. |
| directed | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True if is a direct graph, false otherwise. |

<a name='P-ADN-Graphs-Graph-EdgesCount'></a>
### EdgesCount `property`

##### Summary

Number of edges in the graph.

##### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
// graph initialization
var result = graph.EdgesCount; 
```

<a name='P-ADN-Graphs-Graph-VerticesCount'></a>
### VerticesCount `property`

##### Summary

Number of vertices in the graph.

##### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
var result = graph.VerticesCount;
/*
result is 3
*/ 
```

<a name='M-ADN-Graphs-Graph-AddEdge-ADN-Graphs-Graph-Edge-'></a>
### AddEdge(edge) `method`

##### Summary

Add an edge in the graph.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| edge | [ADN.Graphs.Graph.Edge](#T-ADN-Graphs-Graph-Edge 'ADN.Graphs.Graph.Edge') | Edge to add. |

##### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
graph.AddEdge(new Graph.Edge
{
    Source = 0,
    Destination = 1,
    Weight = 10
}); 
```

<a name='M-ADN-Graphs-Graph-Adjacency-System-Int32-'></a>
### Adjacency(vertex) `method`

##### Summary

Gets the edges that connects a given vertex to the adjancency vertices.

##### Returns

Edges that connects with the adjancency vertices.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vertex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Origen vertex. |

##### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
// graph initialization
var adjancencyVertex = 0;
var result = graph.Adjacency(adjancencyVertex);
/*
result is a Graph.Edge[]
*/ 
```

<a name='M-ADN-Graphs-Graph-GetMatrix'></a>
### GetMatrix() `method`

##### Summary

Get a mtatrix that represents the graph.

##### Returns

A mtatrix that represents the graph.

##### Parameters

This method has no parameters.

##### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
// graph initialization
var result = graph.GetMatrix(); 
```

<a name='T-ADN-Graphs-ShortestPath'></a>
## ShortestPath `type`

##### Namespace

ADN.Graphs

<a name='M-ADN-Graphs-ShortestPath-GetShortestPath-System-Int32-'></a>
### GetShortestPath(destinationNode) `method`

##### Summary

Get the minimum path.

##### Returns

Minimum path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destinationNode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Destination graph node. |

##### Example

```csharp
var graph = new double[,]
{
//    0   1   2   3
    { 0,  3,  0,  0 }, // 0
    { 0,  0,  5,  0 }, // 1
    { 0,  0,  0,  9 }, // 2
    { 0,  0,  0,  0 }, // 3
};
var sourceNode = 0;
var destinationNode = 3;
var bellmanFord = new BellmanFord(graph, sourceNode);
var result = bellmanFord.GetShortestPath(destinationNode);
/*
result is { 0, 1, 2, 3 }
*/ 
```

<a name='M-ADN-Graphs-ShortestPath-GetWeight-System-Int32-'></a>
### GetWeight(destinationNode) `method`

##### Summary

Get the minimum weight.

##### Returns

Minimum weight.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destinationNode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Destination graph node. |

##### Example

```csharp
var graph = new double[,]
{
//    0   1   2   3
    { 0,  3,  0,  0 }, // 0
    { 0,  0,  5,  0 }, // 1
    { 0,  0,  0,  9 }, // 2
    { 0,  0,  0,  0 }, // 3
};
var sourceNode = 0;
var destinationNode = 3;
var bellmanFord = new BellmanFord(graph, sourceNode);
var result = bellmanFord.GetWeight(destinationNode);
/*
result is 17
*/ 
```
