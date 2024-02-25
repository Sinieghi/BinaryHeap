//Max heap means all elements is bigger than their children
class BinaryHeap
{
    public int[] CreateHeap()
    {
        //O(nlogn)
        int[] a = [0, 10, 20, 30, 25, 5, 40, 35];
        Insert(a, a.Length - 1);
        return a;
    }
    public void Heapify(int[] a, int n)
    {
        // # of leaf elements: (n+1)/2, index of last leaf element's parent = (n/2)-1
        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            int j = 2 * i + 1; //left child for current i
            while (j <= n - 1)
            {
                //compare left and right children of current i
                if (a[j] < a[j + 1]) j++;
                //compare parent and largest child
                if (a[i] < a[j])
                {
                    swap(a, i, j);
                    i = j;
                    j = 2 * i + 1;
                }
                else break;
            }
        }
    }
    public void Insert(int[] A, int n)
    {
        //O(log₂n)
        int temp, i = n;
        temp = A[n];
        while (i > 1 && temp > A[i / 2])
        {
            A[i] = A[i / 2];
            i /= 2;
        }
        A[i] = temp;
    }

    public int Delete(int[] A, int n)
    {
        //O(nlogn)
        int i, j, x, temp, val;
        val = A[1];
        x = A[n];
        A[1] = A[n];
        A[n] = val;
        i = 1; j = i * 2;
        while (j <= n - 1)
        {
            if (j < n - 1 && A[j + 1] > A[j])
                j++;
            if (A[i] < A[j])
            {
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i = j;
                j = 2 * j;
            }
            else
                break;
        }
        return val;
    }

    void swap(int[] A, int i, int j)
    {
        (A[j], A[i]) = (A[i], A[j]);
    }

}