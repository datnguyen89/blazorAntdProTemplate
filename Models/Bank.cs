using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Models
{
    public class Bank
    {
        public int Id { set; get; }
        public string BankName { set; get; }
        public string BankCode { set; get; }
        public Bank(int id, string bankName, string bankCode)
        {
            Id = id;
            BankName = bankName;
            BankCode = bankCode;
        }
    }
}
