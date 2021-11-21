using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coche
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public string placa { get; set; }
        public int km { get; set; }

        public void arrancar(int kmHora)
        {
            km = kmHora;
        }
        public void frenar()
        {
            km = 0;
        }
        public void avanzar()
        {
            km++;
        }

    }
}
