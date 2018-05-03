using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
	public class TestSimulator
	{
		private Actuator _actuator;
		private TorqueCell _torqueCell;
		private Specimen _specimen;

		public TestSimulator(int maxTorque, int minTorque, int cycleCount, decimal shaftStiffness)
		{
			MinimumTorque = maxTorque;
			MaximumTorque = minTorque;
			CycleCount = cycleCount;

			_actuator = new Actuator(RotationalSpeed);
			_torqueCell = new TorqueCell();
			_specimen = new Specimen(shaftStiffness);
		}

		public int RotationalSpeed { get; set; } = 1;
		public int MinimumTorque { get; set; }
		public int MaximumTorque { get; set; }
		public int CycleCount { get; set; }
		public decimal ShaftStiffness { get; set; }

		public double CurrentAngle { get; set; }
		public int CurrentTorque { get; set; }
		public int CompletedCycles { get; set; }
		
		public void Start()
		{
		}

		private double GetAngle(long timeSinceStart)
		{
		}
	}
}
