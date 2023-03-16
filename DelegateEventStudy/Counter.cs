using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventStudy
{
    public class Counter
    {
        private int total;
        private int threshold;

        public Counter()
        {
            total = 0;
            threshold = 20;
        }

        public void Add(int a)
        {
            total = total + a;
            if(total>threshold)
            {
                //Fire Event
                EventHandler handler = ThresholdReached;
                if(handler!=null)
                {
                    MyEventArgs obj = new MyEventArgs();
                    obj.TotalValue = 100;
                    handler(this,obj);
                }
            }
        }

        //[access_modifier] Event [delegate] eventname
        public event EventHandler ThresholdReached;
        
        /*
        public void OnThresholdReached()
        {
            
        }
        */

    }

    public class MyEventArgs : EventArgs
    {
        public int TotalValue;
    }
}
