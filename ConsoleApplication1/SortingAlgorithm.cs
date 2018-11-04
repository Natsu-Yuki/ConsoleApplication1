namespace ConsoleApplication1
{
    public class SortingAlgorithm
    {
        public  void quick_sort(int[] array,int left , int right)
        {
            if(right<=left) return;
            int low = left;
            int hight = right;
            int key = array[low];
            while (left < right)
            {
                while (left < right && array[right] > key) right--;
                array[left] = array[right];
                while (left < right && array[left] <= key) left++;
                array[right] = array[left];
            }

            array[right] = key;
            
            quick_sort(array,low,left-1);
            quick_sort(array, left+1, hight);
        }
    }
}