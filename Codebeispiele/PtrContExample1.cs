// This list is a list full of Half-Edge Pointer Containers.
List<HalfEdgePtrCont> _LhePointerContainers = new List<HalfEdgePtrCont>();

...
// We are building up a Half-Edge Structure and do interesting things ...
...

// Now we want to manipulate a specific Pointer Container.
// So we first need a Handle to a Pointer Container.
// We retrieve "hep" by selecting the third last element in the Pointer Container List.
// (Does not make any special sense it's just for the example)
HandleHalfEdge heH = new HandleHalfEdge(_LhePointerContainers.Count() - 3);

// Now we want to manipulate this data set.
_LhePtrCont[heH] = new HalfEdgePtrCont()
{
    ...
    _f = _LhePointerContainers[heH]._f,
    ...
};

// Note: This is much faster than to allocate a new HalfEdgePtrCont in Memory and then using RemoveAt() and Insert() on the List<t>. 