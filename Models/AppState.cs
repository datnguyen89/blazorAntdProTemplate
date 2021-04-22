using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Models
{
    public class AppState
    {
        public int AppLoading { get; private set; }
        public AppState()
        {
            AppLoading = 0;
        }
        public event Action OnChangeAppLoading;
        public void SetLoading(bool isLoading)
        {
            if (isLoading)
            {
                AppLoading += 1;
            }
            else
            {
                AppLoading -= 1;
            }
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChangeAppLoading?.Invoke();
    }
}
