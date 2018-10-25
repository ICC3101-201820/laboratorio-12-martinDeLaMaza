using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class Comida
    {
        public string nombre;
        public int carbohidratos, proteinas, grasas;        public Comida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.proteinas = proteinas;
            this.grasas = grasas;
        }        public int Calorias()
        {
            //(4 ∗ carbohidratos + 4 ∗proteinas + 9 ∗ grasas
            int x = 4 * carbohidratos + 4 * proteinas + 9 * grasas;
            return x;
        }        public string DatosComida(Comida c)
        {
            return ($"{c.nombre} (carbohidratos: {c.carbohidratos}, proteinas: {c.proteinas}, grasas: {c.grasas}, calorias: {c.Calorias()})");
        }
    }
}
