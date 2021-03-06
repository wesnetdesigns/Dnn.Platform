using System.Diagnostics;
using DNNSelenium.Common.BaseClasses;
using OpenQA.Selenium;

namespace DNNSelenium.Common.DemoPages
{
	public class ContactUsPage : BasePage
	{
		public ContactUsPage(IWebDriver driver) : base(driver) { }

		public static string ContactUsUrl = "/ContactUs";

		public static string ContactUsLink = "//div[@id ='nav']//a[contains(@href, 'ContactUs')]";

		public override string PageTitleLabel
		{
			get { return "Contact Us"; }
		}

		public void OpenUsingUrl(string baseUrl)
		{
			Trace.WriteLine(BasePage.TraceLevelPage + "Open '" + PageTitleLabel + "' page:");
			GoToUrl(baseUrl + ContactUsUrl);
		}

		public void OpenUsingLink(string baseUrl)
		{
			GoToUrl(baseUrl);
			Trace.WriteLine(BasePage.TraceLevelPage + "Open '" + PageTitleLabel + "' page:");
			Click(By.XPath(ContactUsLink));
		}
	}
}
