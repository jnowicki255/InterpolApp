using InterpolApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterpolApp.ViewModels
{
    public class RedNoticesViewModel : BaseViewModel
    {
        private NoticesQuery query;

        public NoticesQuery Query
        {
            get => query;
            set => SetProperty(ref query, value);
        }

        public RedNoticesViewModel()
        {
            Title = "Red Notices";
        }

        public override void OnNavigatedTo()
        {
            LoadRedNotices();
        }

        public override void OnNavigatedFrom()
        {

        }

        private async Task LoadRedNotices()
        {
            IsBusy = true;

            var response = await Client.GetAsync
                ("https://ws-public.interpol.int/notices/v1/red?resultPerPage=5");

            if (response.IsSuccessStatusCode)
            {
                Query = await response.Content.ReadAsAsync<NoticesQuery>();
            }

            IsBusy = false;
        }
    }
}
