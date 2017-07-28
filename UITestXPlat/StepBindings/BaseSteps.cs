using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xamarin.UITest;
namespace UITestXPlat.StepBindings
{
    public class BaseSteps
    {
        public IApp app;

        public BaseSteps()
        {
            app = (IApp) FeatureContext.Current["fc_app"];
        }
    }
}
