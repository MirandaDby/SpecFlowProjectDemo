using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Tools
{

    public static class Singlton
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            { 
                DirectoryInfo rootDir = Directory.GetParent(Environment.CurrentDirectory);
                string root = rootDir.Parent.Parent.FullName;
                string drivePath = root + @"\Drivers";
                if (_driver == null)
                {
                    ChromeDriverService defaultService = ChromeDriverService.CreateDefaultService(drivePath);
                    defaultService.HideCommandPromptWindow = true;
                    _driver = (IWebDriver)new ChromeDriver(defaultService);
                    _driver.Manage().Window.Maximize();
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                }

                return _driver;
            }

        }

        public static void SetDriver(IWebDriver driver)
        {
            _driver = driver;
        }

        public static void Close()
        {

            if (_driver != null)
            {

                Driver.Close();
                SetDriver(null);
            }
        }

    }
}
