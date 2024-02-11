using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBlaze
{
    public class Blaze
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public int color { get; set; }
        public int roll { get; set; }
        public string server_seed { get; set; }
        public string GetColor()
        {
            switch (color)
            {
                case (int)EnumColor.PRETO:
                    return "PRETO";

                case (int)EnumColor.VERMELHO:
                    return "VERMELHO";

                case (int)EnumColor.BRANCO:
                    return "BRANCO";
            }

            return null;
        }


    }
}
