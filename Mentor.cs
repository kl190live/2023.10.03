using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._03
{
	internal class Mentor : Person
	{
		private string level;

		public Mentor(string level, string name, int age, string gender) : base(name,age,gender)
		{
			this.Level = level;
		}

		public string Level { get => level; set => level = value; }

		public Mentor()
		{
			this.level = "intermediate";
		}

		public override string getGoal()
		{
			return "Educate brilliant junior software developers.";
		}
		public override string introduce()
		{
			return $"{base.introduce()} {this.level} Mentor";
		}


	}
}
