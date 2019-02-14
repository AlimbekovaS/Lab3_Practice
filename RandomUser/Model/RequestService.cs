using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.Model
{
   public class RequestService
    {
        public void CreateRequest() //метод
        {
            Request r = new Request();
            Console.Write("Заполните KUNNR: ");
            r.Kunnr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Заполните BUKRS");
            r.BUKRS = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Заполните DATA1");
            r.DATA1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Заполните DATA2");
            r.DATA2 = DateTime.Parse(Console.ReadLine());
            r.RequestType = RequestType.SALES;

        }

        public void GenerateReport(Request request)
        {
            switch (request.RequestType)
            {
                case RequestType.SALES:


                    break;
                case RequestType.SALESIMS:
                    break;
                case RequestType.STORED:
                    break;
                case RequestType.MOVING:
                    break;
                case RequestType.GOODS_RECEIPT:
                    break;
                default:
                    break;
            }


        }


    }
}
