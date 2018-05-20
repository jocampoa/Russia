[assembly: Xamarin.Forms.Dependency(typeof(Russia.Droid.Implementations.RegistrationDevice))]

namespace Russia.Droid.Implementations
{
    using Gcm.Client;
    using Android.Util;
    using Interfaces;

    public class RegistrationDevice : IRegisterDevice
    {
        #region Methods
        public void RegisterDevice()
        {
            var mainActivity = MainActivity.GetInstance();
            GcmClient.CheckDevice(mainActivity);
            GcmClient.CheckManifest(mainActivity);

            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(mainActivity, Droid.Constants.SenderID);
        }
        #endregion
    }
}