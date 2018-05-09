using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Users
	{
		private int u_ID;
		public int U_ID
		{
			get { return u_ID; }
			set { u_ID = value; }
		}
	
		private string u_NAME;
		public string U_NAME
		{
			get { return u_NAME; }
			set { u_NAME = value; }
		}
	
		private string u_PASSWORD;
		public string U_PASSWORD
		{
			get { return u_PASSWORD; }
			set { u_PASSWORD = value; }
		}
	
		private byte[] u_IMG;
		public byte[] U_IMG
		{
			get { return u_IMG; }
			set { u_IMG = value; }
		}
	
		private string u_EMAIL;
		public string U_EMAIL
		{
			get { return u_EMAIL; }
			set { u_EMAIL = value; }
		}
	
		private string u_REGISTERTIME;
		public string U_REGISTERTIME
		{
			get { return u_REGISTERTIME; }
			set { u_REGISTERTIME = value; }
		}
	}
}