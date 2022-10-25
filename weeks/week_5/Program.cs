using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week5;

public class Program
{
	/*
	public static void Main()
	{
		var act01 = ResultSets.Action01();
		Console.WriteLine($"{act01.Status,-5}" +
			$"{act01.Message,5}");
		var act02 = ResultSets.Action02();
		Console.WriteLine($"{act02.Status,-5}" +
			$"{act02.Message,5}");
		var act03 = ResultSets.Action03();
		Console.WriteLine($"{act03.Status,-5}" +
			$"{act03.Message,5}");
		var act04 = ResultSets.Action04();
		Console.WriteLine($"{act04.Status,-5}" +
			$"{act04.Message,5}");
	}
	*/
	public static void Main()
	{
		MinHeap minheap = new MinHeap();
		MaxHeap maxheap = new MaxHeap();
		minheap.Insert(1);
		minheap.Insert(3);
		minheap.Insert(2);
		minheap.Insert(5);
		minheap.Insert(4);
		minheap.Insert(6);
		Console.WriteLine($"{minheap.Extract()}");
		Console.WriteLine($"{minheap.Extract()}");
		Console.WriteLine($"{minheap.Extract()}");
		Console.WriteLine($"{minheap.Extract()}");
		Console.WriteLine($"{minheap.Extract()}");
		Console.WriteLine($"{minheap.Extract()}");
	}
}
