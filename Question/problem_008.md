# B - Music Player
## AtCoder Beginner Contest 442

### Problem Statement
Takahashi has a music player. Initially, the volume is 0 and the music is stopped.

From now on, **Q** operations will be performed in order. The i-th operation is represented by an integer $A_i$, which means the following:
- If $A_i$ = 1, increase the volume by 1.
- If $A_i$ = 2, if the current volume is 1 or more, decrease it by 1; if it is 0, do nothing.
- If $A_i$ = 3, if the music is stopped, play it; if the music is playing, stop it.

For i = 1, 2, ..., Q, solve the following problem:
- Determine whether the music is playing at volume 3 or more immediately after the i-th operation.

### Constraints
- 1 ≤ Q ≤ 2 x $10^5$
- $A_i$ ∈ {1, 2, 3}
- All input values are integers.

### Input
The input is given from Standard Input in the following format:

Q  
$A_1$  
$A_2$  
.  
.  
.  
$A_Q$


### Output
Output **Q** lines. The i-th line should contain **Yes** if the music is playing at volume 3 or more immediately after the i-th operation, and **No** otherwise.

### Sample Input 1
```csharp
10
2
1
3
1
3
1
1
3
2
2
```

### Sample Output 1
```csharp
No
No
No
No
No
No
No
Yes
Yes
No
```
- After the 1-st operation, the volume is 0 and the music is stopped.
- After the 2-nd operation, the volume is 1 and the music is stopped.
- After the 3-rd operation, the volume is 1 and the music is playing.
- After the 4-th operation, the volume is 2 and the music is playing.
- After the 5-th operation, the volume is 2 and the music is stopped.
- After the 6-th operation, the volume is 3 and the music is stopped.
- After the 7-th operation, the volume is 4 and the music is stopped.
- After the 8-th operation, the volume is 4 and the music is playing.
- After the 9-th operation, the volume is 3 and the music is playing.
- After the 10-th operation, the volume is 2 and the music is playing.



