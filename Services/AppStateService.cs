using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorAntd.Models;

namespace blazorAntd.Services
{
    public interface IAppStateService
    {
        void SetLoading(bool isLoading);
        bool IsLoading { get; }
        event Action OnChangeAppLoading;
    }
    public class AppStateService : IAppStateService
    {        
        public AppState appState = new AppState();
        public event Action OnChangeAppLoading;
        private void NotifyStateChanged() => OnChangeAppLoading?.Invoke();
        public void SetLoading(bool isLoading)
        {
            if (isLoading)
            {
                appState.AppLoading += 1;
            }
            else
            {
                appState.AppLoading -= 1;
            }
            NotifyStateChanged();
        }
        
        public bool IsLoading
        {
            get
            {
                return appState.AppLoading > 0;
            }
        }
    }
}
