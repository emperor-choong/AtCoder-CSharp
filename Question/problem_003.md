# A - First Contest of the Year
## AtCoder Beginner Contest 438

### Problem Statement
On a certain planet, a year has ***D*** days, and contests are held every **7** days. Contests never span across days.

The first contest of a certain year was held on the ***F***-th day of the year. On what day of the next year will the first contest of the next year be held?

The constraints of this problem guarantee that at least one contest will be held in the next year.

### Constraints
- 10 ≤ D ≤ 366
- 1 ≤ F ≤ 7
- All input values are integers.

### Input
The input is given from Standard Input in the following format:
```csharp
D F
```

### Output
Print the integer ***N*** such that the next contest is held on the ***N***-th day of the year.

### Sample Input 1
```csharp
365 4
```

### Sample Output 1
```csharp
3
```
If the first contest of a certain year was held on the **4**th day of the year, the first contest of the next year will be held on the **3**rd day of the year.

### Sample Input 2
```csharp
10 5
```

### Sample Output 2
```csharp
2
```