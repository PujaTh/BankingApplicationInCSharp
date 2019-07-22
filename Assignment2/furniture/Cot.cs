using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFurnitureQuestion
{
    class Cot:Furniture
    {
      string  m_strType;
      string m_strCotCapacity;
      public  double m_frate;

      public Cot(int orderID, string orderDate, string furnitureType, int qty, string paymentMOde, string type, string capacity, double rate)
          : base(orderID, orderDate, furnitureType, qty, paymentMOde)
      {
          this.m_strType = type;
          this.m_strCotCapacity = capacity;
          m_frate = rate;     
      }


     public override void ShowData()
        {
            Console.WriteLine("type of cot is: {0}", m_strType);
            Console.WriteLine("capacity of cot is:{0}", m_strCotCapacity);
            m_dbTotalAmt = m_frate * m_snQty;
            Console.WriteLine("total bill of {0} Cots is :{1}", m_snQty, m_dbTotalAmt);
        }
    
    }
}
