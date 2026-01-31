# A - Octave
## AtCoder Beginner Contest 440

### Problem Statement
The frequency of a sound doubles for every increase of 1 octave in pitch.

If the pitch of a sound with frequency X hertz is raised by Y octaves, what will its frequency be in hertz?

### Constraints
- 1 ≤ X ≤ 444
- 1 ≤ Y ≤ 3
- All input values are integers.

### Input
The input is given from Standard Input in the following format:
```csharp
X Y
```

### Output
Output the answer as an integer in one line. Omit the unit (hertz).

### Sample Input 1
```csharp
110 2
```

### Sample Output 1
```csharp
440
```
For a sound 2 octaves above a sound with frequency 110 hertz, its frequency is 110 × 2 × 2 = 440 hertz.

### Sample Input 2
```csharp
233 3
```

### Sample Output 2
```csharp
1864
```
For a sound 3 octaves above a sound with frequency 233 hertz, its frequency is 233 × 2 × 2 × 2 = 1864 hertz.

### Sample Input 3
```csharp
432 1
```

### Sample Output 3
```csharp
864
```
For a sound 
1 octave above a sound with frequency 432 hertz, its frequency is 432 × 2 = 864 hertz.