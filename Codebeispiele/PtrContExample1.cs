// This list is a list full of Half-Edge Pointer Containers.
List<HalfEdgePtrCont> _LhePointerContainers = new List<HalfEdgePtrCont>();

...
// We are building up a Half-Edge Structure and do interesting things ...
...

// Now we want to manipulate a specific Pointer Container.
// So we first need a Handle to a Pointer Container.
// We retrieve "hep" by selecting the last element in the Pointer Container List. (Does not make any special sense it's just for the example)
HandleHalfEdge heH = new HandleHalfEdge(_LhePointerContainers.Count() - 1);
HalfEdgePtrCont hep = _LhePointerContainers[heH];

// We now can savely remove it from the List
_LhedgePtrCont.RemoveAt(heH);

// Let us do whatever we want for example manipulating the face pointer
// We are setting the face pointer to invalid.
hep._f = new HandleFace(-1);

// Now we can savely insert the changed Container in the List again
_LhedgePtrCont.Insert(heH, hep);