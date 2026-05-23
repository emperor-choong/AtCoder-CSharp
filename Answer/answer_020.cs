string S = Console.ReadLine();
int N = Convert.ToInt32(Console.ReadLine());

string sum = "";
for(int i = N; i < S.Length-N; i++){
    sum = sum + S[i];
}

Console.WriteLine(sum);