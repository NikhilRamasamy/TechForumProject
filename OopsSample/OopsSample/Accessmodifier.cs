using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
   public class Car
    {
        private int nooftyres { get; set; }
        private int noofseaat { get; set; }
        protected String name { get; set; }

        private String cartype { get; set; }
        
        
    
      public Car()
        {
            noofseaat = 4;
            nooftyres = 4;
            name = "xyz";
            cartype = "abc";
        }

        public Car(int nooftyres,int noofseaat,string name,string cartype)
        {
            this.nooftyres = nooftyres;

            this.noofseaat = noofseaat;

            this.name = name;

            this.cartype = cartype;

        }

        public void display()
        {
            Console.WriteLine("this is parent class");
        }



    }

    class BMW : Car
    {
        private int engineno;
        private int speed;
        public BMW():base()
        {
            //name = "bmw";
            speed = 250;
            engineno = 24735;
        }

        public BMW(int _nooftyres, int _noofseaat, string _name, string _cartype,int engineno,int speed):base(_nooftyres, _noofseaat, _name, _cartype)
        {
            this.engineno = engineno;

            this.speed = speed;
        }

        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(engineno);
            Console.WriteLine(speed);

        }

        public void childdisplay()
        {
            Console.WriteLine(name);
            Console.WriteLine(engineno);
            Console.WriteLine(speed);

        }


    }


    class Audi : Car
    {
        private int engineno;
        private int speed;
       public Audi()
        {
            name = "Audi";
            speed = 200;
        }
    }
}
