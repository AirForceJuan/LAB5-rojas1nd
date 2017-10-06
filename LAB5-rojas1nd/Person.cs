using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_rojas1nd
{
    /// <summary>
    /// This is a person Class
    /// Program starts out with creating getters and setters.
    /// 
    /// </summary>

    class Person
    {
        //getter for BMI
        public double BMI
        {
            get
            {
                return calcBMI();
            }
        }
        //getter and setter for age.
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0) //makes sure value is greater than zero
                    age = value;
            }
        }
        //getter and setter for weight.
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        //gettter and setter for height.
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                    height = value;
            }
        }
        //gettter and setter for First Name.
        private string fname;
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        //getter and setter for Last Name.
        private string lname;
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        //prints out Person in a readable manner.
        public void Print()
        {
            Console.WriteLine("Hello " + Fname + " " + Lname + ", your age is " + Age + " years old " + ",you weigh " + Weight + " KG" + ", and stand "+ Height + " meters tall.");
            Console.WriteLine("Your BMI is " + string.Format("{0:0.00}", BMI));
        }

        
        // default costructor for Person.
        public Person(){}


        //parameterized Constructor for Person. 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lname">First name of Person</param>
        /// <param name="fname">Last name of Person</param>
        /// <param name="age">Age of Person</param>
        public Person(string lname, string fname, int age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }


        //BMI calculator.
        public double calcBMI() => weight / Math.Pow(height, 2);
    }

    
}
