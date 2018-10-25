using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC;

namespace Lab12Form
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida comidas;
        public Controlador()
        {
            comidas = new ListaComida();
        }
        public void CAgregarComida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            Comida comida = new Comida( nombre, carbohidratos,proteinas,grasas);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }

    }
}
