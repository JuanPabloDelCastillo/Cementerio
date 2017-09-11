using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cement;
using Entidades;

namespace Cement
{
    public partial class Confidencial : Form
    {
        public Confidencial()
        {
            InitializeComponent();
        }
        Encriptamiento encri = new Encriptamiento();

        private void Confidencial_Load(object sender, EventArgs e)
        {
            var aux = new USUARIOS();
            aux.listar(datausuarios2);
            datausuarios2.AllowUserToAddRows = false;

            txtcodigo2.Text = datausuarios2.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre2.Text = datausuarios2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtclave2.Text = encri.DecryptKey(datausuarios2.CurrentRow.Cells["CLAVE"].Value.ToString());
            txttipo.Text = datausuarios2.CurrentRow.Cells["TIPO"].Value.ToString();
        }

        private void datausuarios2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo2.Text = datausuarios2.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre2.Text = datausuarios2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtclave2.Text = encri.DecryptKey(datausuarios2.CurrentRow.Cells["CLAVE"].Value.ToString());
            txttipo.Text = datausuarios2.CurrentRow.Cells["TIPO"].Value.ToString();
            
        }

        private void datausuarios2_KeyDown(object sender, KeyEventArgs e)
        {
            txtcodigo2.Text = datausuarios2.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre2.Text = datausuarios2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtclave2.Text = encri.DecryptKey(datausuarios2.CurrentRow.Cells["CLAVE"].Value.ToString());
            txttipo.Text = datausuarios2.CurrentRow.Cells["TIPO"].Value.ToString();
        }

        private void datausuarios2_MouseClick(object sender, MouseEventArgs e)
        {
            txtcodigo2.Text = datausuarios2.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtnombre2.Text = datausuarios2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtclave2.Text = encri.DecryptKey(datausuarios2.CurrentRow.Cells["CLAVE"].Value.ToString());
            txttipo.Text = datausuarios2.CurrentRow.Cells["TIPO"].Value.ToString();
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
        private static Confidencial m_FormDefInstance;
        public static Confidencial DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Confidencial();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        
    }
}
