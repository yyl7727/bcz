using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Coures
	{
		private int c_ID;
		public int C_ID
		{
			get { return c_ID; }
			set { c_ID = value; }
		}
	
		private string c_NAME;
		public string C_NAME
		{
			get { return c_NAME; }
			set { c_NAME = value; }
		}
	
		private int cCT_ID;
		public int CCT_ID
		{
			get { return cCT_ID; }
			set { cCT_ID = value; }
		}
	
		private string c_RELEASEDATE;
		public string C_RELEASEDATE
		{
			get { return c_RELEASEDATE; }
			set { c_RELEASEDATE = value; }
		}
	
		private int c_vocabulary;
		public int C_vocabulary
		{
			get { return c_vocabulary; }
			set { c_vocabulary = value; }
		}
	}
}