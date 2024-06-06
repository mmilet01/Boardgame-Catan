export interface IBoard {
	hexCells: IHexCell[];
	vertices: IVertex[];
	padding: number;
	radius: number;
}

export enum IResourceType {
	Unassigned = 0,
	Wood,
	Brick,
	Wheat,
	Ore,
	Sheep,
	Desert,
}

export enum IPortType {
	None,
	Generic, // 3:1 port
	Wood,
	Brick,
	Wheat,
	Ore,
	Sheep,
}

export interface IEdge {
	adjacentCells: IHexCell[];
	port: IPortType;
}

export interface IHexCell {
	x: number;
	y: number;
	z: number;
	type: IResourceType;
	edges: IEdge[];
	tochingVertices: IVertex[];
	isBlockedByRobber?: boolean;
	texture: string;
}

export interface IVertex {
	vertexId: IVertexId;
}

export interface IVertexId {
	x: number;
	y: number;
}
