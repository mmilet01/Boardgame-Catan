using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catan.DomainClasses
{
    public class Player
    {
        public string Name { get; set; }
        public List<Vertex> OwnedVertices { get; set; } // Settlements/Cities
        public List<Edge> OwnedEdges { get; set; } // Roads

        public Player(string name)
        {
            Name = name;
            OwnedVertices = new List<Vertex>();
            OwnedEdges = new List<Edge>();
        }

        public void BuildOn(Vertex vertex)
        {
            // Business logic to check if player can build on vertex
            OwnedVertices.Add(vertex);
        }
    }

}