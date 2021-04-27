using System.Collections.Generic;
using System.Threading.Tasks;
using blazorAntd.Models;
using blazorAntd.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;
using System;

namespace blazorAntd.Pages.ProductPage.ProductListPage
{

    public partial class ProductListPage
    {
        private int PageIndex = 1;
        private int PageSize = 6;
        private ProductList _data = null;
        [Inject] protected IProductService productService { get; set; }
        [Inject] protected IAppStateService appStateService { get; set; }

        private async Task GetData(int pageIndex, int pageSize)
        {
            appStateService.SetLoading(true);
            await Task.Delay(1000);
            _data = await productService.GetCurrentProductAsync(pageIndex);
            appStateService.SetLoading(false);
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetData(1, 6);
        }

        private async Task OnShowSizeChange(PaginationEventArgs args)
        {
            PageIndex = args.Page;
            PageSize = args.PageSize;
            await GetData(PageIndex, PageSize);
            StateHasChanged();
        }


    }
}
