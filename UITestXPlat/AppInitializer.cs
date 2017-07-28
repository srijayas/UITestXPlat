using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestXPlat
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                string ass = System.Reflection.Assembly.GetExecutingAssembly().Location;
                return ConfigureApp
                    .Android.ApkFile(System.IO.Path.GetDirectoryName(ass) + "/Binary/com.xamarin.samples.taskydroidnew.exampleapp.apk")
                    .StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
               
                    
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

