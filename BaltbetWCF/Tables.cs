using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaltbetWCF
{
    [DataContract]
     public class Players
     {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Patronymic { get; set; }

        [DataMember]
        public string Birth { get; set; }       // Дата рождения

        [DataMember]
        public double Balance  { get; set; }
     }

    [DataContract]
    public class Bets
    {
        [DataMember]
        public int Id { get; set; }             // Id ставки (генерируется в БД)

        [DataMember]
        public int IdClient { get; set; }       // Игрок

        [DataMember]
        public string Date { get; set; }        // Дата ставки

        [DataMember]
        public double Summ { get; set; }       // Сумма ставки

        [DataMember]
        public double Ratio { get; set; }      // Коэффициент

        [DataMember]
        public int Result { get; set; }         // Результат: 0 - проиграл
                                                //            1 - выиграл 
        [DataMember]
        public double Prise { get; set; }      // Сумма выигрыша
    }
}
