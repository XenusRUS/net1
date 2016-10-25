using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net1
{

	public class body
	{
		public void bodyOutput()
		{
			Console.WriteLine("Корпус");
		}
	}
	public class track
	{
		public void trackOutput()
		{
			Console.WriteLine("Гусеница");
		}
	}
	public class tower
	{
		public void towerOutput()
		{
			Console.WriteLine("Башня");
		}
	}
	public class engine
	{
		public void engineOutput()
		{
			Console.WriteLine("Двигатель");
		}
	}
	public class transmission
	{
		public void transmissionOutput()
		{
			Console.WriteLine("Трансмиссия");
		}
	}
	public class weaponary
	{
		public void weaponaryOutput()
		{
			Console.WriteLine("Вооружение");
		}
	}
	public class communication
	{
		public void communicationOutput()
		{
			Console.WriteLine("Средства связи");
		}
	}
	public class surveillance
	{
		public void surveillanceOutput()
		{
			Console.WriteLine("Средства наблюдения");
		}
	}
	public abstract class crew
	{
		public void crewOutput()
		{
			Console.WriteLine("Экипаж: 5 человек");
		}
		abstract public void weaponsNumber();
	}

	public class Weapons : crew
	{
		public override void weaponsNumber()
		{
			Console.WriteLine("Количество вооружения: 2");
		}
	}

	class aboutTank
	{
		int crewNumber = 5;
		string tankName = "Tiger";
		public int crewNum
		{
			get
			{
				if (crewNumber <= 0)
					return 1;
				return crewNumber;
			}

			set
			{
				crewNumber = value;
			}
		}
		public string Name
		{
			get
			{
				return tankName;
			}
		}
	}

	public class Tank
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Данные о танке:");
			body status1 = new body();
			status1.bodyOutput();
			track status2 = new track();
			status2.trackOutput();
			tower status3 = new tower();
			status3.towerOutput();
			engine status4 = new engine();
			status4.engineOutput();
			transmission status5 = new transmission();
			status5.transmissionOutput();
			weaponary status6 = new weaponary();
			status6.weaponaryOutput();
			communication status7 = new communication();
			status7.communicationOutput();
			surveillance status8 = new surveillance();
			status8.surveillanceOutput();
			Weapons status9 = new Weapons();
			status9.crewOutput();
			status9.weaponsNumber();

			aboutTank ui = new aboutTank();
			Console.WriteLine("Экипаж танка:");
			Console.WriteLine(ui.crewNum);
			Console.WriteLine("Танк:");
			Console.WriteLine(ui.Name);
			Console.ReadLine();
		}
	}
}