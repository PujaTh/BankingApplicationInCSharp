using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFurnitureQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
           int orderid=0 ;
	int n=0;
	int z=0;
	int a=0;
	 int qul=0;
	string date="";
	string str="";
	string str1="";
	string str2="";
	 string str3="";
	string str4="";
	string str5="";
	string str6="";
	string str10="";
	//double totalamout=0.0;
	double cr_rate=0.0;
	double ct_rate=0.0;

   Console.WriteLine( "Welcome to Furniture mall");
    Console.WriteLine("Enter the OrdetId(it should be numeric) :");
     orderid=Convert.ToInt32(Console.ReadLine());;
    Console.WriteLine("Enter the orderdate : ");
    date=Console.ReadLine();
GG:
    Console.WriteLine("enter the furniture type : \n 1.Chair \n 2.Cat ");
    z=Convert.ToInt32(Console.ReadLine());
    if (z == 1 || z == 2)
    {
        switch (z)
        {
            case 1: str= "Chair";
                break;
            case 2: str= "Cot";
                break;
        }
    }
    else
    {
        Console.WriteLine("you type rong : ");
        Console.WriteLine ("please enter the currec option" );
        goto GG;
    }

    Console.WriteLine("enter the quantity" );
    qul=Convert.ToInt32(Console.ReadLine());
   // Console.WriteLine("Enter the Total amout : ");
  //  totalamout=Convert.ToDouble(Console.ReadLine());
MM:
    Console.WriteLine("enter the payment mode 1.CRIDIT \t 2.DIBIT CAR : " );
    n=Convert.ToInt32(Console.ReadLine());
    if (n == 1 || n == 2)
    {
        switch (n)
        {
            case 1: str1="Cridit";
                break;
            case 2: str1="Dibit";
                break;
        }
    }
    else
    {
        Console.WriteLine("you type rong : ");
        Console.WriteLine ("please enter the currect options");
        goto MM;
    }

    // Complection of furniture class type 
    if (z == 1)
    {
        Console.WriteLine("you selected " +str + "type");
    AA:
        Console.WriteLine(" please enter the purpose of chair \n1.HOME \t2.OFFICE");
        a=Convert.ToInt32(Console.ReadLine());
        if (a == 1 || a == 2)
        {
            switch (a)
            {
                case 1: str2= "Home";
                    break;
                case 2: str2= "Office";
                    break;
            }
        }
        else
        {
            Console.WriteLine("you type rong : " );
            Console.WriteLine("please enter the currect options" );
            goto AA;
        }

    BB:
        Console.WriteLine("please enter the chair types : \n 1.WOOD\t2.STEEL\t3.PLASTIC");
        a=Convert.ToInt32(Console.ReadLine());
        if (a == 1 || a == 2 || a == 3)
        {
            switch (a)
            {
                case 1:
                    int b;
                CC:
                    Console.WriteLine("you selected Wood type \n \t please selected wood type \n1.Teak Wood \t2.Rose Wood ");
                    b=Convert.ToInt32(Console.ReadLine());
                    if (b == 1 || b == 2)
                    {
                        switch (b)
                        {
                            case 1: str3= "Teak Wood";
                                break;
                            case 2: str3="Rose Wood";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you type wrong : ");
                        Console.WriteLine ("please enter the currect options" );
                        goto CC;
                    }
                    str10=str3;
                    break;

                case 2:
                DD:
                    Console.WriteLine("you selected STEEL Chiar \nplease select steel type 1.Gray Steel\t2.Green Stleel \t3.Brown Steel \n");
                    n=Convert.ToInt32(Console.ReadLine());
                    if (n == 1 || n == 2 || n == 3)
                    {
                        switch (n)
                        {
                            case 1:
                                str4= "Gray Steel";
                                break;
                            case 2:
                                str4="Green streel";
                                break;
                            case 3:
                                str4= "Brown Steel";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you type rong : " );
                        Console.WriteLine ("please enter the currect options");
                        goto DD;
                    }
                    str10=str4;
                    break;
                case 3:
                EE:
                    Console.WriteLine( "you selected plastic chair \n \tplease selected color of chair \n1.Green \t2.Red\t3.Blue\t4.White" );
                    n=Convert.ToInt32(Console.ReadLine());
                    if (n == 1 || n == 2 || n == 3 || n == 4)
                    {
                        switch (n)
                        {
                            case 1:
                                str4= "Green Plastic";
                                break;
                            case 2:
                                str4 = "Red Plastic";
                                break;
                            case 3:
                                str4 = "Blue Plastic";
                                break;
                            case 4:
                                str4 = "White Plastic";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you type rong : ");
                        Console.WriteLine("please enter the currect options");
                        goto EE;
                    }
                    str10= str4;
                    break;
            }
        }
        else
        {
            Console.WriteLine( "you type rong : ");
            Console.WriteLine ("please enter the currect options");
            goto BB;
        }

        Console.WriteLine ("please enter the RATE of chair" );
         cr_rate=Convert.ToDouble (Console.ReadLine());
    }
    else
    {
    FF:
        Console.WriteLine("please enter the Coach types : \n 1.WOOD\t2.STEEL");
        a = Convert.ToInt32(Console.ReadLine());
        if (a == 1 || a == 2)
        {
            switch (a)
            {
                case 1:
                    int b;
                CC:
                    Console.WriteLine("you selected Wood type \n \t please selected wood type \n1.Teak Wood \t2.Rose Wood ");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b == 1 || b == 2)
                    {
                        switch (b)
                        {
                            case 1: str3 = "Teak Wood";
                                break;
                            case 2: str3 = "Rose Wood";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you type wrong : ");
                        Console.WriteLine("please enter the currect options");
                        goto CC;
                    }
                    str5 = str3;
                    break;

                case 2:
                DD:
                    Console.WriteLine("you selected STEEL coach \nplease select steel type 1.Gray Steel\t2.Green Stleel \t3.Brown Steel \n");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1 || n == 2 || n == 3)
                    {
                        switch (n)
                        {
                            case 1:
                                str4 = "Gray Steel";
                                break;
                            case 2:
                                str4 = "Green streel";
                                break;
                            case 3:
                                str4 = "Brown Steel";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you type rong : ");
                        Console.WriteLine("please enter the currect options");
                        goto DD;
                    }
                    str5 = str4;
                    break;
            }
        }
        else
        {
            Console.WriteLine("you type rong : ");
            Console.WriteLine("please enter the currect options");
            goto FF;
        }
    HH:
        Console.WriteLine ( "please selected capacity of COT \n \t 1.SINGLE \t 2.DOUBLE "  );
        n=Convert.ToInt32(Console.ReadLine());
        if (n == 1 || n == 2)
            switch (n)
            {
                case 1:
                    str6="SINGLE COT";
                    break;
                case 2:
                    str6= "DOUBLE COT";
                    break;
            }
        else
        {
            Console.WriteLine ("you type rong : " );
            Console.WriteLine ("please enter the currect options" );
            goto HH;
        }
        Console.WriteLine ( "please enter the COT cost " );
         ct_rate=Convert.ToDouble(Console.ReadLine());
    }

    Furniture object_furniture=new Furniture(orderid, date, str, qul,str1);
    Console.WriteLine();
    object_furniture.ShowData();

    if (z == 1)
    {
        Chair object_chair = new Chair(orderid, date, str, qul, str1,str10, str2, cr_rate);
        
        object_chair.ShowData();
        
    }
    else
    {
        Cot object_cot = new Cot(orderid, date, str, qul, str1,str5, str6, ct_rate);
        
        object_cot.ShowData();
    }
    Console.ReadLine();
        }
    }

   
}
