class Program
{
    static void Main(string[] args)
    {
        BinaryHeap heap = new();
        heap.Heapify([5, 10, 30, 20, 35, 40, 15], 6);
        // int[] a = heap.CreateHeap();
        // heap.Delete(a, 3);
    }
}