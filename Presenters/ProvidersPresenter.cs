using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;


namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSeletedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);

            loadAllProvidersList();

            this.view.Show();

        }
        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            var provider = new  ProvidersModel();
            provider.Id = Convert.ToInt32(view.ProviderId);
            provider.Name = view.ProviderName;
            provider.Observation = view.ProviderObservation;

            try
            {
                new Common.ModelDataValidation().Validate(provider);

                if (view.IsEdit)
                {
                    repository.Edit(provider);
                    view.Menssage = "Provider edited successfuly";
                }
                else
                {
                    repository.Add(provider);
                    view.Menssage = "Provider added successfuly";
                }
                view.IsSuccesful = true;
                loadAllProvidersList();
                CleanViewFields();


            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Menssage = ex.Message;
            }


        }
        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }


        private void DeleteSeletedProviders(object? sender, EventArgs e)
        {
            var provider = (ProvidersModel)providersBindingSource.Current;

            view.ProviderId = provider.Id.ToString();
            view.ProviderName = provider.Name;
            view.ProviderObservation = provider.Observation;

            view.IsEdit = true;

            try
            {
                var providerModel = (ProvidersModel)providersBindingSource.Current;

                repository.Delete(provider.Id);
                view.IsSuccesful = true;
                view.Menssage = "Provider deleted successfully";
                loadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Menssage = "An error ocurred, could not delete provider";
            }


        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);

            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }




    }
}
