namespace Russia.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Models;
    using Russia.Helpers;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MatchesViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        private bool isRefreshing;
        #endregion

        #region Attributes
        private ObservableCollection<Match> matches;
        private ObservableCollection<Match> pastMatches;
        private List<Match> myMatches;
        private string filter;
        #endregion

        #region Properties
        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }

        public ObservableCollection<Match> Matches
        {
            get { return this.matches; }
            set { this.SetValue(ref this.matches, value); }
        }

        public ObservableCollection<Match> PastMatches
        {
            get { return this.pastMatches; }
            set { this.SetValue(ref this.pastMatches, value); }
        }

        public string Filter
        {
            get { return this.filter; }
            set
            {    
                this.SetValue(ref this.filter, value);
                this.Search();
            }
        }
        #endregion

        #region Constructors
        public MatchesViewModel()
        {
            this.apiService = new ApiService();
            this.LoadMatches();
        }
        #endregion

        #region Methods
        private async void LoadMatches()
        {
            this.IsRefreshing = true;

            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    connection.Message,
                    Languages.Accept);
                return;
            }

            var apiSecurity = Application.Current.Resources["APISecurity"].ToString();
            var response = await this.apiService.GetList<Match>(
                apiSecurity,
                "/api",
                "/Matches",
                MainViewModel.GetInstance().Token.TokenType,
                MainViewModel.GetInstance().Token.AccessToken);

            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    response.Message,
                    Languages.Accept);
                return;
            }

            this.myMatches = (List<Match>)response.Result;
            foreach (var match in this.myMatches)
            {
                match.DateTime = match.DateTime.ToLocalTime();
            }

            this.Matches = new ObservableCollection<Match>(this.myMatches.Where(m => m.StatusMatchId == 1));
            this.PastMatches = new ObservableCollection<Match>(this.myMatches.Where(m => m.StatusMatchId != 1));
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadMatches);
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(Search);
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(this.Filter))
            {
                this.Matches = new ObservableCollection<Match>(this.myMatches.Where(m => m.StatusMatchId == 1));
                this.PastMatches = new ObservableCollection<Match>(this.myMatches.Where(m => m.StatusMatchId != 1));
            }
            else
            {
                this.Matches = new ObservableCollection<Match>(
                    this.myMatches.Where(m => (m.Local.Name.ToLower().Contains(this.Filter.ToLower()) || 
                                         m.Visitor.Name.ToLower().Contains(this.Filter.ToLower())) &&
                                         m.StatusMatchId == 1));
                this.PastMatches = new ObservableCollection<Match>(
                    this.myMatches.Where(m => (m.Local.Name.ToLower().Contains(this.Filter.ToLower()) ||
                                         m.Visitor.Name.ToLower().Contains(this.Filter.ToLower())) &&
                                         m.StatusMatchId != 1));
            }
        }
        #endregion
    }
}
