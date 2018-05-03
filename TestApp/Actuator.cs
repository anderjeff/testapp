using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	public class Actuator
	{
		public Actuator(decimal speed)
		{
			Speed = speed;
			Angle = 0;
		}

		public decimal Speed { get; private set; }
		public decimal Angle { get; set; }
	}
}
