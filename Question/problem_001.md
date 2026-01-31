# A - o-padding
## AtCoder Beginner Contest 436

### Problem Statement
You are given an integer **N** and a string **S** consisting of lowercase English letters with length **less than** **N**.

Print the string obtained by repeatedly adding the lowercase English letter **o** to the beginning of **S** until its length becomes **N**.

### Constraints
- 2 ≤ N ≤ 100
- N is an integer.
- S is a string consisting of lowercase English letters with length between 1 and N-1, inclusive.

### Input
The input is given from Standard Input in the following format:
```csharp
N
S
```

### Output
Print the answer.

### Sample Input 1
```csharp
5
abc
```

### Sample Output 1
```csharp
ooabc
```
Since N = 5 and the length of S is 3, the answer is the string obtained by adding 5 - 3 = 2 os to the beginning of S.

### Sample Input 2
```csharp
2
o
```

### Sample Output 2
```csharp
oo
```

### Sample Input 3
```csharp
12
vgxgpuam
```

### Sample Output 3
```csharp
oooovgxgpuam
```