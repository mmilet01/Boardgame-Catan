import React from 'react';
import { Group, RegularPolygon, Image, Text } from 'react-konva';
import useImage from 'use-image';

interface IHexCell {
  x: number;
  y: number;
  z: number;
  screenX: number;
  screenY: number;
  radius: number;
  image: string;
}

const Hexagon: React.FC<IHexCell> = ({
  x, y, z, screenX, screenY, radius, image
}) => {
  const [img] = useImage(image);
  const patternScale = { x: 0.08, y: 0.08 };
  return (
    <Group x={screenX} y={screenY}>
      <RegularPolygon
        rotation={30}
        sides={6}
        radius={radius}
        fill="yellow"
        fillPatternImage={img}
        fillPatternOffset={{ x: 10, y: -100}}
        fillPatternScale={patternScale}
        stroke="black"
      />
      <Text
        text={`${x},${y},${z}`}
        fontSize={14}
        fill="#00008b"
        offsetX={10}
        offsetY={5}
      />
    </Group>
  );
};

export default Hexagon;
