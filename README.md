# Graphs Library for .NET

ADN.Graphs is a cross-platform open-source library which provides graphs library to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.Graphs.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.Graphs)
[![NuGet](https://img.shields.io/nuget/v/ADN.Graphs.svg)](https://www.nuget.org/packages/ADN.Graphs/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.Graphs?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Graphs&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Graphs)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Graphs&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Graphs)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Example Shortest Path:

```csharp
// Graph represented as adjacency matrix:
// 0 -> 1
// 1 -> 2
// 2 -> 3
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

## Installation

ADN.Graphs runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.Graphs NuGet package from the NuGet package manager:

```
Install-Package ADN.Graphs
```

Or alternatively you can add the ADN.Graphs package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.Graphs/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.Graphs is licensed under the [MIT license](LICENSE).
