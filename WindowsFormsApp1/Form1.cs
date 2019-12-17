using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region [-ctor-]
        public Form1()
        {
           
            InitializeComponent();
        } 
        #endregion
        VeiwModel.Northweiwmodel Ref_northweiwmodel;
        private void button1_Click(object sender, EventArgs e)
        {
            Ref_northweiwmodel = new VeiwModel.Northweiwmodel();
            dataGridView1.DataSource

                = Ref_northweiwmodel.GetRelationEmpoloyeeandcustomer
                (Convert.ToInt32(txtid.Text));

        }
    }
}
