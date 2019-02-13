using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    public enum RequestType { SALES, SALESIMS, STORED, MOVING, GOODS_RECEIPT}
    public class Request
    {
        public Request()
        {

        }
        public Request(DateTime data1, DateTime data2)
        {
            DATA1 = data1;
            DATA2 = data2;
        }
        public RequestType RequestType {get; set;}
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        /// </summary>
        public int Kunnr { get; set; }

        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен
        /// </summary>
        public int BUKRS { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
        /// </summary>
        public int WERKS { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime DATA1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime DATA2 { get; set; }
    }

}
