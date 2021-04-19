using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Avatar { set; get; }
    }
    public class Support
    {
        public string Url { set; get; }
        public string Text { set; get; }
    }
    public class ProductList
    {
        public int Page { set; get; }
        public int PerPage { set; get; }
        public int Total { set; get; }
        public int TotalPage { set; get; }
        public Product[] Data { set; get; } = Array.Empty<Product>();
        public Support Support { set; get; }
    }
}
