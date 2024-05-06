int[] array = { 1, 4, 5, 9, 10 };
var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    int index = random.Next(array.Length);
    int v = array[index];
    array[index] = array[i];
    array[i] = v;
}

foreach (var v in array)

{
    Console.WriteLine(v);
}


//List<int> list = new List<int>();
//list.Add(19);
//list.Add(10);
//int i = list[0] + list[1];
////Console.WriteLine(i);
//list.RemoveAt(0);

//int[] array = { 1, 4, 5, 9, 10 };
//List<int> arrayList = array.ToList();
//int[] shuffled = new int[5];
//var random = new Random();
//for (i = 0; i < 5; i++)
//{
//    int index = random.Next(arrayList.Count);
//    shuffled[i] = arrayList[index];
//    arrayList.RemoveAt(index);
//}

//foreach (var v in shuffled )
//{
//    Console.WriteLine(v);
//}

//using System.Collections;

//ArrayList arrayList = new ArrayList();
//arrayList.Add(10);
//arrayList.Add(1);
////Console.WriteLine(arrayList.Count);
//arrayList.Add(3);
////Console.WriteLine(arrayList.Count);
//foreach (int i in arrayList)
//    Console.WriteLine(i);

//int[] m = new int[10];

//int[] i = { 10, 20 };
//i[0] = 1;
//i[1] = 2;

//Array.Clear(m, 0, 10);
//m[0] = 0;
//m[5] = 1;
//m[3] = -9;
//Array.Sort(m);
//int myd = Array.BinarySearch(m, 1);


//Console.WriteLine(myd);

//for (int i = 0; i < m.Length; i++)
//{
//    Console.WriteLine(m[i]);

//}


//int[][] m = new int[10][];
//m[0] = new int[5];
//m[1] = new int[2];

//m[1][4] = 10;