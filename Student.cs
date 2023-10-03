using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2023._10._03
{
	internal class Student : Person
	{
		private string previousOrganization;
		private int skippedDays;

		public Student(string previousOrganization, int skippedDays, string name, int age, string gender) : base(name,age,gender)
		{
			this.PreviousOrganization = previousOrganization;
			this.SkippedDays = skippedDays;
		}

		public Student()
		{
			previousOrganization = "The school of life";
			skippedDays = 0;
		}

		public string PreviousOrganization { get => previousOrganization; set => previousOrganization = value; }
		public int SkippedDays { get => skippedDays; set => skippedDays = value; }

		public override string getGoal()
		{
			return "Be a junior software developer.";
		}

		public override string introduce()
		{
			return $"{base.introduce()} from {this.previousOrganization} who {this.skippedDays} days from the course already.";
		}
	}
}
