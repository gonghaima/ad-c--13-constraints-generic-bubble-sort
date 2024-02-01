namespace GenericBubbleSortApplication;

class Program
{
    static void Main(string[] args)
    {
        object[] arr = new object[] { 2, 1, 4, 3 };

        SortArray sortArray = new SortArray();

        sortArray.BubbleSort(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}

public class SortArray
{
    public void BubbleSort(object[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n - i -1; j++)
            {
                if (((IComparable)arr[j]).CompareTo(arr[j+1])>0)
                {
                    Swap(arr, j);
                }
            }
        }
    }

    private void Swap(object[] arr, int j)
    {
        object temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
    }
}


