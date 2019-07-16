# ADN.Graphs

# Content

- [BellmanFord](#T:ADN.Graphs.BellmanFord)

  - [Constructor(graph, sourceNode)](#BellmanFord.#ctor(graph,sourceNode))

- [Dijkstra](#T:ADN.Graphs.Dijkstra)

  - [Constructor(graph, sourceNode)](#Dijkstra.#ctor(graph,sourceNode))

- [Graph](#T:ADN.Graphs.Graph)

  - [Constructor(verticesCount, directed)](#Graph.#ctor(verticesCount,directed))

  - [AddEdge(edge)](#Graph.AddEdge(edge))

  - [Adjacency(vertex)](#Graph.Adjacency(vertex))

- [Graph.Edge](#T:ADN.Graphs.Graph.Edge)

  - [.Graph.EdgesCount](#P:ADN.Graphs.Graph.EdgesCount)

  - [Graph.GetMatrix](#Graph.GetMatrix)

  - [.Graph.VerticesCount](#P:ADN.Graphs.Graph.VerticesCount)

  - [ShortestPath.GetShortestPath(destinationNode)](#ShortestPath.GetShortestPath(destinationNode))

  - [ShortestPath.GetWeight(destinationNode)](#ShortestPath.GetWeight(destinationNode))

<a name='T:ADN.Graphs.BellmanFord'></a>


## BellmanFord

A class that implements BellmanFord algorithm.

<a name='BellmanFord.#ctor(graph,sourceNode)'></a>


### Constructor(graph, sourceNode)

BellmanFord algorithm to get the minimum path.


#### Parameters

| Name | Description |
| ---- | ----------- |
| graph | *ADN.Graphs.Graph*<br>Graph to calculate the minimum path. |

#### Parameters

| sourceNode | *System.Int32*<br>Source graph node. |


#### Example

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

<a name='T:ADN.Graphs.Dijkstra'></a>


## Dijkstra

A class that implements Dijkstra algorithm.

<a name='Dijkstra.#ctor(graph,sourceNode)'></a>


### Constructor(graph, sourceNode)

Dijkstra algorithm to get the minimum path.


#### Parameters

| Name | Description |
| ---- | ----------- |
| graph | *ADN.Graphs.Graph*<br>Graph to calculate the minimum path. |

#### Parameters

| sourceNode | *System.Int32*<br>Source graph node. |


#### Example

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

<a name='T:ADN.Graphs.Graph'></a>


## Graph

A class that represents a graph.

<a name='Graph.#ctor(verticesCount,directed)'></a>


### Constructor(verticesCount, directed)

Class constructor.


#### Parameters

| Name | Description |
| ---- | ----------- |
| verticesCount | *System.Int32*<br>Number of vertices in the graph. |

#### Parameters

| directed | *System.Boolean*<br>True if is a direct graph, false otherwise. |
<a name='Graph.AddEdge(edge)'></a>


### AddEdge(edge)

Add an edge in the graph.


#### Parameters

| Name | Description |
| ---- | ----------- |
| edge | *ADN.Graphs.Graph.Edge*<br>Edge to add. |


#### Example

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

<a name='Graph.Adjacency(vertex)'></a>


### Adjacency(vertex)

Gets the edges that connects a given vertex to the adjancency vertices.


#### Parameters

| Name | Description |
| ---- | ----------- |
| vertex | *System.Int32*<br>Origen vertex. |


#### Returns

Edges that connects with the adjancency vertices.


#### Example

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

<a name='T:ADN.Graphs.Graph.Edge'></a>


## Graph.Edge

Represents an edge of the graph.

<a name='P:ADN.Graphs.Graph.EdgesCount'></a>


### .Graph.EdgesCount

Number of edges in the graph.


#### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
// graph initialization
var result = graph.EdgesCount;
```

<a name='Graph.GetMatrix'></a>


### Graph.GetMatrix

Get a mtatrix that represents the graph.


#### Returns

A mtatrix that represents the graph.


#### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
// graph initialization
var result = graph.GetMatrix();
```

<a name='P:ADN.Graphs.Graph.VerticesCount'></a>


### .Graph.VerticesCount

Number of vertices in the graph.


#### Example

```csharp
var verticesCount = 3;
var graph = new Graph(verticesCount);
var result = graph.VerticesCount;

/*
result is 3
*/
```

<a name='ShortestPath.GetShortestPath(destinationNode)'></a>


### ShortestPath.GetShortestPath(destinationNode)

Get the minimum path.


#### Parameters

| Name | Description |
| ---- | ----------- |
| destinationNode | *System.Int32*<br>Destination graph node. |


#### Returns

Minimum path.


#### Example

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

<a name='ShortestPath.GetWeight(destinationNode)'></a>


### ShortestPath.GetWeight(destinationNode)

Get the minimum weight.


#### Parameters

| Name | Description |
| ---- | ----------- |
| destinationNode | *System.Int32*<br>Destination graph node. |


#### Returns

Minimum weight.


#### Example

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

