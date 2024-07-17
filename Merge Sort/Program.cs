namespace Merge_Sort;
class Program
{

    //merge_sort
    //input ==>array,start ,end
    public static void merge_sort(int[] array,int start,int end)
    {
        //exit if end greatter than start
        if (end <= start) return;
        //calaucalte maid_point
        int mid_point = (end + start) / 2;
        //merge_sort(array,maid_point)
        merge_sort(array, start,mid_point);
        //merge_sort(maid_point+1,end)
        merge_sort(array,mid_point + 1, end);
        //merge(array,start,maid_point,end)
        merge(array, start,mid_point , end);

    }

    //merge
    //input ==> array ,start,mid_point,end
    public static void merge(int[] array, int start, int mid_point, int end)
    {
        int i =0, j=0, k=start;

        int left_length = mid_point - start + 1;
        int right_length = end - mid_point;
        //create two array
        int[] left_array= new int[left_length];
        int[] right_array= new int[right_length];

        for (int ii = 0; ii < left_length; ii++)
        {
            left_array[ii] = array[start + ii];
        }
        for (int jj = 0; jj < right_length; jj++)
        {
            right_array[jj] = array[mid_point+1 + jj];
        }
        // compare and sort

        while (i < left_length && j <right_length)
        {
            if (left_array[i] <= right_array[j])
            {
                array[k] = left_array[i];
                i++;
            }
            else
            {
                array[k] = right_array[j];
                j++;
            }
            k++;
        }
        //move remain item
        while(i < left_length)
        {
            array[k]=left_array[i];
            i++;
            k++;
        }

        while (j < right_length)
        {
            array[k] = right_array[j];
            j++;
            k++;
        }
    }


    static void Main(string[] args)
    {
        int[] array = { 9, 5, 1, 4 };
        Console.WriteLine(string.Join(",",array));
        merge_sort(array,0,array.Length-1);
        Console.WriteLine(string.Join(",", array));

    }
}
