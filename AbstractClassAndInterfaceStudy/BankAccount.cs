using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterfaceStudy
{
    //What is Abstract Class?
    //An Abstract Class is a special class which 
    //1)It has abstract functions i.e. Functions with only declaration and no defination
    //2) It can have non-abstract functions also
    //3) We cannot create object of abstract class.
    //4) We have to inherit Abstract class, give proper defination to abstract function and
        //then we can create object of the inherited class.
    internal abstract class BankAccount
    {
        public abstract void Credit();
        public void Debit()
        {
            Console.WriteLine("Account Debited.");

        }
         
    }

    internal class SavingAccount : BankAccount
    {
        public override void Credit()
        {
            Console.WriteLine("Account Credited.");
        }
    }

    internal interface IVehicle
    {
        public void Start();
        public void Stop();
    }

    internal interface IChild : IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped.");
        }
    }

}
