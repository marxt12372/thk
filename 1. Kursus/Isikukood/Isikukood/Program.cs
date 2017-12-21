using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isikukood
{
	class ValeIsikukood : Exception
	{
		public ValeIsikukood()
		{
			Console.WriteLine("Vigane Isikukood");
			Console.ReadKey();
			System.Environment.Exit(-1);
		}
	}

	class Isikukood
	{
		private string _isikukood;

		public Isikukood(string isikukood)
		{
			if (isikukood.Length == 11)
			{
				_isikukood = isikukood;
			}
			else throw new ValeIsikukood();

			if (!this.onOigeKood()) throw new ValeIsikukood();
			this.onKorrektneKood();
		}

		public int synnikuu()
		{
			int kuu = -1;
			kuu = Convert.ToInt32(_isikukood[3] + "" + _isikukood[4]);
			return kuu;
		}

		public string synnikuusona()
		{
			return new DateTime(this.synniaasta(), this.synnikuu(), this.synnipaev()).ToString("MMMM");
		}

		public int synnipaev()
		{
			int paev = -1;
			paev = Convert.ToInt32(_isikukood[5] + "" + _isikukood[6]);
			return paev;
		}

		public int synniaasta()
		{
			int aasta = 1000;
			if (_isikukood[0] == '1') aasta = aasta + 800;
			else if (_isikukood[0] == '2') aasta = aasta + 800;
			else if (_isikukood[0] == '3') aasta = aasta + 900;
			else if (_isikukood[0] == '4') aasta = aasta + 900;
			else if (_isikukood[0] == '5') aasta = aasta + 1000;
			else if (_isikukood[0] == '6') aasta = aasta + 1000;
			aasta = aasta + Convert.ToInt32(_isikukood[1] + "" + _isikukood[2]);
			return aasta;
		}

		public DateTime synnikuupaev()
		{
			DateTime kuupaev = new DateTime(this.synniaasta(), this.synnikuu(), this.synnipaev());
			return kuupaev;
		}

		public bool onOigeKood()
		{
			int kontrollkood = (1 * Convert.ToInt32(_isikukood[0].ToString())) + (2 * Convert.ToInt32(_isikukood[1].ToString())) + (3 * Convert.ToInt32(_isikukood[2].ToString())) + (4 * Convert.ToInt32(_isikukood[3].ToString())) + (5 * Convert.ToInt32(_isikukood[4].ToString())) + (6 * Convert.ToInt32(_isikukood[5].ToString())) + (7 * Convert.ToInt32(_isikukood[6].ToString())) + (8 * Convert.ToInt32(_isikukood[7].ToString())) + (9 * Convert.ToInt32(_isikukood[8].ToString())) + (1 * Convert.ToInt32(_isikukood[9].ToString()));
			int jaak = kontrollkood % 11;
			if (jaak == Convert.ToInt32(_isikukood[10].ToString()))
			{
				return true;
			}
			else if (jaak >= 10)
			{
				kontrollkood = (3 * Convert.ToInt32(_isikukood[0].ToString())) + (4 * Convert.ToInt32(_isikukood[1].ToString())) + (5 * Convert.ToInt32(_isikukood[2].ToString())) + (6 * Convert.ToInt32(_isikukood[3].ToString())) + (7 * Convert.ToInt32(_isikukood[4].ToString())) + (8 * Convert.ToInt32(_isikukood[5].ToString())) + (9 * Convert.ToInt32(_isikukood[6].ToString())) + (1 * Convert.ToInt32(_isikukood[7].ToString())) + (2 * Convert.ToInt32(_isikukood[8].ToString())) + (3 * Convert.ToInt32(_isikukood[9].ToString()));
				jaak = kontrollkood % 11;
				if (jaak == Convert.ToInt32(_isikukood[10].ToString()))
				{
					return true;
				}
			}
			return false;
		}

		public static int arvutaKontroll(string kood)
		{
			int kontrollkood = (1 * Convert.ToInt32(kood[0].ToString())) + (2 * Convert.ToInt32(kood[1].ToString())) + (3 * Convert.ToInt32(kood[2].ToString())) + (4 * Convert.ToInt32(kood[3].ToString())) + (5 * Convert.ToInt32(kood[4].ToString())) + (6 * Convert.ToInt32(kood[5].ToString())) + (7 * Convert.ToInt32(kood[6].ToString())) + (8 * Convert.ToInt32(kood[7].ToString())) + (9 * Convert.ToInt32(kood[8].ToString())) + (1 * Convert.ToInt32(kood[9].ToString()));
			int jaak = kontrollkood % 11;
			if (jaak < 10)
			{
				return jaak;
			}
			else if (jaak >= 10)
			{
				kontrollkood = (3 * Convert.ToInt32(kood[0].ToString())) + (4 * Convert.ToInt32(kood[1].ToString())) + (5 * Convert.ToInt32(kood[2].ToString())) + (6 * Convert.ToInt32(kood[3].ToString())) + (7 * Convert.ToInt32(kood[4].ToString())) + (8 * Convert.ToInt32(kood[5].ToString())) + (9 * Convert.ToInt32(kood[6].ToString())) + (1 * Convert.ToInt32(kood[7].ToString())) + (2 * Convert.ToInt32(kood[8].ToString())) + (3 * Convert.ToInt32(kood[9].ToString()));
				jaak = kontrollkood % 11;
				return jaak;
			}
			return -1;
		}

		public void onKorrektneKood()
		{
			if (onMeessoost() || onNaissoost())
			{
				int paev = -1;
				if (this.synnikuu() > 0 && this.synnikuu() <= 12)
				{
					if (this.synnikuu() == 2)
					{
						if (DateTime.IsLeapYear(this.synniaasta()))
						{
							paev = Convert.ToInt32(_isikukood[5] + "" + _isikukood[6]);
							if (!(paev >= 1 && paev <= 29))
							{
								throw new ArgumentOutOfRangeException("Isikukood", _isikukood[5] + "" + _isikukood[6], "Selle päeva ja kuu kombinatsioon ei ole õige");
							}
						}
						else
						{
							paev = Convert.ToInt32(_isikukood[5] + "" + _isikukood[6]);
							if (!(paev >= 1 && paev <= 28))
							{
								throw new ArgumentOutOfRangeException("Isikukood", _isikukood[5] + "" + _isikukood[6], "Selle päeva ja kuu kombinatsioon ei ole õige");
							}
						}
					}
					else
					{
						paev = Convert.ToInt32(_isikukood[5] + "" + _isikukood[6]);
						if (!(paev >= 1 && paev <= 31))
						{
							throw new ArgumentOutOfRangeException("Isikukood", _isikukood[5] + "" + _isikukood[6], "Selle päeva ja kuu kombinatsioon ei ole õige");
						}
					}
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("Isikukood", _isikukood[0], "Isikukood peab algama numbriga 1 - 9");
			}
			//return false;
		}

		public bool onMeessoost()
		{
			if (_isikukood[0] == '1' || _isikukood[0] == '3' || _isikukood[0] == '5' || _isikukood[0] == '7' || _isikukood[0] == '9')
			{
				return true;
			}
			return false;
		}

		public bool onNaissoost()
		{
			if (_isikukood[0] == '2' || _isikukood[0] == '4' || _isikukood[0] == '6' || _isikukood[0] == '8')
			{
				return true;
			}
			return false;
		}

		public static string looIsikukood(DateTime kuupaev, string sugu, int jrnr)
		{
			StringBuilder sb = new StringBuilder("");

			if (kuupaev.Year >= 1900 && kuupaev.Year < 2000)
			{
				if (sugu == "mees") sb.Append("3");
				else sb.Append("4");
			}
			else if (kuupaev.Year >= 2000 && kuupaev.Year < 3000)
			{
				if (sugu == "mees") sb.Append("5");
				else sb.Append("6");
			}

			sb.Append(kuupaev.ToString("yyMMdd"));
			sb.Append(jrnr.ToString().PadLeft(3, '0'));

			sb.Append(Isikukood.arvutaKontroll(sb.ToString()));

			return sb.ToString();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			/*Console.Write("Sisesta isikukood: ");
			string isikukood = Console.ReadLine();
			Isikukood kood = new Isikukood(isikukood);
			Console.WriteLine("Isiku sünnikuupäev: " + kood.synnikuupaev().ToString("d. MMMM, yyyy"));
			if (kood.onMeessoost())
			{
				Console.WriteLine("Isiku sugu: mees");
			}
			else
			{
				Console.WriteLine("Isiku sugu: naine");
			}*/
			
			Console.WriteLine("Kood: " + Isikukood.looIsikukood(new DateTime(2000, 2, 20), "mees", 85));
			Console.ReadKey();
		}
	}
}
