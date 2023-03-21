// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ThreadingStudy;

#region ThreadBasics
/*
    ThreadLearn tl = new ThreadLearn();
    Thread t1 = new Thread(tl.DoWorkOne);
    t1.Name = "ThreadOne";
    t1.IsBackground = true; //By default Threads are Foreground
    Thread t2 = new Thread(tl.DoWorkTwo);
    t2.Name = "ThreadTwo";
    Thread t3 = new Thread(tl.DoWorkThree);
    t3.Name = "ThreadThree";
    t1.Start();
    t2.Start();
    t3.Start();
*/
    #endregion


    #region ThreadPoolStudy
    
        ThreadPoolExample tpe = new ThreadPoolExample();
    tpe.CreateThreadUsingThreadPool();
#endregion
//tl.DoWorkOne();
//tl.DoWorkTwo();
//tl.DoWorkThree();