int X = Convert.ToInt32(Console.ReadLine());
string s = "HelloWorld";

string sum = "";
for(int i = 0; i < s.Length; i++){
    if(i == X-1){
        continue;
    }

    sum = sum + s[i];
}

Console.WriteLine(sum);