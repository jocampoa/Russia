﻿namespace Russia.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Helpers;
    using Models;

    public class MainViewModel : BaseViewModel
    {
        #region Attibrutes
        private UserLocal user;
        #endregion

        #region Properties
        public TokenResponse Token
        {
            get;
            set;
        }

        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }

        public UserLocal User
        {
            get { return this.user; }
            set { SetValue(ref this.user, value); }
        }
        #endregion

        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public MatchesViewModel Matches
        {
            get;
            set;
        }

        public MyProfileViewModel MyProfile
        {
            get;
            set;
        }

        public ChangePasswordViewModel ChangePassword
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName = "MyProfilePage",
                Title = Languages.MyProfile,
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_insert_chart",
                PageName = "StaticsPage",
                Title = Languages.MyProfile,
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_app",
                PageName = "LoginPage",
                Title = Languages.LogOut,
            });
        }
        #endregion
    }
}
