using System;
namespace CopyConstructor
{  // C# program demonstrating how to use the  copy constructor
    // Class
    public class User
    {
        //Instance variables
        public int Id;
        public string Name;

        // Parameterized Constructor
        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //Copy Constructor
        public User(User previousUser)
        {
            this.Id = previousUser.Id;
            this.Name = previousUser.Name;
        }
        
        //Print person details
        public void PrintDetail()
        {
            Console.WriteLine($"Id: {Id} Name: {Name}");
        }
    }
    class Program
    {
        static void Maintest(string[] args)
        {

            // This will invoke instance constructor
            User user1 = new User(10, "Shekh Ali");

            //1000==>user1,user2
            //2000==>user2 
            //deep copy
           // User user2 = user1;
            // This will invoke copy constructor
            // Creating another User object by copying user1
            User user2 = new User(user1);

            // Change user2 Id and Name
            user2.Id = 20;
            user2.Name = "Klara";
            //Shallow copy 
            // Print details to verify that the 
            // Id and Name fields are unique.
            user1.PrintDetail();
            user2.PrintDetail();
            Console.ReadLine();
        }
    }
    /* Output:
     Id: 10 Name: Shekh Ali
     Id: 20 Name: Klara
 
     */
}