namespace Catan.DomainClasses
{
    public class Vertex
    {
        public VertexId VertexId { get; set; }
        public PortType Port { get; set; }
        public Structure Structure { get; set; }

        public Vertex(VertexId Id, PortType port = PortType.None)
        {
            VertexId = Id;
            Port = port;
        }
    }


    public class VertexId
    {
        public VertexId(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }


}