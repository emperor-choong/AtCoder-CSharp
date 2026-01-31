string input = Console.ReadLine();
string[] array = input.Split(' ');
int D = Convert.ToInt32(array[0]);
int F = Convert.ToInt32(array[1]);

int N = 7 - (D-F) % 7;

Console.WriteLine(N);