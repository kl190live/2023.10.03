using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._03
{
	internal class Sponsor : Person
	{
		private string company;
		private int hiredStudents;

		public Sponsor(string company, int hiredStudents)
		{
			this.Company = company;
			this.HiredStudents = hiredStudents;
		}

		public string Company { get => company; set => company = value; }
		public int HiredStudents { get => hiredStudents; set => hiredStudents = value; }
	}
}
