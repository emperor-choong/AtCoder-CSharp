# A - Chompers
## AtCoder Beginner Contest 458

### Problem Statement
You are given a string **S** consisting of lowercase English letters and a positive integer **N**. The length of **S** is at least **2N + 1**.

Find the string obtained by removing **N** characters from the beginning and **N** characters from the end of **S**.

### Constraints
- **S** is a string consisting of lowercase English letters.
- **N** is an integer.
- **2N + 1 ≤ |S| ≤ 30**
- **1 ≤ N ≤ 10**

### Input
The input is given from Standard Input in the following format:

```csharp
S
N
```

### Output
Output the answer.

### Sample Input 1
```csharp
chemotherapy
3
```

### Sample Output 1
```csharp
mother
```
Removing the first three characters (**che**) and the last three characters (**apy**) from **chemotherapy** gives **mother**.

### Sample Input 2
```csharp
thermometer
4
```

### Sample Output 2
```csharp
mom
```

### Sample Input 3
```csharp
burger
1
```

### Sample Output 3
```csharp
urge
```