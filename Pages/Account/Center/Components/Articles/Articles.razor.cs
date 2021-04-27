using System.Collections.Generic;
using blazorAntd.Models;
using Microsoft.AspNetCore.Components;

namespace blazorAntd.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}