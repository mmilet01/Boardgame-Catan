namespace Catan.DomainClasses
{
    public class Edge
    {
        public Vertex Vertex1 { get; }
        public Vertex Vertex2 { get; }

        public Edge(Vertex vertex1, Vertex vertex2)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
        }
    }
}
