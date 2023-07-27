using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Http;
using MTorrent;

namespace TelepadGuru
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
			List<int> powers = new List<int>() {5, 10, 20, 25, 30, 40, 50, 80, 100};
			setPow.DataSource = powers;
			setPow.SelectedIndex = 6;
			RefreshProcess();
			RefreshCoords();
		}
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        private void refreshProcessList_Click(object sender, EventArgs e)
        {
			RefreshProcess();
		}

		private void RefreshProcess()
        {
			List<Process> dreamseekers = new List<Process>(Process.GetProcessesByName("dreamseeker"));
			processList.DataSource = dreamseekers;
			processList.DisplayMember = "id";
			if (dreamseekers.Count == 0)
			{
				button3.Enabled = false;
				return;
			}
			else
				button3.Enabled = true;

			List<int> con2 = new List<int>();
			foreach (Process dreamseeker in dreamseekers)
			{
				List<Connection> connections = NetworkInformation.GetProcessTcpActivity(dreamseeker.Id);
				foreach (Connection connection in connections)
				{
					if (!con2.Contains(connection.LocalEndPoint.Port))
						con2.Add(connection.LocalEndPoint.Port);
					if (!con2.Contains(connection.RemoteEndPoint.Port))
						con2.Add(connection.RemoteEndPoint.Port);
				}
			}
			comboBox1.DataSource = con2;
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
			double num8 = 90.0 - this.RoundBearing(num5, num6);
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
							this.offPower.Text = (num13 - num7).ToString(CultureInfo.InvariantCulture);
							this.offBearing.Text = (num8).ToString(CultureInfo.InvariantCulture);
							this.offElevation.Text = (num15 - 45.0).ToString(CultureInfo.InvariantCulture);
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

        public double RoundBearing(double x, double y)
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
            this.dxBox.Text = num.ToString(CultureInfo.InvariantCulture);
            this.dyBox.Text = num2.ToString(CultureInfo.InvariantCulture);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(this.rxb.Text) - Convert.ToDouble(this.ix.Text);
            double num2 = Convert.ToDouble(this.ryb.Text) - Convert.ToDouble(this.iy.Text);
            this.d2xBox.Text = num.ToString(CultureInfo.InvariantCulture);
            this.d2yBox.Text = num2.ToString(CultureInfo.InvariantCulture);
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
			double num4 = Convert.ToDouble(this.setPow.SelectedValue.ToString());
			double num5 = Math.Round(90.0 - num3, 2);
			bool flag = false;
			if (num5 < 0.0)
			{
				num5 += 360.0;
			}
			this.setBear.Text = Math.Round(num5 - Convert.ToDouble(this.offBearing.Text), 2).ToString(CultureInfo.InvariantCulture).Replace(",", ".");
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
				this.setElev.Text = (Math.Round(num6 / (double)list.Count, 1) - Convert.ToDouble(this.offElevation.Text)).ToString(CultureInfo.InvariantCulture).Replace(",", ".");
				this.lab.Text = "Вычислено";
				return;
			}
			this.lab.Text = "Недостаточная мощность";
		}

		private void TurnCommand(string command, string data = "")
		{
			try
			{
				Process process = processList.SelectedValue as Process;

				if (process == null)
				{
					return;
				}
				
				WindowUtility windowUtility = new WindowUtility(process);
				SetForegroundWindow(process.MainWindowHandle);


				//WebRequest.Create(command);
				HttpClient reqGet = new HttpClient(new HttpClientHandler());
				HttpResponseMessage request = reqGet.Send(new HttpRequestMessage(HttpMethod.Get, command));
				
				if (!request.IsSuccessStatusCode)
				{
					return;
				}
				
				Thread.Sleep(150);

				IntPtr targetWindow = windowUtility.GetNewestWindowHandle();
				//targetWindow = GetLastWindow();
				SetForegroundWindow(targetWindow);
				SendKeys.Send(data);
                Thread.Sleep(100);
			}
			catch
			{
				// ignored
			}
		}

		private string GetAddress()
        {
			Process mainProcess = processList.SelectedValue as Process;

			if (mainProcess == null)
			{
				return "";
			}

			DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/BYOND/cache/tmp" + mainProcess.Id.ToString());
			List<string> fileList = new List<string>();

			string searchText = "Recalibrate Crystals";
			string fileName = "";
			string consoleId = "";

			foreach (var file in (from file in dir.GetFiles("*.htm", SearchOption.AllDirectories) orderby file.LastAccessTime descending select file).ToArray())
			{
				fileList.Add(file.FullName);
			}

			foreach (var file in fileList)
			{
				string tmp = File.ReadAllText(file);
				if (tmp.Contains(searchText))
				{
					int index1 = tmp.IndexOf("?src=[0x", StringComparison.Ordinal);
					consoleId = tmp.Substring(index1 + 6, 9);
					fileName = file.Split('\\').Last();
					break;
				}
			}
			if (consoleId == "")
				return "";

			string port = comboBox1.SelectedValue.ToString();
			if (string.IsNullOrWhiteSpace(port))
				return "";

			return "http://127.0.0.1:" + port + "/tmp" + mainProcess.Id.ToString() + "/" + fileName + "?src=[" + consoleId + "];";
		}

		private int _z = -1;
		
		private void OpenWormhole()
		{
			StreamWriter writer = new StreamWriter("coordinates.txt", true);
			string zString = _z == -1 ? "unknown" : _z.ToString();
			writer.WriteLine($"{rxb.Text} {ryb.Text} {zString}");
			writer.Close();
			_z = -1;
			
			Calkulate();

			string address = GetAddress();

			if (address == "")
				return;

			TurnCommand(address + "setrotation=1", setBear.Text + "{ENTER}");

			TurnCommand(address + "setangle=1", setElev.Text + "{ENTER}");

			TurnCommand(address + "setpower=" + (setPow.SelectedIndex + 1));

			if (checkBox1.Checked)
			{
				TurnCommand(address + "close_teleport=1");
				TurnCommand(address + "open_teleport=1");
			}
			
			RefreshCoords();
		}

		private void OpenWormholeFromMap(object sender, EventArgs e)
        {
			StreamReader reader;

            try
			{
				reader = new StreamReader("open_wormhole.txt");
			} catch
			{
				return;
			}
			string line;
			if ((line = reader.ReadLine()) == null)
			{
				reader.Close();
				return;
			} else
			{
                reader.Close();
            }

            StreamWriter writer = new StreamWriter("open_wormhole.txt");
            writer.Flush();
            writer.Close();

            string[] coords = line.Split(' ');
			rxb.Text = coords[0];
			ryb.Text = coords[1];
			int.TryParse(coords[2], out _z);
			
			string adress = GetAddress();
			if (adress == "")
				return;

            TurnCommand(adress + "setz=1", coords[2] + "{ENTER}");
            OpenWormhole();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			OpenWormhole();
		}

		private void RefreshCoords()
        {
			List<string> coordsList = new List<string>();
			StreamReader reader = new StreamReader("coordinates.txt");
			while (reader.ReadLine() is { } line)
			{
				string res = ParseCoordsPaper(line);
				if(res != "")
					coordsList.Add(res);
			}
			comboBox2.DataSource = coordsList;
			reader.Dispose();
			reader.Close();
        }

		private string ParseCoordsPaper(string line)
        {
			Regex regex = new Regex(@"\D+", RegexOptions.Compiled);
			string result = regex.Replace(line, " ");
			regex = new Regex(@"^\s", RegexOptions.Compiled);
			result = regex.Replace(result, "");
			regex = new Regex(@"\s$", RegexOptions.Compiled);
			result = regex.Replace(result, "");
			if (result.Split(" ").Length < 3 && result.Split(" ").Length > 1)
				result += " unknown";
			return result;
		}

        private void button6_Click(object sender, EventArgs e)
        {
			RefreshCoords();
        }

        private void button7_Click(object sender, EventArgs e)
        {
			string adress = GetAddress();
			if (adress == "")
				return;
			string value = comboBox2.SelectedValue as string;
			List<string> coords = value?.Split(' ').ToList() ?? new List<string>();
			if (coords.Count < 3)
				return;
			rxb.Text = coords[0];
			ryb.Text = coords[1];
			if (coords[2] != "unknown")
				TurnCommand(adress + "setz=1", coords[2] + "{ENTER}");
			OpenWormhole();
		}
	}
    
    public class WindowUtility
    {
	    public IntPtr NewestWindowHandle = IntPtr.Zero;
	    public DateTime NewestWindowTime = DateTime.MinValue;

	    public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	    [DllImport("user32.dll")]
	    public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

	    [DllImport("user32.dll")]
	    public static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);

	    [DllImport("user32.dll")]
	    public static extern int GetWindowTextLength(IntPtr hWnd);

	    [DllImport("user32.dll")]
	    public static extern bool IsWindowVisible(IntPtr hWnd);

	    public WindowUtility(Process process)
	    {
		    EnumWindows(EnumWindowsCallback, process.Handle);
	    }

	    public IntPtr GetNewestWindowHandle()
	    {
		    return NewestWindowHandle;
	    }

	    private bool EnumWindowsCallback(IntPtr hWnd, IntPtr lParam)
	    {
		    if (IsWindowVisible(hWnd))
		    {
			    int windowProcessId;
			    GetWindowThreadProcessId(hWnd, out windowProcessId);

			    if (windowProcessId == (int)lParam)
			    {
				    DateTime windowCreationTime = GetWindowCreationTime(hWnd);
				    if (windowCreationTime > NewestWindowTime)
				    {
					    NewestWindowTime = windowCreationTime;
					    NewestWindowHandle = hWnd;
				    }
			    }
		    }
		    return true;
	    }

	    private DateTime GetWindowCreationTime(IntPtr hWnd)
	    {
		    int pid;
		    GetWindowThreadProcessId(hWnd, out pid);
		    Process process = Process.GetProcessById(pid);
		    return process.StartTime;
	    }

	    [DllImport("user32.dll")]
	    private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
    }
}
