using System;
using System.Threading;

public class MyThreadClass
{
    public static void Thread1()
    {
        for (int loopCount = 0; loopCount <= 5; loopCount++) 
        {
            Thread thread = Thread.CurrentThread;  
            Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);

            
            Thread.Sleep(1500);
        }
    }
}
