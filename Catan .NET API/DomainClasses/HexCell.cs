namespace Catan.DomainClasses;

public class HexCell
{
    public int X { get; }
    public int Y { get; }
    public int Z { get; }
    public ResourceType Type { get; set; }
    public List<Edge> Edges { get; set; } // 6 edges, need to uniquely identify them -> meaning v1 -> v2 is one edge
    public List<Vertex> TochingVertices { get; set; } // shared and uniquely identified as well, combination of hexes that share it
    public bool IsBlockedByRobber { get; set; }
    public int Number { get; set; }  // depends on a hex and where is it positioned on a board -> number can be constant?
    public string Texture { get; set; }


    public HexCell(int x, int y, int z, List<Vertex> vertices, ResourceType type = ResourceType.Unassigned)
    {
        if (x + y + z != 0) throw new ArgumentException("Invalid cube coordinates");
        X = x;
        Y = y;
        Z = z;
        Type = type;
        TochingVertices = vertices;

        /*
        give each hex correct vertices based on it's x-y-z coordinates, also then give it a lists of edges
         what if i just list vertices for each hex here and then also have a set which will uniquely identify them so when i
        
         */
    }
}