using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using NUnit.Framework;
using TechTalk.SpecFlow;
namespace UITestXPlat.Features
{
    
   [TestFixture()]
    public class BaseFeature
    {

        protected Platform _platform;
        protected string _deviceName;
        public BaseFeature()//Platform platform)
        {
            this._platform = Platform.Android;
            this._deviceName = "";
        }
        //[SetUp]
        [TechTalk.SpecFlow.BeforeTestRun()]
        public void BeforeFeatureTestRun()
        {
            IApp app =  AppInitializer.StartApp(this._platform);
            FeatureContext.Current.Add("fc_app", app);
            FeatureContext.Current.Add("fc_devicename", this._deviceName);
        }

    }
}
