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
        private int PageIndex = 1;
        private int PageSize = 6;
        private ProductList _data = new ProductList();
        [Inject] protected IProductService ProductService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _data = await ProductService.GetCurrentProductAsync(PageIndex);
        }
        
        private async void PageIndexChanged(PaginationEventArgs args)
        {
            PageIndex = args.Page;
            _data = await ProductService.GetCurrentProductAsync(PageIndex);
            System.Threading.Thread.Sleep(2000); // Test loading
            StateHasChanged();
        }
    }
}
