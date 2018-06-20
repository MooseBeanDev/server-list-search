using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressSearch1
{
    public partial class FunctionDialog : Form
    {
        public FunctionDialog()
        {
            InitializeComponent();
        }

        public FunctionDialog(object text)
        {
            InitializeComponent();
            richTextBoxFunction.Text = text.ToString();
        }

        private void richTextBoxFunction_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
