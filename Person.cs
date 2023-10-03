using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._03
{
	internal class Person
	{
		private string name;
		private int age;
		private string gender;

		public Person(string name, int age, string gender)
		{
			this.Name = name;
			this.Age = age;
			this.Gender = gender;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Gender { get => gender; set => gender = value; }

		public Person()
		{
			this.name = "Jane Doe";
			this.age = 30;
			this.gender = "female";
		}

		public string getGoal()
		{
			return "My goal is: Live for the moment!";
		}

		public string introduce()
		{
			return $"Hi, I'm {this.name}, a {this.age} year old {this.gender}.";
		}


	}
}
