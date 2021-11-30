using System;

    class Program
    {
    static void Main(string[] args)
        {
            int[] arr = new int[100];
            Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(0, 100);
        }
        var coppyarr = (int[])(arr);
        BubbleSort(arr);

        //return my arr from copy one.

        arr = (int[])coppyarr.Clone();
        SelectionSort(arr);

        Console.ReadKey();

        }

    public static void BubbleSort(int[]arr)
    {
        var time = DateTime.Now;
        int temp = 0;
        for (int i = 0; i < arr.Length -1; i++)
        {
            for (int j = 0; j < arr.Length -i -1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    temp = arr[j + 1];
                }
            }
        }
        var totaltime = DateTime.Now - time;
        printdata(arr, totaltime, "Buble Sort");

    }

    public static void SelectionSort(int[]arr)
    {
        int smallest, temp;
        var time = DateTime.Now;
        for (int i = 0; i < arr.Length; i++)
        {
            smallest = 1;
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }
        var totaltime = DateTime.Now - time;
        printdata(arr, totaltime, "Selection Sort");

    }

    public static void InsertionSort(int[]arr)
    {

    }


    static void printdata(int[] arr, TimeSpan totaltime, string name)
    {
        foreach (var item in arr)
          Console.WriteLine();
          Console.WriteLine(string.Concat(name, " ", totaltime.TotalMilliseconds));
          Console.WriteLine();
    }


    }
