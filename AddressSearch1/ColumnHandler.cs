using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressSearch1
{
    public sealed class ColumnHandler
    {
        static readonly ColumnHandler _instance = new ColumnHandler();

        private Form1 form1;
        private bool[] columnList = new bool[10];
        public enum ColumnName {Name, Address, Domain, Function, Type, OS, NetworkDescription, PrimaryAddress,
        PrimaryAdmin, SecondaryAdmin};
        public String[] ColumnNameSQL = new String[10];
        
        private ColumnName columnNames;
        private int columnCount = 0;

        public static ColumnHandler Instance
        {
            get { return _instance; }
        }

        private ColumnHandler()
        {
            ColumnNameSQL[0] = "tblHardware.[Name]";
            ColumnNameSQL[1] = "tblIP.[Address]";
            ColumnNameSQL[2] = "tblHardware.[Domain]";
            ColumnNameSQL[3] = "tblHardware.[Function]";
            ColumnNameSQL[4] = "tblHardware.[Type]";
            ColumnNameSQL[5] = "tblHardware.[OS]";
            ColumnNameSQL[6] = "tblIP.[Description]";
            ColumnNameSQL[7] = "tblIP.[Primary]";
            ColumnNameSQL[8] = "tblHardware.[PrimaryAdmin]";
            ColumnNameSQL[9] = "tblHardware.[SecondaryAdmin]";

            columnCount = Enum.GetNames(typeof(ColumnName)).Length;

            for (int i = 0; i < columnCount; i++)
            {
                columnList[i] = false;
            }

            SetColumnEnabled((int)ColumnName.Name, true);
            SetColumnEnabled((int)ColumnName.Address, true);
            SetColumnEnabled((int)ColumnName.NetworkDescription, true);
            SetColumnEnabled((int)ColumnName.PrimaryAddress, true);
            SetColumnEnabled((int)ColumnName.PrimaryAdmin, true);
        }

        public int GetColumnCount()
        {
            return columnCount;
        }

        public int GetActiveColumnCount()
        {
            int counter = 0;
            for (int i = 0; i < GetColumnCount(); i++)
            {
                if (GetColumnEnabled(i))
                {
                    counter++;
                }
            }

            return counter;
        }

        public bool GetColumnEnabled(int col)
        {
            return columnList[col];
        }

        public void SetColumnEnabled(int col, bool enable)
        {
            columnList[col] = enable;
        }

        public void ShowDebugWindow()
        {
            String wholemessage = "";
            for (int i = 0; i < GetColumnCount(); i++)
            {
                String message = "Column " + i + " is set to " + GetColumnEnabled(i) + "\n";
                wholemessage = String.Concat(wholemessage, message);
            }

            MessageBox.Show(wholemessage);
        }

        public void UpdateColumns()
        {
            form1.UpdateColumns();
        }

        public void SetForm(Form1 form)
        {
            form1 = form;
        }

    }
}
