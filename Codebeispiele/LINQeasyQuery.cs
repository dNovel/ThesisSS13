// Collection to work with
int[] numbers = new int[5] {0, 1, 2, 3, 4};

// This is the statement
var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

// Here the query gets executed.
foreach (int num in numQuery)
{
    Console.Write(num);
}