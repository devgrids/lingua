using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace lingua.tools
{
	public static class Validation
	{
		#region Data Type Validations

		public static DateTime DBToDateTime(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? DateTime.MinValue : Convert.ToDateTime(reader[columnName]);
		}

		public static string DBToString(ref SqlDataReader reader, string columnName)
		{
			return Convert.ToString(reader[columnName]);
		}

		public static int DBToInt32(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (Int32)0 : (Int32)reader[columnName];
		}

		public static int DBToSmallInt(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (Int16)0 : (Int16)reader[columnName];
		}

		public static int DBToTinyInt(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (Byte)0 : (Byte)reader[columnName];
		}

		public static Int64 DBToInt64(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (Int64)0 : (Int64)reader[columnName];
		}

		public static decimal DBToDecimal(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (decimal)0 : (decimal)reader[columnName];
		}

		public static short DBToInt16(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? (short)0 : (short)reader[columnName];
		}

		public static bool DBToBoolean(ref SqlDataReader reader, string columnName)
		{
			return (reader.IsDBNull(reader.GetOrdinal(columnName))) ? false : (bool)reader[columnName];
		}

		#endregion

		#region Form Controls Validations

		public static bool ValidateDecimals(string txtData, CancelEventArgs e)
		{
			Regex isDecimal = new Regex(@"^-?[0-9]+(\.?[0-9]+)?$");
			if (isDecimal.IsMatch(txtData))
				e.Cancel = false;
			else
				e.Cancel = true;
			return e.Cancel;
		}

		public static bool ValidateIntegers(string txtData, CancelEventArgs e)
		{
			Regex isNumber = new Regex(@"^[0-9]+$");
			if (isNumber.IsMatch(txtData))
				e.Cancel = false;
			else
				e.Cancel = true;
			return e.Cancel;
		}

		public static bool ValidateEmail(string txtData)
		{
			bool e;
			Regex isMail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
			if (isMail.IsMatch(txtData))
				e = false;
			else
				e = true;
			return e;
		}

		public static bool ValidateIntegerNumber(string txtData)
		{
			bool e;
			Regex isInteger = new Regex(@"^\d*$");
			if (isInteger.IsMatch(txtData))
				e = false;
			else
				e = true;
			return e;
		}

		public static bool ValidateAlphanumeric(string txtData)
		{
			bool e;
			Regex isAlphanumeric = new Regex(@"^[a-zA-Z0-9]+$");

			if (isAlphanumeric.IsMatch(txtData)) e = false;
			else e = true;

			return e;
		}

		public static bool ValidateComments(string txtData)
		{
			bool e;
			Regex isComment = new Regex(@"^(/w|/W|[^<>{}&])+$");

			if (isComment.IsMatch(txtData)) e = false;
			else e = true;

			return e;
		}

		public static bool ValidateAddress(string txtData)
		{
			bool e;
			Regex isAddress = new Regex(@"^(/w|/W|[^<>{}&'°#?;""])+$");

			if (isAddress.IsMatch(txtData)) e = false;
			else e = true;

			return e;
		}

		public static bool ValidateAlphabetic(string txtData)
		{
			bool e;
			Regex isAlphabetic = new Regex(@"^[a-zA-Z\s.\-_ñÑ']+$");

			if (isAlphabetic.IsMatch(txtData)) e = false;
			else e = true;

			return e;
		}

		public static bool ValidatePhoneNumber(string txtData)
		{
			bool e;
			Regex isPhoneNumber = new Regex(@"^(\(?\d\d\d\)?)?( |\#|-|\.)?\d\d\d?\d( |\*|-|\.)?\d{3,4}(( |-|\.)?[ext\.]+ ?\d+)?$");

			if (isPhoneNumber.IsMatch(txtData)) e = false;
			else e = true;

			return e;
		}

		public static bool ValidateDecimalNumber(string txtData)
		{
			bool e;
			Regex isDecimal = new Regex(@"^[0-9]*(\.)?[0-9]+$");
			if (isDecimal.IsMatch(txtData))
				e = false;
			else
				e = true;
			return e;
		}

		#endregion
	}
}
