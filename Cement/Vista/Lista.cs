using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cement.Vista
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            var aux = new USUARIOS();
            aux.listar(datausuarios);
            datausuarios.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Esta seguro que desea cerrar el Formulario?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        //para abrir el formulario una sola vez
        private static Lista m_FormDefInstance;
        public static Lista DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Lista();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
    }
}
