import React, { useState } from 'react';
import { Text } from 'react-konva';

interface IVertex {
  index: number;
  x: number;
  screenX: number;
  y: number;
  screenY: number;
  port: boolean;
}

const Vertex: React.FC<IVertex> = ({ x, y, screenX, screenY }) => {
  const [text, setText] = useState<string>("O");

  const handleClick = () => {
    console.log(`new VertexId(${x}, ${y})`);
    setText("X");
  };

  return (
    <Text
      x={screenX}
      y={screenY}
      text={text}
      fontSize={30}
      fill="blue"
      onClick={handleClick}
    />
  );
};

export default Vertex;
