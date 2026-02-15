# B - Center Alignment
## AtCoder Beginner Contest 445

### Problem Statement
You are given **N** strings $S_1$, $S_2$, ..., $S_N$ of odd lengths consisting of lowercase English letters.

Let **m** be the length of the longest string among $S_1$, $S_2$, ..., $S_N$. Find strings $T_1$, $T_2$, ..., $T_N$ satisfying the following condition.
- Condition: $T_i$ is a string of length **m** formed by concatenating **k** copies of **.**, $S_i$, and **k** copies of **.** in this order, for some non-negative integer **k**.

### Constraints
- **N** is an integer between 1 and 100, inclusive.
- $S_i$ is a string of odd length between 1 and 99, inclusive, consisting of lowercase English letters.

### Input
The input is given from Standard Input in the following format:

N  
$S_1$  
$S_2$  
.  
.  
.  
$S_N$

### Output
Output **N** lines. The i-th line (1 ≤ i ≤ N) should contain $T_i$.

### Sample Input 1
```csharp
4
apple
blueberry
coconut
dragonfruit
```

### Sample Output 1
```csharp
...apple...
.blueberry.
..coconut..
dragonfruit
```
**m** = 11, and $T_1$, $T_2$, $T_3$, $T_4$ satisfy the condition in the problem statement for **k** = 3, 1, 2, 0, respectively.

### Sample Input 2
```csharp
6
abc
d
efghi
jkl
mnopq
r
```

### Sample Output 2
```csharp
.abc.
..d..
efghi
.jkl.
mnopq
..r..
```