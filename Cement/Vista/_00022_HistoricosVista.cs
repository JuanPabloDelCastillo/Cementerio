using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Cement.Vista
{
    public partial class _00022_HistoricosVista : Form
    {
        private Causante objCausante;

        public _00022_HistoricosVista()
        {
            InitializeComponent();
        }

        public _00022_HistoricosVista(Causante objCausante)
        {
            this.objCausante = objCausante;
        }
    }
}
