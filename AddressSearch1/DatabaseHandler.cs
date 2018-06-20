using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

/* This class exists to abstract the database functions used to program in Visual C#
 * Object is created either globally or locally in another class.
 * Inteneded usage:
 * Connection is opened. Query is executed. Reader is processed. Connection is closed.
 * 
 * Benjamin McCown 02/09/2018
 */

namespace AddressSearch1
{
    public class DatabaseHandler
    {
        // Member Variables
        private OleDbConnection oCon;
        public OleDbDataReader oDR;

        private List<String> resultsList = new List<String>();

        // Constructor. Creates the connection.
        public DatabaseHandler()
        {
            //oCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb");
            oCon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\\\pathto\\data.mdb");
        }

        // Opens the connection, returns error if there's a problem.
        public void OpenConnection()
        {
            try
            {
                oCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reads a query and executes it in the database, feeds data to the reader.
        public void ExecuteQuery(String query)
        {
            OleDbCommand oCmd = oCon.CreateCommand();
            oCmd.CommandText = query;
            oCmd.Connection = oCon;
            oDR = oCmd.ExecuteReader();
        }

        // Checks if the reader has rows fed into it.
        public bool ReaderHasRows()
        {
            if (oDR.HasRows)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Executes the read.
        public bool ReadDatabase()
        {
            if (oDR.Read())
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Gets the value at the column col
        public object GetColumnValue(int col)
        {
            return oDR.GetValue(col);
        }

        // Close the db connection.
        public void CloseConnection()
        {
            oCon.Close();
        }

        public void AddResult(String obj)
        {
            resultsList.Add(obj);
        }

        public void ClearResults()
        {
            resultsList.Clear();
        }

        public String GetValueAt(int row, int column)
        {
            return resultsList[(row * 10) + column];
        }
    }
}
