namespace EasyAutomation;
public  class Checkout
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Payment { get; set; }
    public string Namecard { get; set; }
    public string Creditcard { get; set; }
    public string Expirition { get; set; }
    public string Cvv { get; set; }


    public static Checkout Map(string line)
    {
        var values = line.Split(',');
        return new Checkout
        {
            Firstname = values[0],
            Lastname = values[1],
            Username = values[2],
            Email = values[3],
            Address = values[4],
            Country = values[6],
            State = values[7],
            Zip = values[8],
            Payment = values[9],
            Namecard = values[10],
            Creditcard = values[11],
            Expirition = values[12],
            Cvv = values[13],
        };
    }
}
