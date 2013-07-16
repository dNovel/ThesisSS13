// Creating a collection.
int[] numbers = new int[5] {0, 1, 2, 3, 4};

// Executing a LINQ Statement in method form with a lambda expression.
// This expression will return every number in numbers multiplied by itself.
int[] newNumbers = numbers.Select(x => x * x);