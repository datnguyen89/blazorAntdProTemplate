using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Models
{
    public class AppState
    {

        public bool AppLoading { get; private set; }
        public AppState()
        {
            AppLoading = false;
        }
        public event Action OnChangeAppLoading;
        public void SetLoading(bool isLoading)
        {
            AppLoading = isLoading;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChangeAppLoading?.Invoke();
    }
}
