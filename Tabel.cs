using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTracker
{
    class Tabel
    {
        private static string StringFormat(DateTime a)
        {
            string final = "";
            int sec = a.Second;
            if(sec < 10)
                final += "0" + sec + ":";
            else
                final += sec + ":";


            int mil = a.Millisecond;
                if(mil < 100)
                    final += mil + "0";
                else if(mil < 10)
                    final += mil + "00";
                else
                    final += mil;
            return final; 
        }

        private static float ProcentFormat(long a, long b)
        {
            DateTime DTa = new DateTime(a);
            DateTime DTb = new DateTime(b);

            double A = Double.Parse(DTa.Second + "," + DTa.Millisecond);
            double B = Double.Parse(DTb.Second + "," + DTb.Millisecond);

            float result = (float)(B / A) * 100;
            if (A < B)
                return (float)Math.Round((100 - result) * -1, 2);
            return (float)Math.Round((100 - result), 2);
        }


        public static void print(int count)
        {
            long bubbleTime = Timer.getTimeBubble(count);

            string splitter2 = "---------------------------------";
            string splitter1 = "----------        ---------------";

            Console.WriteLine("Algorithm| Amount| Time (sec)");
            Console.WriteLine(splitter2);
            
            //Selection
            long time = Timer.getTimeSelection(count);
            DateTime printTime = new DateTime(time);
            Console.WriteLine("Selection|       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime,time)  + "% ");
            Console.WriteLine(splitter1);

            //Insertion
            time = Timer.getTimeInsertion(count);
            printTime = new DateTime(time);
            Console.WriteLine("Insertion|       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime,time) + "% ");
            Console.WriteLine(splitter1);

            //Merge
            time = Timer.getTimeInsertion(count);
            printTime = new DateTime(time);
            Console.WriteLine("Merge    |       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime,time) + "% ");
            Console.WriteLine(splitter1);

            //Bubble
            time = Timer.getTimeInsertion(count);
            printTime = new DateTime(bubbleTime);
            Console.WriteLine("Bubble   | "+ count +" | " + StringFormat(printTime) + " |  ");
            Console.WriteLine(splitter1);

            //Quick
            time = Timer.getTimeQuick(count);
            printTime = new DateTime(time);
            Console.WriteLine("Quick    |       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime, time) + "% ");
            Console.WriteLine(splitter1);

            //Heap
            time = Timer.getTimeHeap(count);
            printTime = new DateTime(time);
            Console.WriteLine("Heap     |       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime, time) + "% ");
            Console.WriteLine(splitter1);

            //Radix
            time = Timer.getTimeHeap(count);
            printTime = new DateTime(time);
            Console.WriteLine("Radix    |       | " + StringFormat(printTime) + " | " + ProcentFormat(bubbleTime, time) + "% ");
            Console.WriteLine(splitter2);






















        }


    }
}
