using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFurnitureQuestion
{
    class Chair:Furniture
    {
        string strType;
        string strPurpose;
        public  double m_frate;
       
       public  Chair(int orderID,string orderDate,string furnitureType,int qty,string paymentMOde,string type, string purpose, double rate):base(orderID,orderDate,furnitureType,qty,paymentMOde)
      {
          this.strType = type;
          this.strPurpose = purpose;
         this. m_frate = rate;     
      }
       public override void ShowData()
        {
            Console.WriteLine("type of chair is: {0}",strType);
            Console.WriteLine("pupose of chair is:{0}", strPurpose);
           m_dbTotalAmt=m_frate * m_snQty;
           Console.WriteLine("total bill of {0} chiar is :{1}", m_snQty, m_dbTotalAmt);
        }

    }
}
