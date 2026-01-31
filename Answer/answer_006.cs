string input_1 = Console.ReadLine();
string input_2 = Console.ReadLine();

string[] array_1 = input_1.Split(' ');
string[] array_2 = input_2.Split(' ');

int P = Convert.ToInt32(array_1[0]);
int Q = Convert.ToInt32(array_1[1]);
int X = Convert.ToInt32(array_2[0]);
int Y = Convert.ToInt32(array_2[1]);

if((X >= P && X <= P+99) && (Y >= Q && Y <= Q+99)){
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("No");
}