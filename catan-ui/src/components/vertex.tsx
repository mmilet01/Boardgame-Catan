import { Graphics, Sprite, Container, Text } from "@pixi/react";
import * as PIXI from "pixi.js";
import { useEffect, useRef, useState } from "react";

interface IVertex {
	index: number;
	x: number;
	y: number;
	port: boolean;
}

export const Vertex = ({ x, y, index, port }: IVertex) => {
	const textRef = useRef<PIXI.Text>(null);
	const [text, setText] = useState("O");

	useEffect(() => {
		if (textRef.current) {
			const text = textRef.current;

			text.interactive = true;

			// Add click event to text
			text.on("click", (e) => {
				//i cna find out the id here when clicked
				console.log(`new VertexId(${x}, ${y}),`);
				setText("X");
			});
		}
	}, []);
	return <Text ref={textRef} x={x} y={y} text={text} anchor={0.5} />;
};
