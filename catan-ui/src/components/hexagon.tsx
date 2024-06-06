import { IVertex } from "@/Interfaces/interfaces";
import { Graphics, Sprite, Container, Text } from "@pixi/react";
import * as PIXI from "pixi.js";
import { useEffect, useRef } from "react";

interface IHexCell {
	x: number;
	y: number;
	z: number;
	vertices: IVertex[];
	screenX: number;
	screenY: number;
	radius: any;
	image: string;
}

export const Hexagon = ({
	x,
	y,
	z,
	vertices,
	screenX,
	screenY,
	radius,
	image,
}: IHexCell) => {
	const graphicsRef = useRef(null);
	const containerRef = useRef<PIXI.Container>(null);
	const spriteRef = useRef<PIXI.Sprite>(null);
	const textRef = useRef<PIXI.Text>(null);

	useEffect(() => {
		/* if (
			graphicsRef.current &&
			spriteRef.current &&
			containerRef.current &&
			textRef.current
		) {
			const sprite = spriteRef.current;
			sprite.mask = graphicsRef.current;

			sprite.interactive = true;

			// Add click event to sprite
			sprite.on("click", (e) => {
				console.log("Unique Hex ID", x, y, z);
				console.log("vertices for this Hex", vertices);
			});

			const text = textRef.current;
			text.on("click", (e) => {
				console.log("vertices for this Hex", vertices);
			});
		} */

		if (textRef.current) {
			const text = textRef.current;
			text.interactive = true;

			text.on("click", (e) => {
				console.log(vertices);
			});
		}
	}, []);

	const texture = PIXI.Texture.from(image);

	const drawHexagon = (g: PIXI.Graphics) => {
		g.clear();
		g.lineStyle(2, 0xff0000, 1);
		g.beginFill(0xffff00);
		g.moveTo(screenX + radius * Math.cos(0), screenY + radius * Math.sin(0));
		for (let side = 0; side < 7; side++) {
			const curAngle = (side * 2 * Math.PI) / 6;
			g.lineTo(
				screenX + radius * Math.cos(curAngle),
				screenY + radius * Math.sin(curAngle)
			);
		}
		g.endFill();
	};

	return (
		<Container ref={containerRef}>
			<Graphics ref={graphicsRef} draw={drawHexagon} />
			{/* 	<Sprite
				ref={spriteRef}
				texture={texture}
				x={screenX}
				y={screenY}
				anchor={0.5}
			/> */}
			<Text
				ref={textRef}
				text={`${x},${y},${z}`}
				anchor={0.5}
				x={screenX}
				y={screenY}
				style={{ fill: 0x00008b }} // Or use a string like 'style={{ fill: '#ff1010' }}'
			/>
		</Container>
	);
};
