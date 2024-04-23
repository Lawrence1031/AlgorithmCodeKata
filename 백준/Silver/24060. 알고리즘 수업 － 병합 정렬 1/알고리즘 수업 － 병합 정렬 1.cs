namespace _24060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            int[] arr = new int[A];
            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < A; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            MergeSortTracker tracker = new MergeSortTracker(K);
            tracker.MergeSort(arr, 0, arr.Length - 1);

            if (tracker.GetSaveCnt() < K)
            {
                Console.WriteLine("-1");
            }
        }
    }

    class MergeSortTracker
    {
        private int[] tmp;
        private int saveCnt;
        private int k;

        public MergeSortTracker(int k)
        {
            this.k = k;
            saveCnt = 0;
        }

        public void MergeSort(int[] Array, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(Array, p, q);
                MergeSort(Array, q + 1, r);
                Merge(Array, p, q, r);
            }
        }

        private void Merge(int[] Array, int p, int q, int r)
        {
            int i = p;
            int j = q + 1;
            int t = 0;
            tmp = new int[r - p + 1];

            while (i <= q && j <= r)
            {
                if (Array[i] <= Array[j]) tmp[t++] = Array[i++];
                else tmp[t++] = Array[j++];
            }

            while (i <= q)
                tmp[t++] = Array[i++];

            while (j <= r)
                tmp[t++] = Array[j++];

            for (int idx = 0; idx < tmp.Length; idx++)
            {
                Array[p + idx] = tmp[idx];
                saveCnt++;
                if (saveCnt == k)
                {
                    Console.WriteLine(tmp[idx]);
                    return;
                }
            }
        }

        public int GetSaveCnt()
        {
            return saveCnt;
        }
    }
}