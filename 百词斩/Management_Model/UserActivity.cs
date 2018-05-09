using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class UserActivity
	{
        private int uA_ID;
        public int UA_ID
        {
            get { return uA_ID; }
            set { uA_ID = value; }
        }

        private int u_ID;
        public int U_ID
        {
            get { return u_ID; }
            set { u_ID = value; }
        }

        private int c_ID;
        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private DateTime uA_DATE;
        public DateTime UA_DATE
        {
            get { return uA_DATE; }
            set { uA_DATE = value; }
        }

        private int uA_WordNum;
        public int UA_WordNum
        {
            get { return uA_WordNum; }
            set { uA_WordNum = value; }
        }

    }
}