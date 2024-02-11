using RobotChatGPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBlaze
{
    public static class BlazeGPT
    {

        public static async Task<string> GetPalpite(List<Blaze> blazes)
        {
            var dialogo = new DialogoGPT();

            var message = "Qual seria a próxima cor de acordo com a sequência: ";
            foreach (var blaze in blazes.OrderBy(x => x.created_at))
            {
                message += blaze.GetColor() + ",";
            }
            message = message[0..^1] + "?";

            dialogo.SendMessage(message);


            return await dialogo.GetMessageText();
        }
    }
}
