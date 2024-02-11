using EasyAutomation;

var filePath = "C:\\Users\\mame\\Documents\\Projects\\Estudo\\arquivos\\database_customer.csv";

var lines = File.ReadAllLines(filePath);
var checkouts = lines.Skip(1).Select(Checkout.Map).ToList();

using (var checkoutDriver = new CheckoutWebDriver())
{
    foreach (var checkout in checkouts)
    {
        checkoutDriver.SendForm(checkout);
    }

}