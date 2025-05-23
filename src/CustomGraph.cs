using System;

namespace FundamentalDataStructures.src;

public class CustomGraph
{
    public class Vertex
    {
        internal List<Edge> neighbors;
        internal string value;
        public Vertex(string value)
        {
            this.neighbors = new List<Edge>();
            this.value = value;
        }
        public void AddEdge(Edge edge)
        {
            if (!neighbors.Contains(edge))
            {
                neighbors.Add(edge);
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
        public Vertex GetOtherVertex(Vertex v)
        {
            if (v == first) return second;
            if (v == second) return first;
            return null;
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
        Vertex newVertex = new Vertex(value);
        vertices.Add(newVertex);
    }
    public void AddEdge(Vertex v1, Vertex v2)
    {
        Edge newEdge = new Edge(v1, v2);
        v1.AddEdge(newEdge);
        v2.AddEdge(newEdge);
        edges.Add(newEdge);
    }
    private Vertex GetVertex(string value)
    {
        return vertices.Find(v => v.value == value);
    }
    public void PrintGraph()
{
    foreach (var vertex in vertices)
    {
        Console.Write(vertex.value + " -> ");
        foreach (var edge in vertex.neighbors)
        {
            string connectedTo = edge.GetOtherVertex(vertex).value;
            Console.Write(connectedTo + " ");
        }
        Console.WriteLine();
    }
}


}
