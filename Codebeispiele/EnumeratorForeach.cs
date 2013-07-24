// Use this enumerator to retrieve all faces that directly connect to the specific vertex.
foreach (HandleFace hFace in EnVertexAdjacentFaces(vertexHandle))
{
	...
}

// This enumerator uses a LINQ statement to filter the result again.
// Get all half-edges that are adjacent to a specific face.
// And then just retrieve the half-edge pointer container for each already found half-edge.
foreach (HEdgePtrCont currentHedge in EnFaceAdjacentHalfEdges(faceHandle).Select(handleHalfEdge => _LhedgePtrCont[handleHalfEdge]))
{
	...
}