using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.IO;
using MTorrent;
using Accessibility;

namespace TelepadGuru
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
			refreshProcess();
		}

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void refreshProcessList_Click(object sender, EventArgs e)
        {
			refreshProcess();
		}

		private void refreshProcess()
        {
			List<Process> dreamseekers = new List<Process>(Process.GetProcessesByName("dreamseeker"));
			processList.DataSource = dreamseekers;
			processList.DisplayMember = "id";
			processList.ValueMember = "id";
			if (dreamseekers.Count == 0)
				button3.Enabled = false;
			else
				button3.Enabled = true;
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			double num = Convert.ToDouble(this.dxBox.Text);
			double num2 = Convert.ToDouble(this.dyBox.Text);
			double num3 = Convert.ToDouble(this.d2xBox.Text);
			double num4 = Convert.ToDouble(this.d2yBox.Text);
			double num5 = this.CalcBearing(num, num2);
			double num6 = this.CalcBearing(num3, num4);
			double num7 = 30.0;
			double num8 = 90.0 - this.roundBearing(num5, num6);
			num5 = 90.0 - num5;
			num6 = 90.0 - num6;
			bool flag = false;
			if (num8 < 0.0)
			{
				num8 += 360.0;
			}
			this.lab.Text = "";
			double num9 = 15.0;
			double num10 = num9 + 60.0;
			if (num9 < 0.0)
			{
				num9 = 0.0;
			}
			if (num10 > 90.0)
			{
				num10 = 90.0;
			}
			Dictionary<double, List<double>> dictionary = new Dictionary<double, List<double>>();
			Dictionary<double, List<double>> dictionary2 = new Dictionary<double, List<double>>();
			for (double num11 = num7; num11 > num7 - 5.0; num11 -= 1.0)
			{
				for (double num12 = num9; num12 <= num10; num12 += 0.1)
				{
					if (this.Check(num5, num12, num11, num, num2))
					{
						if (Math.Abs(Math.Round(num12) - num12) < 0.1)
						{
							if (dictionary.ContainsKey(num11))
							{
								dictionary[num11].Add(Math.Round(num12));
							}
							else
							{
								dictionary.Add(num11, new List<double>
								{
									Math.Round(num12)
								});
							}
						}
					}
					if (this.Check(num6, num12, num11, num3, num4))
					{
						if (Math.Abs(Math.Round(num12) - num12) < 0.1)
						{
							if (dictionary2.ContainsKey(num11))
							{
								dictionary2[num11].Add(Math.Round(num12));
							}
							else
							{
								dictionary2.Add(num11, new List<double>
								{
									Math.Round(num12)
								});
							}
						}
					}
				}
			}
			if (Math.Abs(num) < Math.Abs(num3))
			{
				num9 = 5.0;
			}
			else
			{
				num9 = 5.0;
			}
			for (double num13 = num7; num13 > num7 - 5.0; num13 -= 1.0)
			{
				if (dictionary.ContainsKey(num13) && dictionary2.ContainsKey(num13))
				{
					foreach (double num14 in dictionary[num13])
					{
						double num15 = num14;
						if (dictionary2[num13].Contains(num15 + num9))
						{
							this.offPower.Text = (num13 - num7).ToString();
							this.offBearing.Text = (num8).ToString();
							this.offElevation.Text = (num15 - 45.0).ToString();
							flag = true;
						}
					}
				}
			}
			if (flag)
			{
				this.lab.Text = "Вычислено";
				return;
			}
			this.lab.Text = "Ошибка";
		}

        public double CalcBearing(double x, double y)
        {
            return 180.0 * Math.Atan2(y, x) / 3.141592653589793;
        }

        public double roundBearing(double x, double y)
        {
            double result;
            if (Math.Floor(x) == Math.Ceiling(y))
            {
                result = Math.Floor(x);
            }
            else if (Math.Ceiling(x) == Math.Floor(y))
            {
                result = Math.Floor(y);
            }
            else if (Math.Ceiling(x) - x + Math.Ceiling(y) - y > x - Math.Floor(x) + y - Math.Floor(y))
            {
                result = Math.Floor(y);
            }
            else
            {
                result = Math.Ceiling(y);
            }
            return result;
        }
        public bool Check(double bear, double elev, double pow, double tx, double ty)
        {
            double num = pow * pow / 10.0 * Math.Sin(3.141592653589793 * elev / 90.0);
            bool result = true;
            if ((double)((int)Math.Round(num * Math.Sin(3.141592653589793 * bear / 180.0))) != tx)
            {
                result = false;
            }
            if ((double)((int)Math.Round(num * Math.Cos(3.141592653589793 * bear / 180.0))) != ty)
            {
                result = false;
            }
            return result;
        }
        public bool Calc(int bear, int elev, int pow, int ix, int iy)
        {
            double num = (double)pow * (double)pow / 10.0 * Math.Sin(3.141592653589793 * (double)elev / 90.0);
            bool result = true;
            if ((int)Math.Round(num * Math.Sin(3.141592653589793 * (double)bear / 180.0)) != ix)
            {
                result = false;
            }
            if ((int)Math.Round(num * Math.Cos(3.141592653589793 * (double)bear / 180.0)) != iy)
            {
                result = false;
            }
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(this.rxb.Text) - Convert.ToDouble(this.ix.Text);
            double num2 = Convert.ToDouble(this.ryb.Text) - Convert.ToDouble(this.iy.Text);
            this.dxBox.Text = num.ToString();
            this.dyBox.Text = num2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(this.rxb.Text) - Convert.ToDouble(this.ix.Text);
            double num2 = Convert.ToDouble(this.ryb.Text) - Convert.ToDouble(this.iy.Text);
            this.d2xBox.Text = num.ToString();
            this.d2yBox.Text = num2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			Calkulate();
		}

		private void Calkulate()
        {
			double num = Convert.ToDouble(this.rxb.Text) - Convert.ToDouble(this.ix.Text);
			double num2 = Convert.ToDouble(this.ryb.Text) - Convert.ToDouble(this.iy.Text);
			double num3 = this.CalcBearing(num, num2);
			double num4 = Convert.ToDouble(this.setPow.Text);
			double num5 = Math.Round(90.0 - num3, 2);
			bool flag = false;
			if (num5 < 0.0)
			{
				num5 += 360.0;
			}
			this.setBear.Text = Math.Round(num5 - Convert.ToDouble(this.offBearing.Text), 2).ToString().Replace(",", ".");
			this.lab.Text = "";
			double num6;
			double num7;
			if (Convert.ToDouble(this.offElevation.Text) < 0.0)
			{
				num6 = 1.0;
				num7 = 45.0;
			}
			else
			{
				num6 = 45.0;
				num7 = 90.0;
			}
			List<double> list = new List<double>();
			double num8 = num4 + Convert.ToDouble(this.offPower.Text);
			for (double num9 = num6; num9 <= num7; num9 += 0.1)
			{
				if (this.Check(num5, num9, num8, num, num2))
				{
					list.Add(num9);
					flag = true;
				}
			}
			num6 = 0.0;
			if (flag)
			{
				foreach (double num10 in list)
				{
					double num11 = num10;
					num6 += num11;
				}
				this.setElev.Text = (Math.Round(num6 / (double)list.Count, 1) - Convert.ToDouble(this.offElevation.Text)).ToString().Replace(",", ".");
				this.lab.Text = "Вычислено";
				return;
			}
			this.lab.Text = "Недостаточная мощность";
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Calkulate();

			List<Connection> connections = NetworkInformation.GetProcessTcpActivity(Process.GetProcessesByName("dreamseeker")[0].Id);
			connections[0].LocalEndPoint.Port.ToString();
			string consoleID = "";

			DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/BYOND/cache/tmp" + processList.SelectedValue.ToString());
			List<string> fileList = new List<string>();

			string searchText = "Recalibrate Crystals";
			string file_name = "";

			foreach (var file in (from file in dir.GetFiles("*.htm", SearchOption.AllDirectories) orderby file.LastWriteTime select file).ToArray())
			{
				fileList.Add(file.FullName);
			}

			foreach (var file in fileList)
			{
				string tmp = File.ReadAllText(file);
				if (tmp.Contains(searchText))
				{
					int index1 = tmp.IndexOf("?src=[0x");
					consoleID = tmp.Substring(index1+6, 9);
					file_name = file.Split('\\').Last();
					break;
				}
			}
			if (consoleID == "")
				return;

			SetForegroundWindow(Process.GetProcessesByName("dreamseeker")[0].MainWindowHandle);
			string port = "";
			if (connections[0].RemoteEndPoint.Port.ToString() == "0")
				port = connections[0].LocalEndPoint.Port.ToString();
			else
				port = connections[0].RemoteEndPoint.Port.ToString();

			if (port == "0")
				return;

			string adress = "http://127.0.0.1:" + port + "/tmp" + processList.SelectedValue.ToString() + "/" + file_name + "?src=[" + consoleID + "];";

			WebRequest reqGET = WebRequest.Create(adress + "setrotation=1");
			WebResponse resp = reqGET.GetResponse();
			Thread.Sleep(Convert.ToInt32(textBox1.Text));
			SendKeys.Send(setBear.Text + "{ENTER}");

			reqGET = WebRequest.Create(adress + "setangle=1");
			resp = reqGET.GetResponse();
			Thread.Sleep(Convert.ToInt32(textBox1.Text));
			SendKeys.Send(setElev.Text + "{ENTER}");

            if (checkBox1.Checked)
            {
				reqGET = System.Net.WebRequest.Create(adress + "open_teleport=1");
				resp = reqGET.GetResponse();
			}
		}
    }
}
