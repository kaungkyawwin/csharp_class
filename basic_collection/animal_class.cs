using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    internal class animal_class
    {
        string cat = "myou";
        string dog = "wote";
        string cow = "moo";
        //get set
        public string cat_getter()
        {
            return cat;
        }
        public string dog_getter()
        {
            return dog;
        }
        public string cow_getter()
        {
            return cow;
        }

        public void cow_setter(string sound)
        {
            cat = sound;

        }

        public void cat_setter(string sound)
        {
            cat = sound;
        }

        public void dog_setter(string sound)
        {
            dog = sound;
        }

        public animal_class() 
        {
            MessageBox.Show("default constructot");
        }

        public animal_class(string bird)
        {
            MessageBox.Show("bird");
        }

        public animal_class(string name, int age, string nrc, string dob, string address) 
        { 
                    
        }
    }
}
