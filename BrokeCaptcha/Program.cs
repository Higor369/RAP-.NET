

using EasyAutomationFramework;
using TwoCaptcha;

var web = new Web();

var link = "https://www.google.com/recaptcha/api2/demo";
web.StartBrowser();
web.Navigate(link);
web.WaitForLoad();

var captchaKey = web.GetValue(TypeElement.Id, "recaptcha-demo").element.GetAttribute("data-sitekey");

var solver = new Solve();
var resultCode = await solver.ReCaptchaV2Async("5c4ab39fdcfc1ef7c4d0fa637d097870", captchaKey, link);

web.ExecuteScript($"document.querySelector(\"#g-recaptcha-response\").innerHTML='{resultCode.Request}';");

web.Click(TypeElement.Id, "recaptcha-demo-submit");
