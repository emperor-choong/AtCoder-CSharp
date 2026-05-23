# A - Seats 2
## AtCoder Beginner Contest 447

### Problem Statement
There are **N** seats arranged in a row. Each seat can accommodate at most one person. Determine whether it is possible to seat **M** people in the seats satisfying the following condition.
- No two adjacent seats may both be occupied.

### Constraints
- 1 ≤ N,M ≤ 100
- All input values are integers.

### Input
The input is given from Standard Input in the following format:
```csharp
N M
```

### Output
Output **Yes** if it is possible to seat the people satisfying the condition, and **No** otherwise.

### Sample Input 1
```csharp
6 3
```

### Sample Output 1
```csharp
Yes
```
For example, seating people in the first, third, and sixth seats from the left is one valid way. Thus, output **Yes**.

### Sample Input 2
```csharp
4 3
```

### Sample Output 2
```csharp
No
```
There is no valid way to seat the people satisfying the condition. Thus, output **No**.

### Sample Input 3
```csharp
5 3
```

### Sample Output 3
```csharp
Yes
```

### Sample Input 4
```csharp
44 7
```

### Sample Output 4
```csharp
Yes
```

