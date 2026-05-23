# B - 459
## AtCoder Beginner Contest 459

### Problem Statement
You are given **N** strings **$S_1$, $S_2$, ..., $S_N$** consisting of lowercase English letters.

Define **N** digits **$C_1$, $C_2$, ..., $C_N$** as follows:
- If the first character of $S_i$ is one of **a**, **b**, **c**, then **$C_i$ = 2**
- If the first character of $S_i$ is one of **d**, **e**, **f**, then **$C_i$ = 3**
- If the first character of $S_i$ is one of **g**, **h**, **i**, then **$C_i$ = 4**
- If the first character of $S_i$ is one of **j**, **k**, **l**, then **$C_i$ = 5**
- If the first character of $S_i$ is one of **m**, **n**, **o**, then **$C_i$ = 6**
- If the first character of $S_i$ is one of **p**, **q**, **r**, **s**, then **$C_i$ = 7**
- If the first character of $S_i$ is one of **t**, **u**, **v**, then **$C_i$ = 8**
- If the first character of $S_i$ is one of **w**, **x**, **y**, **z**, then **$C_i$ = 9**

Output the string obtained by concatenating $C_1$, $C_2$, ..., $C_N$ in this order.

### Constraints
- **1 ≤ N ≤ 10**
- **N** is an integer.
- **$S_i$** is a string of length between **1** and **10**, inclusive, consisting of lowercase English letters.

### Input
The input is given from Standard Input in the following format:

N  
$S_1$ $S_2$ ... $S_N$

### Output
Output the string obtained by concatenating $C_1$, $C_2$, ..., $C_N$ in this order.

### Sample Input 1
```csharp
2
algorithm heuristic
```

### Sample Output 1
```csharp
24
```
- The first character of **$S_1$ = algorithm** is **a**, so **$C_1$ = 2**.
- The first character of **$S_2$ = heuristic** is **h**, so **$C_2$ = 4**.

Thus, output **24**, which is their concatenation.

### Sample Input 2
```csharp
3
i love you
```

### Sample Output 2
```csharp
459
```