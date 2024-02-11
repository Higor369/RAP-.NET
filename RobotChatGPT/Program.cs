
using RobotChatGPT;

var dialogo = new DialogoGPT();

var status = true;
while (status)
{
    Console.WriteLine("Digite uma mensagem");
    var message = Console.ReadLine();
    dialogo.SendMessage(message);
    //var messageBot = await dialogo.GetMessageText();
    //Console.WriteLine(messageBot);

    //if(message.Contains("imagem"))
    //{
        var imageBot = await dialogo.GetMessageImage();
        Console.WriteLine(imageBot);
    //}
}