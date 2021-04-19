using System.Collections.Generic;
using System.Threading.Tasks;
using blazorAntdProTemplate.Models;
using blazorAntdProTemplate.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace blazorAntdProTemplate.Pages.ProductPage.ProductListPage
{

    public partial class ProductListPage
    {
        private ProductList _data = new ProductList();
        //private int _data = 2;
        [Inject] protected IProductService ProductService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _data = await ProductService.GetCurrentProductAsync();
        }
    }
}
