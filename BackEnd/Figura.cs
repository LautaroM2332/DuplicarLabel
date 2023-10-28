using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public class Figura
    {
        public int PasoH { get; set; }
        public int PosicionH { get; set; }  
        public int PasoV { get; set; }
        public int PosicionV { get; set; }
        
        public Label Figur { get; set; } = new Label();

        public void Mover(int AnchoForm, int AltoForm)
        {
            PosicionH = PosicionH + PasoH;
            Figur.Left = PosicionH;

            PosicionV = PosicionV + PasoV;
            Figur.Top = PosicionV;

            if (PosicionH + Figur.Width >AnchoForm)
            {
                PasoH = -1 * PasoH;
            }
            else if(PosicionH < 0)
            {
                PasoH = -1 * PasoH;
            }

            if (PosicionV + Figur.Height > AltoForm)
            {
                PasoV = -1 * PasoV;
            }
            else if (PosicionV < 0)
            {
                PasoV = -1 * PasoV;
            }

        }


    }
}
