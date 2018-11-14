using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeMachine
{
	public partial class Form1 : Form
	{
		// Timecode Format MMDDYYYYTTTT (Day, Month, Year, Time)
		String[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
		int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		String codeInput = "";
		String destinationTimecode = "";
		String currentTimecode = "";
		String lastTimecode = "";


		public long getTimestamp(string timecode)
		{
			// 010100000000
			long returnValue = 0;
			if (timecode.Length != 12) { Console.WriteLine("Incorrect Code Length");  return -1; }
			long month = Convert.ToInt64(timecode.Substring(0, 2));
			long days = Convert.ToInt64(timecode.Substring(2, 2));
			long year = Convert.ToInt64(timecode.Substring(4, 4));
			long hours = Convert.ToInt64(timecode.Substring(8, 2));
			long minutes = Convert.ToInt64(timecode.Substring(10, 2));

			if (month <= 0 || month > 12) { Console.WriteLine("Month invalid: " + month);  return -1; }
			if (days <= 0 || days > getDayCount(Convert.ToInt32(month) - 1, Convert.ToInt32(year))) { Console.WriteLine("Day invalid: " + days);  return -1; }

			if (hours < 0 || hours >= 24) { Console.WriteLine("Hour invalid: " + hours);  return -1; }
			if (minutes < 0 || minutes >= 60) { Console.WriteLine("Minute invalid: " + minutes);  return -1; }
			returnValue += minutes + (hours * 60) + (getDaysPast(month, days, year) * 24 * 60);
			return returnValue;
		}

		public String getTimeString(String timecode)
		{
			String error = "ERR -- ---- --:-- --";
			if (timecode.Length < 2 || timecode.Length > 12) { return "--- -- ---- --:-- --"; }
			else if (timecode.Length < 4)
			{
				int month = Convert.ToInt32(timecode.Substring(0, 2)) - 1;
				if (month < 0 || month >= 12) { return error; }
				return months[month] + " -- ---- --:-- --";
			}
			else if (timecode.Length < 8)
			{
				int month = Convert.ToInt32(timecode.Substring(0, 2)) - 1;
				if (month < 0 || month >= 12) { return error; }
				int days = Convert.ToInt32(timecode.Substring(2, 2));
				if (days <= 0 || days > getDayCount(month, -1)) { return error; }
				return months[month] + " " + timecode.Substring(2, 2) + " ---- --:-- --";
			}
			else if (timecode.Length < 12)
			{
				int month = Convert.ToInt32(timecode.Substring(0, 2)) - 1;
				if (month < 0 || month >= 12) { return error; }
				int days = Convert.ToInt32(timecode.Substring(2, 2));
				int year = Convert.ToInt32(timecode.Substring(4, 4));
				if (days <= 0 || days > getDayCount(month, year)) { return error; }
				return months[month] + " " + timecode.Substring(2, 2) + " " + timecode.Substring(4, 4) + " --:-- --";
			}
			else
			{
				int month = Convert.ToInt32(timecode.Substring(0, 2)) - 1;
				if (month < 0 || month >= 12) { return error; }
				int days = Convert.ToInt32(timecode.Substring(2, 2));
				if (days <= 0 || days > getDayCount(month+1, -1)) { return error; }
				int time = Convert.ToInt32(timecode.Substring(8,4));
				if (time >= 2400 || time % 100 >= 60) { return error; }
				String AMorPM = "AM";
				String zeroesLOL = "";
				if (time >= 1200)
				{
					AMorPM = "PM";
					time -= 1200;
				}
				if (time < 100)
				{
					time += 1200;
				}
				if (time % 100 < 10)
				{
					zeroesLOL = "0";
				}
				return months[Convert.ToInt32(timecode.Substring(0, 2)) - 1] + " " + timecode.Substring(2, 2) + " " + timecode.Substring(4, 4) + " " + (time / 100) + ":" + zeroesLOL + (time % 100) + " " + AMorPM;
			}
		}

		private long getDaysPast(long month, long day, long year)
		{
			long daysPast = (year * 365) + (year / 4) - (year / 100) + (year / 400) + (day - 1);
			for (int i = 0; i < (month - 1) && i < 12; i++)
			{
				daysPast += monthDays[i];
			}
			return daysPast;
		}

		private int getDayCount(int month, int year)
		{
			if (month < 0 || month >= 12) { return -1; }
			if (year < -1 || year > 9999) { return -1; }
			int properDayCount = monthDays[month];
			if (year >= 0)
			{
				if (month == 1 && year % 4 == 0)
				{
					if (year % 100 == 0) { if (year % 400 == 0) { properDayCount += 1; } }
					else { properDayCount += 1; }
				}
			}
			else if (month == 1)
			{
				properDayCount += 1;
			}
			return properDayCount;
		}

		public void updateDisplay()
		{
			if (codeInput == "")
			{
				destinationTime.Text = getTimeString(destinationTimecode);
			}
			else
			{
				destinationTime.Text = getTimeString(codeInput);
			}
			currentTime.Text = getTimeString(currentTimecode);
			lastTime.Text = getTimeString(lastTimecode);
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void pad1_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "1";
			updateDisplay();
		}

		private void pad2_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "2";
			updateDisplay();
		}

		private void pad3_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "3";
			updateDisplay();
		}

		private void pad4_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "4";
			updateDisplay();
		}

		private void pad5_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "5";
			updateDisplay();
		}

		private void pad6_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "6";
			updateDisplay();
		}

		private void pad7_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "7";
			updateDisplay();
		}

		private void pad8_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "8";
			updateDisplay();
		}

		private void pad9_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; }
			codeInput += "9";
			updateDisplay();
		}

		private void pad0_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12) { return; } 
			codeInput += "0";
			updateDisplay();
		}

		private void padConfirm_Click(object sender, EventArgs e)
		{
			if (codeInput.Length >= 12)
			{
				destinationTimecode = codeInput;
				codeInput = "";
				updateDisplay();
			}
		}

		private void padCancel_Click(object sender, EventArgs e)
		{
			codeInput = "";
			updateDisplay();
		}

		private void padGo_Click(object sender, EventArgs e)
		{

		}
	}
}
