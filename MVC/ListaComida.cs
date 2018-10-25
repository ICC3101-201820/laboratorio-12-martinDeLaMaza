 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class ListaComida
    {
        List <Comida> comidas;
        public ListaComida()
        {
            comidas = new List<Comida>();
        }
        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {

        }
    }
}
