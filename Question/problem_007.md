# A - Count .
## AtCoder Beginner Contest 442

### Problem Statement
You are given a string **S** consisting of lowercase English letters.

Here, we define the number of **dots** in a lowercase English letter as follows:
- If the lowercase English letter is `i` or `j`: 1 dot
- If the lowercase English letter is neither `i` nor `j`: 0 dots

Find the sum of the numbers of dots over all characters in **S**.

### Constraints
- **S** is a string consisting of lowercase English letters with length between 1 and 10, inclusive.

### Input
The input is given from Standard Input in the following format:
```csharp
S
```

### Output
Print the answer.

### Sample Input 1
```csharp
aiiaj
```

### Sample Output 1
```csharp
3
```
The numbers of dots in `a`, `i`, `i`, `a`, `j` are 0, 1, 1, 0, 1, respectively.  
We have 0 + 1 + 1 + 0 + 1 = 3, so print 3.

### Sample Input 2
```csharp
abcedfgh
```

### Sample Output 2
```csharp
0
```

### Sample Input 3
```csharp
jjjjjj
```

### Sample Output 3
```csharp
6
```

