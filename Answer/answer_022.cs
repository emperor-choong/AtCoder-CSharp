int N = Convert.ToInt32(Console.ReadLine());
string[] S = Console.ReadLine().Split(' ');

string sum = "";
for(int i = 0; i < S.Length; i++){
    char first = S[i][0];
    if(first == 'a' || first == 'b' || first == 'c'){
        sum = sum + "2";
    }else if(first == 'd' || first == 'e' || first == 'f'){
        sum = sum + "3";
    }else if(first == 'g' || first == 'h' || first == 'i'){
        sum = sum + "4";
    }else if(first == 'j' || first == 'k' || first == 'l'){
        sum = sum + "5";
    }else if(first == 'm' || first == 'n' || first == 'o'){
        sum = sum + "6";
    }else if(first == 'p' || first == 'q' || first == 'r' || first == 's'){
        sum = sum + "7";
    }else if(first == 't' || first == 'u' || first == 'v'){
        sum = sum + "8";
    }else if(first == 'w' || first == 'x' || first == 'y' || first == 'z'){
        sum = sum + "9";
    }
}

Console.WriteLine(sum);