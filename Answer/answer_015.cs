int N = Convert.ToInt32(Console.ReadLine());

string sum = "";
for(int i = N; i > 0; i--){
    if(i == 1){
        sum = sum + $"{i}";
    }else{
        sum = sum + $"{i},";
    }
}

Console.WriteLine(sum);