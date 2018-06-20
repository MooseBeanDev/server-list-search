using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Management.Automation;
using System.Collections.ObjectModel;

/* This form will allow a user to search the ServerList for an IP Address.
 * It will return the name of the server the IP is connected to.
 * 
 * Benjamin McCown 02/09/2018
 */


namespace AddressSearch1
{
    public partial class Form1 : Form
    {
        // Creates a single DatabaseHandler.cs to use throughout.
        DatabaseHandler db;

        // Member variables
        private String ipAddress = "";
        private int[] activeCell = new int[2];
        private ColumnHandler colhdl = ColumnHandler.Instance;
        private int searchConditional = 0;
        private int searchColumn = 0;
        private FunctionDialog fnctDialog;

        public bool[] enabledColumns = new bool[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Attaches db to a new instance.
            db = new DatabaseHandler();
            colhdl.SetForm(this);
            UpdateColumns();
            comboBoxCondition.SelectedIndex = 0;
            comboBoxSearchColumn.SelectedIndex = 0;
            ResetUI();

            // Sets active cell to 0, 0 on load.
            // This is for entering data and clearing it.
            activeCell[0] = 0;
            activeCell[1] = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ipAddress = textboxAddress.Text;
        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void textboxAddress_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ExecuteSearch();
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearResults();
            ResetUI();
        }

        private void ExecuteSearch()
        {
            String command = BuildCommand(ipAddress, searchColumn, searchConditional);
            db.OpenConnection();
            db.ExecuteQuery(command);

            if (db.ReaderHasRows())
            {
                while (db.ReadDatabase())
                {
                    int columnCounter = 0;
                    // Adds the results to the data grid. Has to parse through the result and add to each cell separately.
                    dataGridResults.Rows.Add(1);
                    for (int i = 0; i < colhdl.GetColumnCount(); i++)
                    {
                        if (dataGridResults.Rows.Count > 0)
                        {
                            db.AddResult(db.GetColumnValue(i).ToString());
                            if (colhdl.GetColumnEnabled(i))
                            {
                                dataGridResults.CurrentCell = dataGridResults[activeCell[0], activeCell[1]];
                                dataGridResults.CurrentCell.Value = db.GetColumnValue(i);
                                columnCounter++;
                                if (columnCounter < colhdl.GetActiveColumnCount())
                                {
                                    activeCell[0]++;
                                }
                                else
                                {
                                    activeCell[0] = 0;
                                }
                            }
                        }             
                    }
                    activeCell[1]++;
                }
            }
            db.CloseConnection();
        }

        private String BuildCommand(String ipadd, int searchColumn, int searchType)
        {
            String prefix = "SELECT ";
            String tempColumn = "tblIP.Address";
            String tempTypeTrue = " LIKE '%";
            String tempTypeTrue2 = "%'";
            String tempTypeFalse = "='";
            String tempTypeFalse2 = "'";
            String middle = " FROM tblHardware INNER JOIN tblIP ON tblHardware.ID=tblIP.ID WHERE ";
            String suffix = " AND 'Retired' NOT IN (tblHardware.Status);";
            String finalcommand = "";
            String criteria= "";

            if (searchColumn == 0)
            {
                tempColumn = "tblIP.Address";
                middle = String.Concat(middle, tempColumn);
            }
            else if (searchColumn == 1)
            {
                tempColumn = "tblHardware.Name";
                middle = String.Concat(middle, tempColumn);
            }
            else if (searchColumn == 2)
            {
                tempColumn = "tblHardware.PrimaryAdmin";
                middle = String.Concat(middle, tempColumn);
            }
            else if (searchColumn == 3)
            {
                tempColumn = "tblHardware.SecondaryAdmin";
                middle = String.Concat(middle, tempColumn);
            }

            if (searchType == 0)
            {
                middle = String.Concat(middle, tempTypeTrue);
                middle = String.Concat(middle, ipadd);
                middle = String.Concat(middle, tempTypeTrue2);
            } else if (searchType == 1)
            {
                middle = String.Concat(middle, tempTypeFalse);
                middle = String.Concat(middle, ipadd);
                middle = String.Concat(middle, tempTypeFalse2);
            }

            for (int i = 0; i < colhdl.GetColumnCount(); i++)
            {
                criteria = String.Concat(criteria, colhdl.ColumnNameSQL[i]);
                criteria = String.Concat(criteria, ", ");
            }

            if (criteria == "")
            {
                MessageBox.Show("You haven't selected any columns.");
            }

            int positionToDelete = criteria.Length - 2;
            criteria = criteria.Remove(positionToDelete, 2);
            finalcommand = String.Concat(prefix, criteria);
            finalcommand = String.Concat(finalcommand, middle);
            finalcommand = String.Concat(finalcommand, suffix);
            //richTextBoxFunction.Text = finalcommand;
            return finalcommand;
        }

