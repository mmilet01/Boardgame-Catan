import React, { useEffect, useState } from 'react';
import { Stage, Layer } from 'react-konva';
import Hexagon from './Hexagon';
import Vertex from './Vertex';
import { IBoard } from "@/Interfaces/interfaces";

const Board: React.FC = () => {
  const [board, setBoard] = useState<IBoard | null>(null);
  const width = 1000;
  const height = 1200;

  useEffect(() => {
    fetch("http://localhost:5049/catan")
      .then(response => response.json())
      .then(data => setBoard(data as IBoard))
      .catch(error => console.error("Error fetching board:", error));
  }, []);

  if (!board) {
    return <div>Loading...</div>;
  }

  return (
    <Stage width={width} height={height}>
      <Layer>
        {board.hexCells.map(hex => (
          <Hexagon
            key={`${hex.x}-${hex.y}-${hex.z}`}
            screenX={(hex.x * ((3 / 2) * board.radius + board.padding)) + (width / 2) }
            screenY={(Math.sqrt(3) * hex.y + (Math.sqrt(3) / 2) * hex.x) * (board.radius + board.padding / 2) + (height / 2) - board.radius}
            x={hex.x}
            y={hex.y}
            z={hex.z}
            radius={board.radius}
            image={hex.texture}
          />
        ))}
        {board.vertices.map((v, index) => (
          <Vertex
            index={index}
            key={index}
            screenX={v.vertexId.x + width/2 - board.padding - 5}
            screenY={v.vertexId.y + width/2 - board.padding - 5}
            x={v.vertexId.x}
            y={v.vertexId.y}
            port={true}
          />
        ))}
      </Layer>
    </Stage>
  );
};

export default Board;
