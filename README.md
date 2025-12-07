Problem 1:
You are given a square matrix of size n × n. Write a program to compute the absolute difference between the sum of its primary (left-to-right) diagonal and secondary (right-to-left) diagonal.
Example 1:
Matrix:
11   2   4
 4   5   6
10   8  -12
Primary diagonal sum = 11 + 5 + (–12) = 4
Secondary diagonal sum = 4 + 5 + 10 = 19
Absolute difference = |19 – 4| = 15
Example 2:
Matrix:
10   2
 4   5
Primary diagonal sum = 10 + 5 = 15
Secondary diagonal sum = 2 + 4 = 6
Absolute difference = |15 – 6| = 9
Technical Requirements
•	A matrix element mat[i][i] belongs to the primary diagonal.
•	A matrix element mat[i][n - 1 - i] belongs to the secondary diagonal.
•	Compute both sums and return abs(primarySum − secondarySum).

Problem 2:
Given an n x n matrix. In the given matrix, you have to print the elements of the matrix in the snake pattern.

<img width="626" height="552" alt="image" src="https://github.com/user-attachments/assets/260901c1-ddfa-40c1-9277-3da3875ea87e" />


Examples : 
Input: mat[][] = { {10, 20, 30, 40},
                            {15, 25, 35, 45},
                           {27, 29, 37, 48},
                           {32, 33, 39, 50}};
Output: 10 20 30 40 45 35 25 15 27 29 37 48 50 39 33 32 
 
Problem 3:
Problem:
Given a square matrix of size n × n, write a program to compute its transpose in-place, i.e., without using any additional matrix.
The transpose of a matrix is formed by swapping mat[i][j] with mat[j][i].
Example:
Input:
1  2  3
4  5  6
7  8  9
Output:
1  4  7
2  5  8
3  6  9

 
Problem 4
Print Matrix in Spiral (Circular) Order
Given an m × n matrix, write a program to return all elements of the matrix in spiral (clockwise circular) order, starting from the top-left corner.
Example:
Input:
1   2   3   4
5   6   7   8
9  10  11  12
Output:
1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7
Description:
Traverse the matrix layer by layer:
1.	Left → Right
2.	Top → Bottom
3.	Right → Left
4.	Bottom → Top
Repeat this for all inner layers.
