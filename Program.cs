using System;
					
double[,] create2DDoubleArray(int rows, int cols) {
	double[,] array = new Double[rows, cols];  
	Random rnd = new Random();
	for (int i = 0; i < rows * cols; i++)
	{
		array[i / cols, i % cols] = Math.Round(rnd.NextDouble(), 2);
	}
	return array;
}

int[,] create2DIntArray(int rows, int cols) {
	Random rnd = new Random();    
	int[,] array = new int[rows, cols];
	for (int i = 0; i < rows * cols; i++)
	{
		array[i / cols , i % cols] = rnd.Next(1, 10);
	}
	return array;
}

void show2DIntArray(int[,] array)
{
	Console.WriteLine("My 2D int array:");
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + "\t");
		}
		Console.WriteLine();
	}
}

void show2DDoubleArray(double[,] array)
{
	Console.WriteLine("My 2D double array:");
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i,j] + "\t");
		}
		Console.WriteLine();
	}
}

void findElement(int[,] array, int row, int col)
{
	if (row < array.GetLength(0) && col < array.GetLength(1)) 
		Console.WriteLine(array[row, col]);
	else 
		Console.WriteLine($"{row},{col} -> there is no such number in this array");
}

void avgCols(int[,] array) {
    int i, j;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
	double[] count = new Double[cols];
	double[] sum = new Double[cols];
	double avg = new Double();
	
	for (i = 0; i < rows; i++)
	{
		for (j = 0; j < cols; j++)
		{
			sum[j] += array[i, j];
            count[j]++;
		}
	}
	
	for (i = 0; i < cols; i++)
    {
        avg = (sum[i] + 0.0) / count[i];
        Console.WriteLine("Average of col {0} is {1}", i, avg);
    }
}

// Task 47
// Initialize 2D double array
double[,] my2DDoubleArray = create2DDoubleArray(3, 4);
// Print 2D double array
show2DDoubleArray(my2DDoubleArray);

// Initialize 2D int array
int[,] my2DIntArray = create2DIntArray(3, 4);
// Print 2D int array
show2DIntArray(my2DIntArray);

// Task 50
/*
Console.Write("Enter the row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number: ");
int col = Convert.ToInt32(Console.ReadLine());
*/
int row = 4;
int col = 3;
findElement(my2DIntArray, row, col);

// Task 52
avgCols(my2DIntArray);