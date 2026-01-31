# A - Black Square
## AtCoder Beginner Contest 441

### Problem Statement
There is a grid with $10^{100}$ rows and $10^{100}$ columns.  
In what follows, the cell at the i-th row from the top and j-th column from the left is denoted as cell (i, j).

In this grid, only the 100 x 100 region with cell (P, Q) as the top-left cell is painted black, and all other cells are painted white.  
Determine whether cell (X, Y) is painted black.

### Constraints
- 1 ≤ P, Q, X, Y ≤ 10000
- P, Q, X, Y are integers.

### Input
The input is given from Standard Input in the following format:
```csharp
P Q
X Y
```

### Output
If cell (X, Y) is painted black, print **Yes**; otherwise, print **No**.

### Sample Input 1
```csharp
3 3
5 10
```

### Sample Output 1
```csharp
Yes
```
The 100 x 100 region with cell (3, 3) as the top-left cell is painted black.  
Cell (5, 10) is included in this region, so print **Yes**.

### Sample Input 2
```csharp
5 5
10 1000
```

### Sample Output 2
```csharp
No
```
The 100 x 100 region with cell (5, 5) as the top-left cell is painted black.  
Cell (10, 1000) is not included in this region, so print **No**.

### Sample Input 3
```csharp
1 2
1 1
```

### Sample Output 3
```csharp
No
```
The 100 x 100 region with cell (1, 2) as the top-left cell is painted black.  
Cell (1, 1) is not included in this region, so print **No**.


