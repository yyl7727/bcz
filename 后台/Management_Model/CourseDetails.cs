using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Model
{

    public class CourseDetails
    {
        private int cD_ID;
        public int CD_ID
        {
            get { return cD_ID; }
            set { cD_ID = value; }
        }

        private int c_ID;
        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }

        private string cD_NAME;
        public string CD_NAME
        {
            get { return cD_NAME; }
            set { cD_NAME = value; }
        }

        private string cD_YINBIAO;
        public string CD_YINBIAO
        {
            get { return cD_YINBIAO; }
            set { cD_YINBIAO = value; }
        }

        private string cD_Mean;
        public string CD_Mean
        {
            get { return cD_Mean; }
            set { cD_Mean = value; }
        }

        private byte[] cD_RIGHT_PIC;
        public byte[] CD_RIGHT_PIC
        {
            get { return cD_RIGHT_PIC; }
            set { cD_RIGHT_PIC = value; }
        }

        private byte[] cD_WRONG_PIC1;
        public byte[] CD_WRONG_PIC1
        {
            get { return cD_WRONG_PIC1; }
            set { cD_WRONG_PIC1 = value; }
        }

        private byte[] cD_WRONG_PIC2;
        public byte[] CD_WRONG_PIC2
        {
            get { return cD_WRONG_PIC2; }
            set { cD_WRONG_PIC2 = value; }
        }

        private byte[] cD_WRONG_PIC3;
        public byte[] CD_WRONG_PIC3
        {
            get { return cD_WRONG_PIC3; }
            set { cD_WRONG_PIC3 = value; }
        }

        private string cD_SENEng;
        public string CD_SENEng
        {
            get { return cD_SENEng; }
            set { cD_SENEng = value; }
        }

        private string cD_SENChi;
        public string CD_SENChi
        {
            get { return cD_SENChi; }
            set { cD_SENChi = value; }
        }

        private string cD_VIDEO;
        public string CD_VIDEO
        {
            get { return cD_VIDEO; }
            set { cD_VIDEO = value; }
        }
    }
}

