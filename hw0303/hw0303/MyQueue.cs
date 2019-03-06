using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0303
{
    class MyQueue
    {
        private List<Customer> lst = new List<Customer>();

        public void Enqueue(Customer any)
        {
            lst.Insert(lst.Count, any);
        }

        public Customer Dequeue()
        {
            Customer item = lst[0];
            lst.RemoveAt(0);
            return item;
        }

        public void Init(List<Customer> anylst)
        {
            this.lst = anylst;
        }

        public void Clear()
        {
            lst.Clear();
        }

        public Customer WhoIsNext()
        {
            Customer item = lst[0];
            return item;
        }

        public int Count { get { return lst.Count(); } }

        public void SortByProtection()
        {
            lst.Sort(new CustomerSortByProtection());
        }

        public void SortByTotalPurchases()
        {
            lst.Sort(new CustomerSortByTotalPurchases());
        }

        public void SortByBirthYear()
        {
            lst.Sort(new CustomerSortByBirthYear());
        }

        public List<Customer> DequeueCustomers(int any)
        {
            lst.RemoveRange(0, any);

        }

        public void AniRakSheela(Customer any)
        {
            lst.Add(any);
        }

        public Customer DequeueProtectiza()
        {
            Customer any = lst[0];
            any.Protection = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Protection > any.Protection)
                {
                    any.Protection = lst[i].Protection;
                }
                if(lst[i].Protection == any.Protection)
                {
                    return lst[i];
                }
            }
            return any;
        }
    }

    class CustomerSortByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Protection - y.Protection;
        }
    }

    class CustomerSortByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchases - y.TotalPurchases;
        }
    }

    class CustomerSortByBirthYear : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.BirthYear - y.BirthYear;
        }
    }
}
