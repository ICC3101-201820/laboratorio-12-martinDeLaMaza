using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC;

namespace Lab12Form
{
    public delegate void AgregarComidaDelegate(string nombre, int carbohidratos, int proteinas, int grasas);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate CAgregarComida;
        public Form1()
        {
            InitializeComponent();
        }
    }
    
}
