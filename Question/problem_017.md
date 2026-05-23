# A - Trimo
## AtCoder Beginner Contest 453

### Problem Statement
You are given a string **S** of length **N**.  
Output the string obtained by removing all leading consecutive **o**s from **S**.  
If all characters in **S** are **o**, output an empty string.

### Constraints
- **N** is an integer satisfying **1 ≤ N ≤ 50**.
- **S** is a string of length **N** consisting of lowercase English letters.

### Input
The input is given from Standard Input in the following format:
```csharp
N
S
```

### Output
Output the answer.

### Sample Input 1
```csharp
7
ooparts
```

### Sample Output 1
```csharp
parts
``` 
Removing all leading consecutive **o**s from **ooparts** gives **parts**.

### Sample Input 2
```csharp
6
abcooo
```

### Sample Output 2
```csharp
abcooo
```
The first character may not be **o**.

### Sample Input 3
```csharp
5
ooooo
```

### Sample Output 3
```csharp

```
All characters may be **o**.