using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    public class Operation
    {
        public int Num { get; set; }
        public double Montant {get; set; }
        public DateTime Date {get; set; }
        public EnumType Type { get; set; }
        public int CompteID { get; set; }   


        public static List<Operation> GetData()
        {
            List<Operation> list= new List<Operation>();
            list.Add(new Operation{ Num =1 , Date=DateTime.Now,Montant=1000,Type=EnumType.Credit ,CompteID=1});
            list.Add(new Operation { Num = 2, Date = DateTime.Now, Montant = 200, Type = EnumType.Debit, CompteID = 1 });

            list.Add(new Operation { Num = 3, Date = DateTime.Now, Montant = 3000, Type = EnumType.Credit, CompteID = 2 });

            list.Add(new Operation { Num = 4, Date = DateTime.Now, Montant = 450, Type = EnumType.Debit, CompteID = 1 });

            list.Add(new Operation { Num = 5, Date = DateTime.Now, Montant = 6000, Type = EnumType.Credit, CompteID = 2 });

            list.Add(new Operation { Num = 6, Date = DateTime.Now, Montant = 800, Type = EnumType.Credit, CompteID = 3 });

            return list;
        }

        public double MontantType
        {
            get
            {
                return Type==EnumType.Credit ? Montant : -Montant ;
            }
        }
  
    }
}
