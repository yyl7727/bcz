using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Model //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class UserCollect
	{
        private int uC_ID;
        public int UC_ID
        {
            get { return uC_ID; }
            set { uC_ID = value; }
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

        private int uC_EveWord;
        public int UC_EveWord
        {
            get { return uC_EveWord; }
            set { uC_EveWord = value; }
        }

        private int uC_ComDay;
        public int UC_ComDay
        {
            get { return uC_ComDay; }
            set { uC_ComDay = value; }
        }

        private DateTime uC_StartDay;
        public DateTime UC_StartDay
        {
            get { return uC_StartDay; }
            set { uC_StartDay = value; }
        }

        private DateTime uC_EndDay;
        public DateTime UC_EndDay
        {
            get { return uC_EndDay; }
            set { uC_EndDay = value; }
        }

        private int uC_IsRead;
        public int UC_IsRead
        {
            get { return uC_IsRead; }
            set { uC_IsRead = value; }
        }
    }
}