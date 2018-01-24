using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SortingTracker
{
    //public delegate void TimeSort(Sort<T>.sort sort, int count);

    class Timer
    {

        public static long getTimeBubble(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Bubble(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }

        public static long getTimeSelection(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Selection(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }


        public static long getTimeInsertion(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Insertion(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }

        public static long getTimeMerge(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Merge(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }


        public static long getTimeQuick(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Quick(array, Sort<int>.Acs);
            stopWatch.Stop();

            return stopWatch.Elapsed.Ticks;
        }



        public static long getTimeHeap(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Heap(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }


        public static long getTimeRadix(int count)
        {
            int[] array = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort<int>.Radix(array, Sort<int>.Acs);
            stopWatch.Stop();
            DateTime dif = new DateTime(stopWatch.Elapsed.Ticks);
            return stopWatch.Elapsed.Ticks;
        }





    }
}
