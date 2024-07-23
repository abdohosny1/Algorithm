namespace Merge_Sort;
class Program
{


    static void Main(string[] args)
    {
        int[] array = { 4, 5, 6, 7,8 ,9};
        int key = 5;
        var res= binary_search(array,key);
        if(res)
            Console.WriteLine("found key");
        else
            Console.WriteLine(" not found key");

    }

    public static bool binary_search(int[] array,int key)
    {
        int low=0;
        int high=array.Length-1;
        var res=false;
        while (low <= high) 
        {
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                res= true;
                break;
            }
            else if (key > array[mid])
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return res;

    }
}
