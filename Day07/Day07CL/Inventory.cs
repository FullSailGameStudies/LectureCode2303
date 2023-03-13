using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        #region Fields (the data/variables)
        private int _capacity = 0;
        #endregion

        #region Properties
        //a full property.
        public int Capacity //_capacity is the backing field of this property
        {
            //accessor
            //same as...
            //public int GetCapacity() {return _capacity;}
            get
            {
                return _capacity;
            }

            //mutator
            //same as...
            //public void SetCapacity(int value) {_capacity = value;}
            set
            {
                if(value > 0 && value < 100)
                    _capacity = value;
            }

        }

        public int Count
        {
            get { return Items.Count; }
        }

        //auto-prop. the compiler will provide the backing field
        public List<string> Items { get; private set; } = new List<string>();
        #endregion

        #region Constructors (ctor)
        //public Inventory()//default ctor: no parameters
        //{
        //    _capacity = 10;
        //}

        public Inventory(int capacity = 10) 
        {
            //capacity = Capacity;//BACKWARDS!
            Capacity = capacity;
        }
        #endregion

        void DoIt(int cap)
        {
            int capacity = _capacity;
            Console.WriteLine($"{cap} {capacity}");
        }
    }
}
