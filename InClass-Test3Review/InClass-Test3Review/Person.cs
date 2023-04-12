using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test3Review
{
    public class Person : ICompare
    {
        public string Name { get; set; }

		private int _age;
		public int Age
		{
			get { return _age; }
			set 
			{
                //in driver:
                //Person p = new Person();
                //p.Age = -1;
                //C.W(p.Age);

                if (value < 0)
				{
					//That is invalid
					throw new AgeException("Age cannot be negative.");
				}
				else
				{
                    _age = value;
                }
			}
		}

		public int CompareTo(object obj)
		{
			//People are compared by their names alphabetically
			//choice made by programmer
			if(obj is Person)
			{
				return Name.CompareTo(((Person)obj).Name);
            }
			else
			{
				throw new Exception($"Cannot compare a Person to an object of type {obj.GetType()}");
			}	
		}
	}
}
