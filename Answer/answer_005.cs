string input = Console.ReadLine();
string[] array = input.Split(' ');

int X = Convert.ToInt32(array[0]);
int Y = Convert.ToInt32(array[1]);

int result = X;
for(int i = 0; i < Y; i++){
    result = result * 2;
}

Console.WriteLine(result);