using EasyAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWPFBitcoin.Driver
{
    public class MercadoDriver : Web
    {
        public void BuyBitcoin()
        {
            StartBrowser();
            Navigate("https://www.mercadobitcoin.com.br/conta/login/");

            AssignValue(TypeElement.Id, "id_cpfcnpj", "065545645644");
            var elementPassword = AssignValue(TypeElement.Id, "id_password", "065545645644");

            if (elementPassword.Sucesso)
            {
                elementPassword.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }
    }
}
