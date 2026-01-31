string input = Console.ReadLine();
string[] array = input.Split(' ');
int A = Convert.ToInt32(array[0]);
int B = Convert.ToInt32(array[1]);

int result = A*12 + B;

Console.WriteLine(result);