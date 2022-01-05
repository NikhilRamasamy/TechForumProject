using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    class Pig
    {
    
        
            public virtual void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        
        
    }
    class Pinkpig : Pig
    {
     public override void animalSound()
        {
            Console.WriteLine("I am a Pinkpig");
        }

        public void run()
        {
            Console.WriteLine("Pinkpig can run");
        }
    }
}
