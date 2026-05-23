string input = Console.ReadLine();
string[] array = input.Split(' ');
int N = Convert.ToInt32(array[0]);
int M = Convert.ToInt32(array[1]);

if(M <= Math.Ceiling(N/2.0)){
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("No");
}