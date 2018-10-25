using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Comida
    {
        string nombre;
        int carbohidratos, proteinas, grasas;        public Comida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.proteinas = proteinas;
            this.grasas = grasas;
        }        public void Calorias()
        {
            //(4 ∗ carbohidratos + 4 ∗proteinas + 9 ∗ grasas
            int x = 4 * carbohidratos + 4 * proteinas + 9 * grasas;
        }
    }
}
