using System;

namespace FundamentalDataStructures.src;

public class CustomGraph
{
    class Vertex
    {
        List<Edge> edges;
        string value;
        public Vertex(List<Edge> edges, string value)
        {
            this.edges = edges;
            if (edges == null) edges = new List<Edge>();
            this.value = value;
        }
    }
    class Edge
    {
        Vertex first;
        Vertex second;
        public Edge(Vertex v1, Vertex v2)
        {
            first = v1;
            second = v2;
        }
    }
    List<Vertex> vertices;
    List<Edge> edges;
    public CustomGraph()
    {
        vertices = new List<Vertex>();
        edges = new List<Edge>();
    }
}
