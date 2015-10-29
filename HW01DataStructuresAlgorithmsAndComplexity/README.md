## Data Structures, Algorithms and Complexity
### _Homework_

1. What is the expected running time of the following C# code? Explain why.
  - Assume the array's size is `n`.


			long Compute(int[] arr)
			{
			    long count = 0;
			    for (int i=0; i<arr.Length; i++)
			    {
			        int start = 0, end = arr.Length-1;
			        while (start < end)
			            if (arr[start] < arr[end])
			                { start++; count++; }
			            else 
			                end--;
			    }
			    return count;
			}

	*	Answer:
Outer `for-loop` iterates n-times, where n is the input array length.
Inner `while-loop` iterates also n-times, since end variable equals to array length - 1.
The expected running time is **O(g(n)) = O(n<sup>2</sup>)**. The algorithm is **Polynomial**. Complexity is **Quadratic**.



2. What is the expected running time of the following C# code?
  - Explain why.
  - Assume the input matrix has size of n * m.


			long CalcCount(int[,] matrix)
			{
			    long count = 0;
			    for (int row=0; row<matrix.GetLength(0); row++)
			        if (matrix[row, 0] % 2 == 0)
			            for (int col=0; col<matrix.GetLength(1); col++)
			                if (matrix[row,col] > 0)
			                    count++;
			    return count;
			}
**Answer:**
	*	**Worst case**: every member of the matrix is even:
In this case on each of the `n` outer `for-loop` iterations will have `m` inner `for-loop` iterations. So we have `n*m` iterations. We can consider that `n` is approximately equal to `m` and to conclude that algorithm running time will be **O(g(n)) = O(n<sup>2</sup>)**. Complexity will be **Quadratic**.
	*	**Best case**: every member of the matrix is odd:
In this case the inner `for-loop` will have 0 iterations, because the code flow will never enter this loop. Will have `n` iterations of the outer loop, so the algorithm running time will be **O(g(n)) = O(n)**. Complexity will be **Linear**.
	* **Average case**: matrix members are randomly odd or even:
Lets consider the odd members number and the even members number are approximately equal. The inner loop iterations will be approximately `m/2`. Total iterations will be `n * m/2`. The algorithm running time will be **O(g(n)) = O(n<sup>2</sup>)**. Complexity will be **Quadratic**.

3. What is the expected running time of the following C# code?
  - Explain why.
  - Assume the input matrix has size of n * m.
 
			long CalcSum(int[,] matrix, int row)
			{
			    long sum = 0;
			    for (int col = 0; col < matrix.GetLength(0); col++) 
			        sum += matrix[row, col];
			    if (row + 1 < matrix.GetLength(1)) 
			        sum += CalcSum(matrix, row + 1);
			    return sum;
			}
			
			Console.WriteLine(CalcSum(matrix, 0));
	* **Answer:**

Constraints: This algorithm works when n = m(else throws `Index out of range exception`) and when `row <= m - 1`.

The `for-loop` will iterates `n` times. If the condition `row + 1 < matrix.GetLength(1)` is `true` the same method will be recursively called again.

The **worst case** is when `row < m - 1`. Then total 
iterations will be `n * n`. The algorithm running time will be **O(g(n)) = O(n<sup>2</sup>)**. Complexity will be **Quadratic**.

The **best case** is when `row = m - 1`. Then total 
iterations will be `n`. The algorithm running time will be **O(g(n)) = O(n)**. Complexity will be **Linear**.
