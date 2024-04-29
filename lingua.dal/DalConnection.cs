using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lingua.dal
{
	public class dalConnection
	{
		public static String GetConnection()
		{
			//var strConnection = @"Data Source=LEONIDAS-MV\SQLEXPRESS;Initial Catalog=lingua;uid="";pwd=""";
			var strConnection = @"Data Source=LEONIDAS-MV\SQLEXPRESS;Initial Catalog=lingua;Integrated Security=True";
			return strConnection;
		}
	}
}
