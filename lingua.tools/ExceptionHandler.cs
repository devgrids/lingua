using System;
using System.Text.RegularExpressions;
using System.IO;

namespace lingua.tools
{
	public class ExceptionHandler : Exception
	{
		private static string _ApplicationPath { set; get; }
		private static string _UID { set; get; }

		public ExceptionHandler()
		{
		}

		public ExceptionHandler(string message, string source)
		{
			DateTime now = DateTime.Now;
			string errorMessage = "ERROR -> " + now.ToShortDateString() + "-" + now.ToShortTimeString() + " @ " + source + "-> " + " -> User:" + _UID + System.Environment.NewLine;
			string[] lines = Regex.Split(message, "\r\n");
			for (int i = 0; i < lines.GetLength(0); i++)
			{
				errorMessage += lines[i] + System.Environment.NewLine;
			}
			Guid obj = Guid.NewGuid();

			String year = DateTime.Now.Year.ToString();
			String month = DateTime.Now.Month.ToString("00");
			String day = DateTime.Now.Day.ToString("00");

			DirectoryInfo directoryYear = new DirectoryInfo("c:\\Yordy Leonidas MV\\" + year + "\\" + month + "\\" + day);
			if (directoryYear.Exists)
			{
				File.AppendAllText("C:" + "\\Yordy Leonidas MV\\" + year + "\\" + month + "\\" + day + "\\" + obj.ToString() + ".log", errorMessage + "********************************************" + System.Environment.NewLine);
			}
			else
			{
				directoryYear.Create();
				File.AppendAllText("C:" + "\\Yordy Leonidas MV\\" + year + "\\" + month + "\\" + day + "\\" + obj.ToString() + ".log", errorMessage + "********************************************" + System.Environment.NewLine);
			}
		}
	}
}
