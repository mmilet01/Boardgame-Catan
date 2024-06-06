/* function drawRoad(
	vertex1: { x: number; y: number },
	vertex2: { x: number; y: number },
	graphics: PIXI.Graphics
) {
	<Graphics draw={(g) => drawRoad(vertices[0], vertices[1], g)} />;

	// Calculate the midpoint
	const midX = (vertex1.x + vertex2.x) / 2;
	const midY = (vertex1.y + vertex2.y) / 2;

	// Calculate the angle between the two vertices
	const angle = Math.atan2(vertex2.y - vertex1.y, vertex2.x - vertex1.x);

	// Set road dimensions
	const roadLength = Math.sqrt(
		(vertex2.x - vertex1.x) ** 2 + (vertex2.y - vertex1.y) ** 2
	);
	const roadWidth = 5; // or whatever width you prefer

	// Draw the road as a rotated rectangle
	graphics.beginFill(0x8b4513); // brown color for road
	graphics.drawRect(
		midX - roadLength / 2,
		midY - roadWidth / 2,
		roadLength,
		roadWidth
	);
	graphics.rotation = angle;
	graphics.endFill();
}
 */
