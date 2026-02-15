int N = Convert.ToInt32(Console.ReadLine());

string[] S = new string[N];
for(int i = 0; i < N; i++){
    S[i] = Console.ReadLine();
}

int m = 0;
for(int i = 0; i < S.Length; i++){
    if(S[i].Length > m){
        m = S[i].Length;
    }
}

for(int i = 0; i < S.Length; i++){
    int space = m - S[i].Length;
    int left = space/2 + S[i].Length;
    string result = S[i].PadLeft(left, '.').PadRight(m, '.');

    Console.WriteLine(result);
}