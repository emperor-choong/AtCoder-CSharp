int Q = Convert.ToInt32(Console.ReadLine());

int[] A = new int[Q];
for(int i = 0; i < Q; i++){
    A[i] = Convert.ToInt32(Console.ReadLine());
}

int volume = 0;
bool playing = false;
for(int i = 0; i < Q; i++){
    if(A[i] == 1){
        volume++;
    }else if(A[i] == 2){
        if(volume >= 1){
            volume--;
        }
    }else if(A[i] == 3){
        playing = !playing;
    }

    if(volume >= 3 && playing == true){
        Console.WriteLine("Yes");
    }
    else{
        Console.WriteLine("No");
    }
}