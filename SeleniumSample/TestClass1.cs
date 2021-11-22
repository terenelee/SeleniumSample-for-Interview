using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumSample
{
	[TestClass]
	public class TestClass1
	{
		[TestMethod]
		public void VerifyImpartnerInterview()
		{
			ChromeDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
		



			// end chromedriver.exe process and browser.
			driver.Dispose();  
			driver.Quit();	
		}

	}
}
