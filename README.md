# List of Pairs

Given a list of integers and an integer(k), write a program which splits the list in to pairs, and checks each pair to see how many of them equal k.

## Purpose

For educational purposes (mainly my own). An exercise using lists, arrays and for-loops. This is an example of a question I have seen in a programming interview. Solved with 2 for-loops.

## How to run program

- The easiest way is to run the program online from DonNetFiddle: https://dotnetfiddle.net/O16f2C
- Alternatively go to the [Release](https://github.com/gamblePants/List_of_Pairs/releases) page, download the Source code zipped folder and extract
- The List_of_Pairs.sln file will need to be run in an IDE that can compile in C# (like Visual Studio)

## Example data

Given the list of (1, 3, 5, 7, 9), and the integer k = 2, the program should return 4.
(There are 4 pairs in the list where the difference equals 2). 

## Code snippet

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

