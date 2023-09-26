using Microsoft.Maui.Platform;

namespace ShoppingCenterApp {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            //Current.UserAppTheme = AppTheme.Light; 

            MainPage = new AppShell();

            CustomHandler();
        }

        private void CustomHandler() {
            EntryNoBorder();
        }

        private static void EntryNoBorder() {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) => {
#if ANDROID
            //ANDROID
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);

#elif IOS || MACCATALYST
                //IOS || MAC
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#endif
            });
        }
    }
}