using System.Collections.Generic;
using blazorAntdProTemplate.Models;
using Microsoft.AspNetCore.Components;

namespace blazorAntdProTemplate.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}