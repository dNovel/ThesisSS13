List<int> numQuery2 =
    (from num in numbers
     where (num % 2) == 0
     select num).ToList();