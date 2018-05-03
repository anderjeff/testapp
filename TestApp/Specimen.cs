using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	public class Specimen
	{
		public Specimen(decimal stiffness)
		{
			Stiffness = stiffness;
		}

		/// <summary>
		/// The stiffness in lb-ft/degree
		/// </summary>
		public decimal Stiffness { get; private set; }
	}
}
