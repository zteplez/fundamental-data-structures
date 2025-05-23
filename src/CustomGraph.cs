using System;

namespace FundamentalDataStructures.src;

public class CustomGraph
{
    public class Vertex
    {
        internal List<Edge> edges;
        internal string value;
        public Vertex(List<Edge> edges, string value)
        {
            this.edges = edges;
            if (edges == null)
            {
                edges = new List<Edge>();
            }
            this.value = value;
        }
        public void AddEdge(Edge edge)
        {
            if (!edges.Contains(edge))
            {
                edges.Add(edge);
            }
            else Console.WriteLine("Edge already in list.");
        }
    }
    public class Edge
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
    public void AddVertex(string value)
    {
        Vertex newVertex = new Vertex(null, value);
        vertices.Add(newVertex);
    }
    public void AddEdge(Vertex v1, Vertex v2)
    {
        Edge newEdge = new Edge(v1, v2);
        v1.AddEdge(newEdge);
        v2.AddEdge(newEdge);
        edges.Add(newEdge);
    }
}
