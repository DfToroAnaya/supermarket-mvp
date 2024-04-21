using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlconnectionString;

        public MainPresenter(IMainView mainView, string sqlconnectionString)
        {
            this.mainView = mainView;
            this.sqlconnectionString = sqlconnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProvidersView += ShowProvidersView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlconnectionString);
            new PayModePresenter(view, repository);
        }
        private void ShowProvidersView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new ProvidersRepository(sqlconnectionString);
            new ProvidersPresenter(view, repository);
        }

    }
}
