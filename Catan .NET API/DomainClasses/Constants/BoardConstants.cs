
namespace Catan.DomainClasses.Constants
{
    public static class ResourceList
    {
        public static readonly List<ResourceType> ResourceTypeDistribution = new List<ResourceType>
        {
            ResourceType.Wood,
            ResourceType.Wood,
            ResourceType.Wood,
            ResourceType.Wood,
            ResourceType.Brick,
            ResourceType.Brick,
            ResourceType.Brick,
            ResourceType.Wheat,
            ResourceType.Wheat,
            ResourceType.Wheat,
            ResourceType.Wheat,
            ResourceType.Ore,
            ResourceType.Ore,
            ResourceType.Ore,
            ResourceType.Sheep,
            ResourceType.Sheep,
            ResourceType.Sheep,
            ResourceType.Sheep,
            ResourceType.Desert
        };



        public static readonly Dictionary<ResourceType, string> ResourceTypeToTexture = new Dictionary<ResourceType, string>
        {
            { ResourceType.Wood, "https://images.unsplash.com/photo-1521706862577-47b053587f91?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2672&q=80"},
            { ResourceType.Brick, "https://images.unsplash.com/photo-1599011802274-84cb7f099848?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2070&q=80" },
            { ResourceType.Ore, "https://images.unsplash.com/photo-1647153980948-489442cd45b7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2070&q=80" },
            { ResourceType.Wheat, "https://images.unsplash.com/photo-1437252611977-07f74518abd7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1974&q=80" },
            { ResourceType.Sheep, "https://images.unsplash.com/photo-1511117833895-4b473c0b85d6?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2070&q=80" },
            { ResourceType.Desert, "https://images.unsplash.com/photo-1542401886-65d6c61db217?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2070&q=80" },
        };
    }

    public static class VerticesList
    {
        private static readonly List<Vertex> StaticVertices = GenerateVertices();
        public static List<Vertex> GetListOfVertices()
        {
            return StaticVertices;
        }

        private static List<Vertex> GenerateVertices()
        {
            List<Vertex> Vertices = new List<Vertex>
            {
                // first row
                new Vertex(new VertexId(100, 0)),
                new Vertex(new VertexId(215, 0)),
                new Vertex(new VertexId(-100, 0)),
                new Vertex(new VertexId(-215, 0)),
                new Vertex(new VertexId(415, 0)),
                new Vertex(new VertexId(-415, 0)),

                //second row
                new Vertex(new VertexId(55, 90)),
                new Vertex(new VertexId(-55, 90)),
                new Vertex(new VertexId(260, 90)),
                new Vertex(new VertexId(-260, 90)),
                new Vertex(new VertexId(365, 90)),
                new Vertex(new VertexId(-365, 90)),

                //third row - x same as 2nd row
                new Vertex(new VertexId(55, -90)),
                new Vertex(new VertexId(-55, -90)),
                new Vertex(new VertexId(260, -90)),
                new Vertex(new VertexId(-260, -90)),
                new Vertex(new VertexId(365, -90)),
                new Vertex(new VertexId(-365, -90)),

                //forth row -> x same as first row, y + 90 etc...
                new Vertex(new VertexId(100, 180)),
                new Vertex(new VertexId(210, 180)),
                new Vertex(new VertexId(-100, 180)),
                new Vertex(new VertexId(-210, 180)),
                new Vertex(new VertexId(415, 180)),
                new Vertex(new VertexId(-415, 180)),

                new Vertex(new VertexId(100, -180)),
                new Vertex(new VertexId(210, -180)),
                new Vertex(new VertexId(-100, -180)),
                new Vertex(new VertexId(-210, -180)),
                new Vertex(new VertexId(415, -180)),
                new Vertex(new VertexId(-415, -180)),

                new Vertex(new VertexId(55, 265)),
                new Vertex(new VertexId(-55, 265)),
                new Vertex(new VertexId(260, 265)),
                new Vertex(new VertexId(-260, 265)),
                new Vertex(new VertexId(365, 265)),
                new Vertex(new VertexId(-365, 265)),

                new Vertex(new VertexId(55, -265)),
                new Vertex(new VertexId(-55, -265)),
                new Vertex(new VertexId(260, -265)),
                new Vertex(new VertexId(-260, -265)),
                new Vertex(new VertexId(365, -265)),
                new Vertex(new VertexId(-365, -265)),

                new Vertex(new VertexId(100, 355)),
                new Vertex(new VertexId(210, 355)),
                new Vertex(new VertexId(-100, 355)),
                new Vertex(new VertexId(-210, 355)),

                new Vertex(new VertexId(100, -355)),
                new Vertex(new VertexId(210, -355)),
                new Vertex(new VertexId(-100, -355)),
                new Vertex(new VertexId(-210, -355)),

                new Vertex(new VertexId(50, -445)),
                new Vertex(new VertexId(-50, -445)),

                new Vertex(new VertexId(50, 445)),
                new Vertex(new VertexId(-50, 445))
            };

            return Vertices;
        }
    }


    public static class HexCellList
    {
        private static readonly List<HexCell> TemplateHexCells = GenerateHexCells();

        public static List<HexCell> GetHexCells()
        {
            return TemplateHexCells;
        }

