using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Classes
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int AmountOfGasoline);
    }

    class Car : IVehicle
    {
        public int AmountOfGasoline { get; set; }
        public Car(int amountOfGasoline)
        {
            AmountOfGasoline = amountOfGasoline;
        }

        public void Drive()
        {
            Console.WriteLine("That The Car Is Driving.");
        }

        public bool Refuel(int AmountOfGasoline)
        {
            if(AmountOfGasoline > 0)
            {
                AmountOfGasoline += AmountOfGasoline;
                return true;
            }else
            {
                return false;
            }
        }
    }
}
