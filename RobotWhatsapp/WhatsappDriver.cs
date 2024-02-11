using EasyAutomationFramework;
using OpenQA.Selenium;
using RobotChatGPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWhatsapp
{
    public class WhatsappDriver : Web
    {

        public void SendMessageText(string message, string to)
        {

            NavigateWhatsSearchUser(to);

            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[1]/div[1]", message)
                .element.SendKeys(OpenQA.Selenium.Keys.Enter);

            CloseBrowser();
        }

        public void SendMessageWithImage(string message, string pathImage, string to)
        {
            NavigateWhatsSearchUser(to);

            AttachmentImage(pathImage);

            AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/div/div[3]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[1]/p", message)
                .element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }


        public void SendMessageWithEmoji(string message, List<string> emojos, string to)
        {
            NavigateWhatsSearchUser(to);

            foreach (string emoji in emojos)
            {
                AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[1]/div[1]", ":");
                AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[1]/div[1]", emoji)
                    .element.SendKeys(OpenQA.Selenium.Keys.Tab);
            }

            SendMesssage(message);


        }


        public void ReadMessage()
        {
            NavigateWhatsSearchUser("@filipebritodev");

            List<string> messageIds = new List<string>();

            var dialog = new DialogoGPT();

            while (true)
            {
                var lastElement = driver.FindElements(By.ClassName("CzM4m"))
                                    .Where(x => x.GetAttribute("data-id").Contains("false")).LastOrDefault();

                if(lastElement != null)
                {
                    var message = lastElement.FindElement(By.ClassName("_21Ahp")).Text;
                    var messageId = lastElement.GetAttribute("data-id");

                    var existingMessage = messageIds.Any(x => x.Equals(messageId));
                    if(!existingMessage) 
                    {
                        messageIds.Add(messageId);

                        dialog.SendMessage(message);

                        var messageGpt = dialog.GetMessageText().Result;

                        SendMesssage(messageGpt);
                    }
                }
            }
        }

        private void NavigateWhatsSearchUser(string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, pathCache: "C:\\Users\\filipe.brito\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            //Search User
            AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]", to)
                .element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        private void AttachmentImage(string pathImage)
        {
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/div/div/span");

            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/span/div/ul/div/div[1]/li/div/input", pathImage);
        }

        private void SendMesssage(string message)
        {
            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div[1]/div[1]", message).element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
    }
}
