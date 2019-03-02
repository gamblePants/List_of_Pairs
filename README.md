# List of Pairs

A simple exercise: Given a list of integers and an integer(k), write a program which splits the list in to pairs, and checks each pair to see how many of them equal k.

## Purpose

For educational purposes (mainly my own). An exercise using lists, arrays and for-loops. This is an example of a question I have seen in a programming interview. There are different ways of solving this question, in this case it is solved with 2 for-loops.

## How to run program

<ul>
  <li>The easiest way is to run the program online from DonNetFiddle: https://dotnetfiddle.net/O16f2C</li>
  <li>Alternatively click on the "release" tab, download the "Source code" zipped folder and extract</li>
  <li>The List_of_Pairs.sln file will need to be run in an IDE that can compile in C# (like Visual Studio)</li>
</ul>

## Example data

Given the list of (1, 3, 5, 7, 9), and the integer k = 2, the program should return 4.
(There are 4 pairs in the list where the difference equals 2). 

## Example code

```C#
static int PairDifference(List<int> numbers, int k)
{
	int answer = 0;
	List<int[]> pairs = new List<int[]>();
	for (int i = 0; i < numbers.Count - 1; i++)
	{
		pairs.Add(new[]{numbers[i], numbers[i + 1]});
	}

	for (int i = 0; i < pairs.Count; i++)
	{
		if (pairs[i][1] - pairs[i][0] == k)
		{
			answer += 1;
		}
	}

	return answer;
}
```