        private static List<Vertex> FilterVerticesBasedOnXandY(List<VertexId> values)
        {
            var Vertices = VerticesList.GetListOfVertices();

            List<Vertex> filteredVertices = Vertices.Where(vertex =>
                values.Any(value =>
                    value.X == vertex.VertexId.X && value.Y == vertex.VertexId.Y)
            ).ToList();

            return filteredVertices;
        }

        private static List<HexCell> GenerateHexCells()
        {

            List<HexCell> hexCells = new List<HexCell>
            {
                new HexCell(-2, 1, 1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-260, -90),
                    new VertexId(-215, 0),
                    new VertexId(-260, 90),
                    new VertexId(-365, 90),
                    new VertexId(-415, 0),
                    new VertexId(-365, -90)
                })),
                new HexCell(-2, 2, 0, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(260, -90),
                    new VertexId(365, -90),
                    new VertexId(415, -180),
                    new VertexId(365, -265),
                    new VertexId(260, -265),
                    new VertexId(210, -180),
                })),
                new HexCell(-1, 1, 0, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-260, 90),
                    new VertexId(-210, 180),
                    new VertexId(-100, 180),
                    new VertexId(-55, 90),
                    new VertexId(-100, 0),
                    new VertexId(-215, 0),
                })),
                new HexCell(-1, 0, 1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-215, 0),
                    new VertexId(-100, 0),
                    new VertexId(-55, -90),
                    new VertexId(-100, -180),
                    new VertexId(-210, -180),
                    new VertexId(-260, -90),
                })),
                new HexCell(0, -1, 1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-55, -265),
                    new VertexId(-100, -180),
                    new VertexId(-55, -90),
                    new VertexId(55, -90),
                    new VertexId(100, -180),
                    new VertexId(55, -265),
                })),
                new HexCell(0, 0, 0, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-55, 90),
                    new VertexId(55, 90),
                    new VertexId(100, 0),
                    new VertexId(55, -90),
                    new VertexId(-55, -90),
                    new VertexId(-100, 0),
                })),
                new HexCell(0, 1, -1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-55, 90),
                    new VertexId(55, 90),
                    new VertexId(100, 180),
                    new VertexId(55, 265),
                    new VertexId(-55, 265),
                    new VertexId(-100, 180),
                })),
                new HexCell(1, 0, -1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(100, 0),
                    new VertexId(55, 90),
                    new VertexId(100, 180),
                    new VertexId(210, 180),
                    new VertexId(260, 90),
                    new VertexId(215, 0),
                })),
                new HexCell(1, -1, 0, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(55, -90),
                    new VertexId(100, -180),
                    new VertexId(210, -180),
                    new VertexId(260, -90),
                    new VertexId(215, 0),
                    new VertexId(100, 0),
                })),
                new HexCell(2, -1, -1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(365, 90),
                    new VertexId(415, 0),
                    new VertexId(365, -90),
                    new VertexId(260, -90),
                    new VertexId(215, 0),
                    new VertexId(260, 90),
                })),
                new HexCell(2, -2, 0, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(210, -180),
                    new VertexId(260, -265),
                    new VertexId(365, -265),
                    new VertexId(415, -180),
                    new VertexId(365, -90),
                    new VertexId(260, -90),
                })),
                new HexCell(-1, -1, 2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-210, -355),
                    new VertexId(-100, -355),
                    new VertexId(-55, -265),
                    new VertexId(-100, -180),
                    new VertexId(-210, -180),
                    new VertexId(-260, -265),
                })),
                new HexCell(-2, 0, 2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-365, -90),
                    new VertexId(-260, -90),
                    new VertexId(-210, -180),
                    new VertexId(-260, -265),
                    new VertexId(-365, -265),
                    new VertexId(-415, -180),
                })),
                new HexCell(0, -2, 2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-55, -265),
                    new VertexId(55, -265),
                    new VertexId(100, -355),
                    new VertexId(50, -445),
                    new VertexId(-50, -445),
                    new VertexId(-100, -355),
                })),
                new HexCell(1, -2, 1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(100, -180),
                    new VertexId(210, -180),
                    new VertexId(260, -265),
                    new VertexId(210, -355),
                    new VertexId(100, -355),
                    new VertexId(55, -265),
                })),
                new HexCell(0, 2, -2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-55, 265),
                    new VertexId(55, 265),
                    new VertexId(100, 355),
                    new VertexId(50, 445),
                    new VertexId(-50, 445),
                    new VertexId(-100, 355),
                })),
                new HexCell(-1, 2, -1, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(-210, 355),
                    new VertexId(-100, 355),
                    new VertexId(-55, 265),
                    new VertexId(-100, 180),
                    new VertexId(-210, 180),
                    new VertexId(-260, 265),
                })),
                new HexCell(1, 1, -2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(100, 355),
                    new VertexId(210, 355),
                    new VertexId(260, 265),
                    new VertexId(210, 180),
                    new VertexId(100, 180),
                    new VertexId(55, 265),
                })),
                new HexCell(2, 0, -2, FilterVerticesBasedOnXandY(new List<VertexId>
                {
                    new VertexId(260, 265),
                    new VertexId(210, 180),
                    new VertexId(260, 90),
                    new VertexId(365, 90),
                    new VertexId(415, 180),
                    new VertexId(365, 265),
                })),
            };
            return hexCells;
        }
    }
}