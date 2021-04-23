using System.Collections.Generic;
using System.Threading.Tasks;
using blazorAntdProTemplate.Models;
using blazorAntdProTemplate.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;
using System;

namespace blazorAntdProTemplate.Pages.ProductPage.ProductListPage
{

    public partial class ProductListPage
    {
        private int PageIndex = 1;
        private int PageSize = 6;
        private ProductList _data = new ProductList();
        [Inject] protected IProductService ProductService { get; set; }
        [Inject] protected AppState appState { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            appState.SetLoading(true);
            _data = await ProductService.GetCurrentProductAsync(PageIndex);
            System.Threading.Thread.Sleep(1000);
            appState.SetLoading(false);
        }

        private async void OnShowSizeChange(PaginationEventArgs args)
        {
            appState.SetLoading(true);
            PageIndex = args.Page;
            PageSize = args.PageSize;
            _data = await ProductService.GetCurrentProductAsync(PageIndex);
            System.Threading.Thread.Sleep(1000);
            appState.SetLoading(false);
            StateHasChanged();
        }


    }
}
