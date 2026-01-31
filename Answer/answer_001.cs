int N = Convert.ToInt32(Console.ReadLine());
string S = Console.ReadLine();

string result = S.PadLeft(N, 'o');

Console.WriteLine(result);