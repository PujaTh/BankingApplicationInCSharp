using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFurnitureQuestion
{
    class Furniture
    {  
	public int          m_nOrderid;
    public   string     m_strOrderDate;
	public string       m_strFurnitureType;
	public int          m_snQty;
	public double       m_dbTotalAmt;
	public string       m_strPaymentMode;
	
   public Furniture()
    {
        m_nOrderid = m_snQty = 1;
        m_dbTotalAmt = 1.0;
        //m_strFurnitureType = m_strPaymentMode ='\0';
    }

    public  Furniture(int orderID,string orderDate,string furnitureType,int qty,string paymentMOde)
    {
        this.m_nOrderid = orderID;
        this.m_strOrderDate = orderDate;
        this.m_strFurnitureType = furnitureType;
        this.m_snQty = qty;
      //this.m_dbTotalAmt = totalAmt;
        this.m_strPaymentMode = paymentMOde;
        
    }

    public  virtual void ShowData()
    {
        Console.WriteLine("***********Furniture buyed ********");
        Console.WriteLine("Order id : {0}", m_nOrderid);
        Console.WriteLine("Order date :{0} ", m_strOrderDate);
        Console.WriteLine( "Furniture type : {0}",m_strFurnitureType);
        Console.WriteLine( "Furniture Quantity : {0}" , m_snQty);
        Console.WriteLine( "Payment Mode :{0}",m_strPaymentMode);
    }

    }
}