        private void buttonColumns_Click(object sender, EventArgs e)
        {
            ColumnDialog colDialog = new ColumnDialog();
            colDialog.Show();
        }

        private void ResetUI()
        {
            labelOpenDetails.Show();
            buttonFunction.Hide();
            richTextBoxFunction.Text = "Description/Notes";
        }

        public void UpdateColumns()
        {
            ClearResults();

            List<String> colheaders = new List<string>();
            int currentColumnCount = dataGridResults.ColumnCount;

            for (int i = 0; i < colhdl.GetColumnCount(); i++)
            {
                if (colhdl.GetColumnEnabled(i))
                {
                    ColumnHandler.ColumnName toAdd = (ColumnHandler.ColumnName)i;
                    colheaders.Add(toAdd.ToString());
                }
            }

            dataGridResults.Columns.Clear();

            foreach (String name in colheaders)
            {
                dataGridResults.Columns.Add(name, name);
            }

            foreach (DataGridViewColumn column in dataGridResults.Columns)
            {
                if (column.Name != "Name" && column.Name != "Address")
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                column.ReadOnly = true;
            }
        }

        private void ClearResults()
        {
            for (int r = 0; r < dataGridResults.RowCount; r++)
            {
                for (int c = 0; c < dataGridResults.ColumnCount; c++)
                {
                    dataGridResults.CurrentCell = dataGridResults[c, r];
                    dataGridResults.CurrentCell.Value = null;
                }
            }

            dataGridResults.Rows.Clear();
            activeCell[1] = 0;
        }

        private void comboBoxCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCondition.SelectedIndex == 0)
            {
                searchConditional = 0;
            }
            else if (comboBoxCondition.SelectedIndex == 1)
            {
                searchConditional = 1;
            }
        }

        private void comboBoxCondition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchColumn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSearchColumn.SelectedIndex == 0)
            {
                searchColumn = 0;
            }
            else if (comboBoxSearchColumn.SelectedIndex == 1)
            {
                searchColumn = 1;
            }
            else if (comboBoxSearchColumn.SelectedIndex == 2)
            {
                searchColumn = 2;
            }
            else if (comboBoxSearchColumn.SelectedIndex == 3)
            {
                searchColumn = 3;
            }
        }

        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetUI();
        }

        private void buttonFunction_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridResults.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (fnctDialog != null)
                {
                    fnctDialog.Close();
                }
                fnctDialog = new FunctionDialog(db.GetValueAt(dataGridResults.SelectedRows[0].Index, (int)ColumnHandler.ColumnName.Function));
                fnctDialog.Show();
            }
        }

        private void dataGridResults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelOpenDetails.Hide();
            buttonFunction.Show();
            richTextBoxFunction.Text = db.GetValueAt(dataGridResults.SelectedRows[0].Index, (int)ColumnHandler.ColumnName.Function);
        }

        private void dataGridResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetUI();
        }

        private void dataGridResults_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridResults_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridResults_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                int selectedRowCount = dataGridResults.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    richTextBoxFunction.Text = db.GetValueAt(dataGridResults.SelectedRows[0].Index, (int)ColumnHandler.ColumnName.Function);
                }
            }
        }

        private void buttonRDP_Click(object sender, EventArgs e)
        {
            String cmdargs = "/v: ";
            String servername = "";
            String suffix = " /prompt";
            int selectedRowCount = dataGridResults.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                servername = db.GetValueAt(dataGridResults.SelectedRows[0].Index, (int)ColumnHandler.ColumnName.Name);
            }

            if (servername != "")
            {
                cmdargs = String.Concat(cmdargs, servername);
                cmdargs = String.Concat(cmdargs, suffix);
                System.Diagnostics.Process.Start("mstsc.exe", cmdargs);
            }
            else
            {
                MessageBox.Show("You do not have a server selected.");
            }
        }
    }
}
