string S = Console.ReadLine();

int numberOfDots = 0;
for(int i = 0; i < S.Length; i++){
    if(S[i] == 'i' || S[i] == 'j'){
        numberOfDots++;
    }
}

Console.WriteLine(numberOfDots);