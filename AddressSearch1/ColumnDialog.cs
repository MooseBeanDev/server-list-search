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
    public partial class ColumnDialog : Form
    {
        ColumnHandler colhdl = ColumnHandler.Instance;

        public ColumnDialog()
        {
            InitializeComponent();
        }

        private void checkListBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateColumnHandler();
        }

        private void SetColumnCheckBoxes()
        {
            for (int i = 0; i < colhdl.GetColumnCount(); i++)
            {
                if (colhdl.GetColumnEnabled(i))
                {
                    checkListBoxColumns.SetItemChecked(i, true);
                }
            }
        }

        private void UpdateColumnHandler()
        {
            for (int i = 0; i < colhdl.GetColumnCount(); i++)
            {
                colhdl.SetColumnEnabled(i, checkListBoxColumns.GetItemChecked(i));
            }
        }

        private void ColumnDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateColumnHandler();
            colhdl.UpdateColumns();
        }

        private void ColumnDialog_Load(object sender, EventArgs e)
        {
            SetColumnCheckBoxes();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UpdateColumnHandler();
            colhdl.UpdateColumns();
            this.Close();
        }
    }
}
