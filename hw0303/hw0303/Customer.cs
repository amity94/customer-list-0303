using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0303
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Adress { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthyear, string adress, int protection)
        {
            this.Id = id;
            this.Name = name;
            this.BirthYear = birthyear;
            this.Adress = adress;
            this.Protection = protection;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Birth Year: {BirthYear}, Adress: {Adress}, Protection: {Protection}, Total Purchases: {TotalPurchases}";
        }
    }
}
