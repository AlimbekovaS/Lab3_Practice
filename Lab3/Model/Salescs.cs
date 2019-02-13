using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    public class Salescs
    {
        public int BUKRS { get; set; }
        public int WERKS { get; set; }
        public int LGORT { get; set; }
        public int SALES_CHANEL { get; set; }
        public string SALES_CHANEL_TXT { get; set; }
        public int KUNNR { get; set; }
        public string KUNNR_TXT { get; set; }
        private string ID_OUT_DELIVERY_DATA_ { get; set; }
        public string ID_OUT_DELIVERY_DATA
        {
            get
            {
                return ID_OUT_DELIVERY_DATA_;
            }
            set
            {

                DateTime tmp;
                if (DateTime.TryParse(value, out tmp))
                {
                    ID_OUT_DELIVERY_DATA_ = string.Format("{0:dd-mm-yy}", tmp);
                }
                else
                    ID_OUT_DELIVERY_DATA_ = "";
                ID_OUT_DELIVERY_DATA_ = value;
            }
        }
    }
}
