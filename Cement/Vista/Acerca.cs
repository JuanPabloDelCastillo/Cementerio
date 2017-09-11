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
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        //para abrir el formulario una sola vez
        private static Acerca m_FormDefInstance;
        public static Acerca DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Acerca();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
    }
}
