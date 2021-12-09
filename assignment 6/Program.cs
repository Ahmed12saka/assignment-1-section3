int[] array = { 2, 3, 3, 4, 1, 2, 5 };
int[] distinct = array.Distinct().ToArray();

Console.WriteLine(String.Join(",", distinct));