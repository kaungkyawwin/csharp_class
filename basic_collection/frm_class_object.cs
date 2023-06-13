using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class frm_class_object : Form
    {
        public frm_class_object()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string number1 = "212";
            //int num1_index = number1.Length - 1;
            //MessageBox.Show($"{number1[num1_index]}");

            string number2 = "1253";
            int num2_index = number2.Length - 1;
            MessageBox.Show($"{number2[num2_index]}");

            //class object
            //animal animal_sound = new animal();
            //MessageBox.Show(animal_sound.cat);

            //animal animal_music= new animal();
            //MessageBox.Show(animal_music.dog);

            //animal animal_sound1 = new animal();
            //MessageBox.Show(animal_sound1.cat);

            animal_class animal_sound = new animal_class();
            animal_sound.cow_setter("moo moo");
            animal_sound.cat_setter("myou myou");
            animal_sound.dog_setter("wote wote");
            MessageBox.Show(animal_sound.cat_getter());
            MessageBox.Show(animal_sound.dog_getter());
            MessageBox.Show(animal_sound.cow_getter());
            animal_class bird_sound = new animal_class("lajg");
        }

    }

    }
    

    //user create class
    
    
       

    



