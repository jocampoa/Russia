namespace Russia.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }

        public static string EmailPlaceHolder
        {
            get { return Resource.EmailPlaceHolder; }
        }

        public static string PasswordPlaceHolder
        {
            get { return Resource.PasswordPlaceHolder; }
        }

        public static string Forgot
        {
            get { return Resource.Forgot; }
        }

        public static string EMail
        {
            get { return Resource.EMail; }
        }

        public static string Password
        {
            get { return Resource.Password; }
        }

        public static string Login
        {
            get { return Resource.Login; }
        }

        public static string Register
        {
            get { return Resource.Register; }
        }

        public static string PasswordValidation
        {
            get { return Resource.PasswordValidation; }
        }

        public static string Incorrect
        {
            get { return Resource.Incorrect; }
        }

        //public static string Bibles
        //{
        //    get { return Resource.Bibles; }
        //}

        //public static string Bible
        //{
        //    get { return Resource.Bible; }
        //}

        //public static string Book
        //{
        //    get { return Resource.Book; }
        //}

        public static string Menu
        {
            get { return Resource.Menu; }
        }

        public static string MyProfile
        {
            get { return Resource.MyProfile; }
        }

        //public static string Statistics
        //{
        //    get { return Resource.Statistics; }
        //}

        public static string LogOut
        {
            get { return Resource.LogOut; }
        }

        public static string SomethingWrong
        {
            get { return Resource.SomethingWrong; }
        }

        public static string RegisterTitle
        {
            get { return Resource.RegisterTitle; }
        }

        public static string ChangeImage
        {
            get { return Resource.ChangeImage; }
        }

        public static string FirstNameLabel
        {
            get { return Resource.FirstNameLabel; }
        }

        public static string FirstNamePlaceHolder
        {
            get { return Resource.FirstNamePlaceHolder; }
        }

        public static string FirstNameValidation
        {
            get { return Resource.FirstNameValidation; }
        }

        public static string LastNameLabel
        {
            get { return Resource.LastNameLabel; }
        }

        public static string LastNamePlaceHolder
        {
            get { return Resource.LastNamePlaceHolder; }
        }

        public static string LastNameValidation
        {
            get { return Resource.LastNameValidation; }
        }

        public static string PhoneLabel
        {
            get { return Resource.PhoneLabel; }
        }

        public static string PhonePlaceHolder
        {
            get { return Resource.PhonePlaceHolder; }
        }

        public static string PhoneValidation
        {
            get { return Resource.PhoneValidation; }
        }

        public static string ConfirmLabel
        {
            get { return Resource.ConfirmLabel; }
        }

        public static string ConfirmPlaceHolder
        {
            get { return Resource.ConfirmPlaceHolder; }
        }

        public static string ConfirmValidation
        {
            get { return Resource.ConfirmValidation; }
        }

        public static string EmailValidation2
        {
            get { return Resource.EmailValidation2; }
        }

        public static string PasswordValidation2
        {
            get { return Resource.PasswordValidation2; }
        }

        public static string ConfirmValidation2
        {
            get { return Resource.ConfirmValidation2; }
        }

        public static string UserRegisteredMessage
        {
            get { return Resource.UserRegisteredMessage; }
        }

        public static string SourceImageQuestion
        {
            get { return Resource.SourceImageQuestion; }
        }

        public static string Cancel
        {
            get { return Resource.Cancel; }
        }

        public static string FromGallery
        {
            get { return Resource.FromGallery; }
        }

        public static string FromCamera
        {
            get { return Resource.FromCamera; }
        }

        public static string Save
        {
            get { return Resource.Save; }
        }

        public static string ChangePassword
        {
            get { return Resource.ChangePassword; }
        }

        public static string CurrentPassword
        {
            get { return Resource.CurrentPassword; }
        }

        public static string CurrentPasswordPlaceHolder
        {
            get { return Resource.CurrentPasswordPlaceHolder; }
        }

        public static string NewPassword
        {
            get { return Resource.NewPassword; }
        }

        public static string NewPasswordPlaceHolder
        {
            get { return Resource.NewPasswordPlaceHolder; }
        }

        public static string ConnectionError1
        {
            get { return Resource.ConnectionError1; }
        }

        public static string ConnectionError2
        {
            get { return Resource.ConnectionError2; }
        }

        public static string ChangePasswordConfirm
        {
            get { return Resource.ChangePasswordConfirm; }
        }

        public static string PasswordError
        {
            get { return Resource.PasswordError; }
        }

        public static string ErrorChangingPassword
        {
            get { return Resource.ErrorChangingPassword; }
        }

        public static string PleaseWait
        {
            get { return Resource.PleaseWait; }
        }

        public static string Boards
        {
            get { return Resource.Boards; }
        }

        public static string Predictions
        {
            get { return Resource.Predictions; }
        }

        public static string Ranking
        {
            get { return Resource.Ranking; }
        }

        public static string Instructions
        {
            get { return Resource.Instructions; }
        }

        public static string MyHits
        {
            get { return Resource.MyHits; }
        }

        public static string Matches
        {
            get { return Resource.Matches; }
        }

        public static string NoUserLocalMessage
        {
            get { return Resource.NoUserLocalMessage; }
        }

        public static string Search
        {
            get { return Resource.Search; }
        }

        public static string BoardInstructions
        {
            get { return Resource.BoardInstructions; }
        }

        public static string YourCurrentBoards
        {
            get { return Resource.YourCurrentBoards; }
        }

        public static string NoVerified
        {
            get { return Resource.NoVerified; }
        }

        public static string AddBoard
        {
            get { return Resource.AddBoard; }
        }

        public static string AddBoardInstructions
        {
            get { return Resource.AddBoardInstructions; }
        }

        public static string NoDepositImageMessage
        {
            get { return Resource.NoDepositImageMessage; }
        }

        public static string DepositConfirmationMessage
        {
            get { return Resource.DepositConfirmationMessage; }
        }

        public static string ContactAdmin
        {
            get { return Resource.ContactAdmin; }
        }

        public static string Board
        {
            get { return Resource.Board; }
        }

        public static string SelectBoard
        {
            get { return Resource.SelectBoard; }
        }

        public static string PredictionInstructions
        {
            get { return Resource.PredictionInstructions; }
        }

        public static string CupProgramming
        {
            get { return Resource.CupProgramming; }
        }

        public static string PendingMatches
        {
            get { return Resource.PendingMatches; }
        }

        public static string PastMatches
        {
            get { return Resource.PastMatches; }
        }

        public static string SavePredictions
        {
            get { return Resource.SavePredictions; }
        }

        public static string SelectBoardValidation
        {
            get { return Resource.SelectBoardValidation; }
        }

        public static string EditPrediction
        {
            get { return Resource.EditPrediction; }
        }

        public static string LocalGoalsValidation
        {
            get { return Resource.LocalGoalsValidation; }
        }

        public static string VisitorGoalsValidation
        {
            get { return Resource.VisitorGoalsValidation; }
        }

        public static string ErrorSavingPredictionMessage
        {
            get { return Resource.ErrorSavingPredictionMessage; }
        }

        public static string User
        {
            get { return Resource.User; }
        }

        public static string Image
        {
            get { return Resource.Image; }
        }

        public static string Points
        {
            get { return Resource.Points; }
        }

        public static string MyPrediction
        {
            get { return Resource.MyPrediction; }
        }
    }
}
