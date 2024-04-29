using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using BinaryIntellect.DataAccess;
using lingua.be;
using lingua.tools;

namespace lingua.dal
{
	public class dalUser
	{
		public List<beUser> GetUserList()
		{
			DatabaseHelper dbHelper = null;
			List<beUser> list = new List<beUser>();

			try
			{
				dbHelper = new DatabaseHelper(dalConnection.GetConnection());
				SqlDataReader reader = (SqlDataReader)dbHelper.ExecuteReader("SELECT * FROM [user]", System.Data.CommandType.Text);
				while (reader.Read())
				{
					beUser obj = new beUser();
					obj.UserId = Validation.DBToInt32(ref reader, "user_id");
					obj.FirstName = Validation.DBToString(ref reader, "first_name");
					obj.LastName = Validation.DBToString(ref reader, "last_name");
					obj.Email = Validation.DBToString(ref reader, "email");
					obj.BirthDate = Validation.DBToDateTime(ref reader, "birth_date");
					obj.Gender = Validation.DBToString(ref reader, "gender");
					obj.RegistrationDate = Validation.DBToDateTime(ref reader, "registration_date");
					obj.LastUpdate = Validation.DBToDateTime(ref reader, "last_update");
					obj.AccountStatus = Validation.DBToString(ref reader, "account_status");
					list.Add(obj);
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler localException = new(ex.InnerException.ToString(), "dalUser -> GetUserList()");
			}
			finally
			{
				if (dbHelper != null)
					dbHelper.Dispose();
			}
			return list;
		}
	}
}
