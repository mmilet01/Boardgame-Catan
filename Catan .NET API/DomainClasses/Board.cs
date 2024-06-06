using Catan.DomainClasses.Constants;

namespace Catan.DomainClasses;

public class Board
{
    public int Radius { get; set; }
    public int Padding { get; set; }
    public List<HexCell> HexCells { get; private set; }
    public List<Vertex> Vertices { get; private set; }

    public Board()
    {
        HexCells = HexCellList.GetHexCells();
        Vertices = VerticesList.GetListOfVertices();
        Padding = 7;
        Radius = 100;
        AssignResourceTypesToHexes();
    }

    private void AssignResourceTypesToHexes()
    {
        List<ResourceType> resources = new List<ResourceType>(ResourceList.ResourceTypeDistribution);

        // Shuffle the list
        Random rng = new Random();
        resources = resources.OrderBy(x => rng.Next()).ToList();

        for (var i = 0; i < HexCells.Count; i++)
        {
            HexCells[i].Type = resources[i];
            HexCells[i].Texture = ResourceList.ResourceTypeToTexture.GetValueOrDefault(HexCells[i].Type)!;
        }
    }
}
