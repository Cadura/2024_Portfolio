using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_PetClass
{
    internal class pet
    {
        private string _name;
        private string _type;
        private int _age;

        public pet() //constructor
        {
            _name = string.Empty;
            _type = string.Empty;
            _age = 0;
        }

        //accessors
        public string Name //Name property
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


    }
}
