string input = Console.ReadLine();
string[] array = input.Split(' ');
int L = Convert.ToInt32(array[0]);
int R = Convert.ToInt32(array[1]);

int result = R - L + 1;
Console.WriteLine(result);