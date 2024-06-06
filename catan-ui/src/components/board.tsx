import React, { useEffect, useState } from "react";
import { Hexagon } from "./hexagon";
import { Stage, Container } from "@pixi/react";
import { IBoard, IHexCell } from "@/Interfaces/interfaces";
import { Vertex } from "./vertex";

const Board = () => {
	const [board, setBoard] = useState<IBoard>();
	const width = 1200;
	const height = 1000;

	useEffect(() => {
		fetch("http://localhost:5049/catan")
			.then((response) => response.json())
			.then((data: IBoard) => setBoard(data))
			.catch((error) => console.error("Error fetching board:", error));
	}, []);

	return (
		<Stage width={width} height={1000} options={{ backgroundColor: 0xeeeeee }}>
			<Container x={width / 2} y={height / 2}>
				{board?.hexCells.map((hex) => (
					<Hexagon
						vertices={hex.tochingVertices}
						key={`${hex.x}-${hex.y}-${hex.z}`}
						screenX={hex.x * ((3 / 2) * board.radius + board.padding)}
						screenY={
							(Math.sqrt(3) * hex.y + (Math.sqrt(3) / 2) * hex.x) *
							(board.radius + board.padding / 2)
						}
						x={hex.x}
						y={hex.y}
						z={hex.z}
						radius={board.radius}
						image={hex.texture}
					/>
				))}
				{board?.vertices.map((v, index) => (
					<Vertex index={index} x={v.vertexId.x} y={v.vertexId.y} port={true} />
				))}
			</Container>
		</Stage>
	);
};

export default Board;
