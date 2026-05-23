int N = Convert.ToInt32(Console.ReadLine());
int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(A[X-1]);