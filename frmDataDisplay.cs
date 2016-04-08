using System;
using System.Collections;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace DBSpy
{
    public partial class frmDataDisplay : Form
    {


        #region Declarations

        public string mSelectedTable;
        private bool mTableSelected;
        ArrayList arrViews;
        ArrayList arrTables;

        #endregion


        /// <summary>
        /// default constructor
        /// </summary>
        public frmDataDisplay()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Populate to arrays with list of all of the tables and views used
        /// in the database defined by the current connection string
        /// </summary>
        public void StoreTableAndViewNames()
        {
            // temporary holder for the schema information for the current
            // database connection
            DataTable SchemaTable;

            // used to hold a list of views and tables
            arrViews = new ArrayList();
            arrTables = new ArrayList();

            // clean up the menu so the menu item does not
            // hang while this function executes
            this.Refresh();

            // make sure we have a connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                // start up the connection using the current connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {

                    try
                    {
                        // open the connection to the database 
                        conn.Open();

                        // Get the Tables
                        SchemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });

                        // Store the table names in the class scoped array list of table names
                        for (int i = 0; i < SchemaTable.Rows.Count; i++)
                        {
                            arrTables.Add(SchemaTable.Rows[i].ItemArray[2].ToString());
                        }

                        // Get the Views
                        SchemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "VIEW" });

                        // Store the view names in the class scoped array list of view names
                        for (int i = 0; i < SchemaTable.Rows.Count; i++)
                        {
                            arrViews.Add(SchemaTable.Rows[i].ItemArray[2].ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        // break and notify if the connection fails
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }

            }
        }


        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dispose of this form
            this.Dispose();
        }



        /// <summary>
        /// Open a new connection to a database - present the connection string builder
        /// form so the user can define a connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenANewConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open an instance the connect form so the user
            // can define a new connection
            frmConnect f = new frmConnect();
            f.Show();
        }



        /// <summary>
        /// Display the current connection string to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewCurrentConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the current connection string
            MessageBox.Show(Properties.Settings.Default.ConnString, "Current Connection");
        }



        /// <summary>
        /// Get and display the current tables and views contained in the database
        /// pointed to by the connection string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadDataForCurrentConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get tables and views
            StoreTableAndViewNames();

            // clear internal lists
            lstTables.Items.Clear();
            lstViews.Items.Clear();

            // update the lists from the arrays holding the
            // tables and views
            lstTables.Items.AddRange(arrTables.ToArray());
            lstViews.Items.AddRange(arrViews.ToArray());

        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTableSelected = true;
            string tblName;

            try
            {
                tblName = lstTables.SelectedItem.ToString();
            }
            catch
            {
                return;
            }

            // make sure we have a connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                // start up the connection using the current connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {

                    try
                    {
                        // open the connection to the database 
                        conn.Open();
                        lstFields.Items.Clear();

                        DataTable dtField = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tblName });


                        foreach (DataRow dr in dtField.Rows)
                        {
                            lstFields.Items.Add(dr["COLUMN_NAME"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no connection string current defined.", "Connection String");
            }

        }

        private void lstViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTableSelected = false;
            string tblName;

            try
            {
                tblName = lstViews.SelectedItem.ToString();
            }
            catch
            {
                return;
            }

            // make sure we have a connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                // start up the connection using the current connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {

                    try
                    {
                        // open the connection to the database 
                        conn.Open();
                        lstFields.Items.Clear();

                        // get the schema table
                        DataTable dtField = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tblName });

                        // read the column names into the fields list
                        foreach (DataRow dr in dtField.Rows)
                        {
                            lstFields.Items.Add(dr["COLUMN_NAME"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no connection string current defined.", "Connection String");
            }
        }


        /// <summary>
        /// Collect and display the field information for a selected column name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFieldInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    string sSql = string.Empty;

                    if (mTableSelected == true)
                    {
                        sSql = "SELECT [" + lstFields.SelectedItem.ToString().Trim() + "] FROM " + lstTables.SelectedItem.ToString().Trim() ;
                    }
                    else
                    {
                        sSql = "SELECT [" + lstFields.SelectedItem.ToString().Trim() + "] FROM [" + lstViews.SelectedItem.ToString().Trim() + "]";
                    }

                    OleDbCommand cmd = new OleDbCommand(sSql, conn);
                    conn.Open();

                    OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                    DataTable schemaTable = rdr.GetSchemaTable();
                    StringBuilder sb = new StringBuilder();

                    foreach (DataRow myField in schemaTable.Rows)
                    {
                        foreach (DataColumn myProperty in schemaTable.Columns)
                        {
                            sb.Append(myProperty.ColumnName + " = " + myField[myProperty].ToString() + Environment.NewLine);
                        }

                        // report
                        MessageBox.Show(sb.ToString(), "Field Information");

                        // burn the reader
                        rdr.Close();

                        // exit 
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unable to attach to this table with current user; check database security permissions.", "Field Information");
            }

        }

        /// <summary>
        /// Ignore selections from the fields list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("USE [SourceProsV11]");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET ANSI_NULLS ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET QUOTED_IDENTIFIER ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("CREATE PROCEDURE [dbo].[Usp_IU_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");



            sb.Append("-- =============================================");
            sb.Append("\r\n");
            sb.Append("-- Author: Nikita Shah");
            sb.Append("\r\n");
            sb.Append("-- Create date	: " + DateTime.Now.ToShortDateString());
            sb.Append("\r\n");
            sb.Append("-- Description	: Insert or update " + lstTables.SelectedItem.ToString().Trim() + " for individual ");
            sb.Append("\r\n");
            sb.Append("/*Parameters	: Exec [Usp_IU_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");
            sb.Append("*/");
            sb.Append("\r\n");
            sb.Append("	");
            sb.Append("\r\n");
            sb.Append("-- =============================================");
            sb.Append("\r\n");

            sb.Append("\r\n");


            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
            {
                string sSql = string.Empty;


                sSql = "SELECT * FROM [" + lstTables.SelectedItem.ToString().Trim() + "]";


                OleDbCommand cmd = new OleDbCommand(sSql, conn);
                conn.Open();

                OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable schemaTable = rdr.GetSchemaTable();

                int i = 0;
                foreach (DataRow myField in schemaTable.Rows)
                {
                    bool allownull = Convert.ToBoolean(myField["AllowDBNull"]);
                    if (i == 0)
                    {
                        if (myField["DataType"].ToString() == "System.Boolean")
                        {

                            sb.Append("@" + myField["ColumnName"].ToString() + " BIT=0");

                        }
                        else if (myField["DataType"].ToString() == "System.Int32")
                        {
                            if (allownull)
                            {
                                sb.Append("@" + myField["ColumnName"].ToString() + " INT=NULL");
                            }
                            else
                            {
                                sb.Append("@" + myField["ColumnName"].ToString() + " INT=0");
                            }
                        }
                        else if (myField["DataType"].ToString() == "System.String")
                        {
                            
                                sb.Append("@" + myField["ColumnName"].ToString() + " VARCHAR(" + myField["ColumnSize"].ToString() + ")=NULL");
                            
                        }
                        else if (myField["DataType"].ToString() == "System.DateTime")
                        {
                            
                                sb.Append("@" + myField["ColumnName"].ToString() + " DateTime=NULL");
                            
                        }
                        else if (myField["DataType"].ToString() == "System.Decimal")
                        {
                            if (allownull)
                            {
                                sb.Append("@" + myField["ColumnName"].ToString() + " NUMERIC(" + myField["NumericPricision"].ToString() + "," + myField["NumericScale"].ToString() + ") = NULL");
                            }
                            else
                            {
                                sb.Append("@" + myField["ColumnName"].ToString() + " NUMERIC(" + myField["NumericPricision"].ToString() + "," + myField["NumericScale"].ToString() + ") =0");
                            }
                        }
                        sb.Append("\r\n");
                    }
                    else
                    {
                        if (myField["DataType"].ToString() == "System.Boolean")
                        {

                            sb.Append(",@" + myField["ColumnName"].ToString() + " BIT=0");

                        }
                        else if (myField["DataType"].ToString() == "System.Int32")
                        {
                            
                           
                                sb.Append(",@" + myField["ColumnName"].ToString() + " INT=0");
                            
                        }
                        else if (myField["DataType"].ToString() == "System.String")
                        {
                            
                                sb.Append(",@" + myField["ColumnName"].ToString() + " VARCHAR(" + myField["ColumnSize"].ToString() + ")=NULL");
                            
                        }
                        else if (myField["DataType"].ToString() == "System.DateTime")
                        {
                            
                                sb.Append(",@" + myField["ColumnName"].ToString() + " DateTime=NULL");
                           
                        }
                        else if (myField["DataType"].ToString() == "System.Decimal")
                        {
                            if (allownull)
                            {
                                sb.Append(",@" + myField["ColumnName"].ToString() + " NUMERIC(" + myField.ItemArray[3].ToString() + "," + myField.ItemArray[4].ToString() + ") = NULL");
                            }
                            else
                            {
                                sb.Append(",@" + myField["ColumnName"].ToString() + " NUMERIC(" + myField.ItemArray[3].ToString() + "," + myField.ItemArray[4].ToString() + ")=0");
                            }
                        }
                        sb.Append("\r\n");
                    }
                    i++;



                    // burn the reader
                    rdr.Close();

                    // exit 

                }
                sb.Append("AS");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");
                sb.Append("BEGIN try ");
                sb.Append("\r\n");
                sb.Append("SET nocount ON; ");
                sb.Append("\r\n");

                DataRow[] row = schemaTable.Select("IsKey=true");
                string primaryKey = "";
                if (row != null && row.Length > 0)
                {
                    primaryKey = row[0]["ColumnName"].ToString();
                }
                sb.Append("DECLARE @ID INT");
                sb.Append("\r\n");

                string ifstatement = string.Empty;
                foreach (DataRow myField in schemaTable.Rows)
                {
                    bool allownull = Convert.ToBoolean(myField["AllowDBNull"]);
                    if (!allownull && primaryKey != myField["ColumnName"].ToString()) 
                    {
                        if (string.IsNullOrEmpty(ifstatement))
                        {
                            ifstatement += "IF(";
                        }
                        else {
                            ifstatement += "\r\n" + "and ";
                        }
                        if (myField["DataType"].ToString() == "System.String" || myField["DataType"].ToString() == "System.DateTime")
                        {
                            ifstatement += "@" + myField["ColumnName"].ToString() + "<>'' and " + "@" + myField["ColumnName"].ToString() + " is not null";
                        }
                        else if (myField["DataType"].ToString() == "System.Int32" || myField["DataType"].ToString() == "System.Decimal")
                        {

                            ifstatement += "@" + myField["ColumnName"].ToString() + "<>0 and " + "@" + myField["ColumnName"].ToString() + " is not null";
                        }
                    
                    }

                }
                if (!string.IsNullOrEmpty(ifstatement))
                {
                    ifstatement += ")";
                    sb.Append("\r\n");
                    sb.Append(ifstatement);
                    sb.Append("\r\n");
                    sb.Append("BEGIN");
                    sb.Append("\r\n");
                }

                sb.Append("IF(NOT EXISTS (SELECT 1 FROM " + lstTables.SelectedItem.ToString().Trim()+" With(NoLock)" + " Where " + primaryKey + "= @" + primaryKey + ")) ");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");

                sb.Append("INSERT INTO [dbo]." + lstTables.SelectedItem.ToString().Trim());
                sb.Append("\r\n");
                sb.Append("(");
                sb.Append("\r\n");
                int j = 0;
                foreach (DataRow myField in schemaTable.Rows)
                {
                    if (Convert.ToBoolean(myField["IsKey"]))
                    {
                        continue;
                    }
                    if (j == 0)
                    {
                        sb.Append(myField["ColumnName"].ToString());
                    }
                    else
                    {
                        sb.Append("," + myField["ColumnName"].ToString());
                    }
                    j++;
                    sb.Append("\r\n");
                }
                sb.Append("\r\n");
                sb.Append(")");
                sb.Append("\r\n");
                sb.Append("VALUES");
                sb.Append("(");

                j = 0;
                foreach (DataRow myField in schemaTable.Rows)
                {
                    if (Convert.ToBoolean(myField["IsKey"]))
                    {
                        continue;
                    }
                    if (j == 0)
                    {
                        sb.Append("@" + myField["ColumnName"].ToString());
                    }
                    else
                    {
                        sb.Append(",@" + myField["ColumnName"].ToString());
                    }
                    j++;
                    sb.Append("\r\n");
                }

                sb.Append(")");
                sb.Append("\r\n");
                sb.Append("SET @ID = IDENT_CURRENT('" + lstTables.SelectedItem.ToString().Trim() + "')");
                sb.Append("\r\n");
                sb.Append("END");
                sb.Append("\r\n");
                sb.Append("ELSE");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");
                sb.Append("UPDATE [dbo]." + lstTables.SelectedItem.ToString().Trim());
                sb.Append("\r\n");
                sb.Append("SET");
                sb.Append("\r\n");
                j = 0;
                foreach (DataRow myField in schemaTable.Rows)
                {
                    if (Convert.ToBoolean(myField["IsKey"]))
                    {
                        continue;
                    }
                    if (j == 0)
                    {
                        sb.Append(myField["ColumnName"].ToString() + "=@" + myField["ColumnName"].ToString());
                    }
                    else
                    {
                        sb.Append("," + myField["ColumnName"].ToString() + "=@" + myField["ColumnName"].ToString());
                    }
                    j++;
                    sb.Append("\r\n");
                }


                sb.Append("WHERE " + primaryKey + " = @" + primaryKey);
                sb.Append("\r\n");
                sb.Append("SET @ID = @" + primaryKey);
                sb.Append("\r\n");
                sb.Append("END");

                if (!string.IsNullOrEmpty(ifstatement))
                {
                  
                    sb.Append("\r\n");
                    sb.Append("END");
                    sb.Append("\r\n");
                   
                }

                sb.Append("\r\n");
                sb.Append("Select @ID");
                sb.Append("\r\n");
                sb.Append("END try");
                sb.Append("\r\n");
                sb.Append("BEGIN catch");
                sb.Append("\r\n");
                sb.Append("EXEC dbo.Usperrorhandling ");
                sb.Append("\r\n");
                sb.Append("END catch; ");
                sb.Append("\r\n");
                sb.Append("END");

                txtResult.Text = sb.ToString();
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("USE [SourceProsV11]");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET ANSI_NULLS ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET QUOTED_IDENTIFIER ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("CREATE PROCEDURE [dbo].[Usp_Delete_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");

            sb.Append("-- =============================================");
            sb.Append("\r\n");
            sb.Append("-- Author: Nikita Shah");
            sb.Append("\r\n");
            sb.Append("-- Create date	: " + DateTime.Now.ToShortDateString());
            sb.Append("\r\n");
            sb.Append("-- Description	: Delete " + lstTables.SelectedItem.ToString().Trim() + " for individual ");
            sb.Append("\r\n");
            sb.Append("--Parameters	: Exec [Usp_Delete_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");
            sb.Append("	--return value :null(doesnot exist) and 0(FK REFERENCE constraint)");
            sb.Append("\r\n");
            sb.Append("-- =============================================");
            sb.Append("\r\n");

            sb.Append("\r\n");

            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
            {
                string sSql = string.Empty;


                sSql = "SELECT * FROM [" + lstTables.SelectedItem.ToString().Trim() + "]";


                OleDbCommand cmd = new OleDbCommand(sSql, conn);
                conn.Open();

                OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable schemaTable = rdr.GetSchemaTable();

                DataRow[] row = schemaTable.Select("IsKey=true");
                string primaryKey = "";
                if (row != null && row.Length > 0)
                {
                    primaryKey = row[0]["ColumnName"].ToString();
                }
                sb.Append("@" + primaryKey + " INT=0");


                rdr.Close();




                sb.Append("AS");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");
                sb.Append("BEGIN try ");
                sb.Append("\r\n");
                sb.Append("SET nocount ON; ");
                sb.Append("\r\n");
                sb.Append("DECLARE @ID INT");
                sb.Append("\r\n");
                sb.Append("if Exists(Select 1 FROM " + lstTables.SelectedItem.ToString().Trim()+" With(NoLock) " + " WHERE " + primaryKey + "=@" + primaryKey + ")");
                sb.Append("\r\n");
                sb.Append("begin");
                sb.Append("\r\n");
                sb.Append("DELETE FROM " + lstTables.SelectedItem.ToString().Trim()+ " WHERE " + primaryKey + "=@" + primaryKey);
                sb.Append("\r\n");
                sb.Append("SET @ID=@" + primaryKey);
                sb.Append("\r\n");
                sb.Append("END");
                sb.Append("\r\n");
                sb.Append("Select @ID");
                sb.Append("\r\n");
                sb.Append("END try");
                sb.Append("\r\n");
                sb.Append("BEGIN catch");
                sb.Append("\r\n");
                sb.Append("EXEC dbo.Usperrorhandling ");
                sb.Append("\r\n");
                sb.Append("SELECT 0");
                sb.Append("\r\n");
                sb.Append("END catch; ");
                sb.Append("\r\n");
                sb.Append("END");

                txtResult.Text = sb.ToString();
            }





        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("USE [SourceProsV11]");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET ANSI_NULLS ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET QUOTED_IDENTIFIER ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("CREATE PROCEDURE [dbo].[Usp_Get_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");




            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
            {
                string sSql = string.Empty;


                sSql = "SELECT * FROM [" + lstTables.SelectedItem.ToString().Trim() + "]";


                OleDbCommand cmd = new OleDbCommand(sSql, conn);
                conn.Open();

                OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable schemaTable = rdr.GetSchemaTable();

                DataRow[] row = schemaTable.Select("IsKey=true");
                string primaryKey = "";
                if (row != null && row.Length > 0)
                {
                    primaryKey = row[0]["ColumnName"].ToString();
                }



                sb.Append("-- =============================================");
                sb.Append("\r\n");
                sb.Append("-- Author: Nikita Shah");
                sb.Append("\r\n");
                sb.Append("-- Create date	: " + DateTime.Now.ToShortDateString());
                sb.Append("\r\n");
                sb.Append("-- Description	: " + lstTables.SelectedItem.ToString().Trim() + " for individual " + primaryKey);
                sb.Append("\r\n");
                sb.Append("--Parameters	: Exec [Usp_Get_" + lstTables.SelectedItem.ToString().Trim() + "] " + "@" + primaryKey + "=1");
                sb.Append("\r\n");
                sb.Append("	");
                sb.Append("\r\n");
                sb.Append("-- =============================================");
                sb.Append("\r\n");

                sb.Append("\r\n");





                sb.Append("@" + primaryKey + " INT=0");







                rdr.Close();


                sb.Append("AS");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");
                sb.Append("BEGIN try ");
                sb.Append("\r\n");
                sb.Append("SET nocount ON; ");
                sb.Append("\r\n");

                int j = 0;
                j = 0;
                sb.Append("SELECT  ");
                foreach (DataRow myField in schemaTable.Rows)
                {
                    
                    if (j == 0)
                    {
                        sb.Append(myField["ColumnName"].ToString());
                    }
                    else
                    {
                        sb.Append("," + myField["ColumnName"].ToString());
                    }
                    j++;
                    sb.Append("\r\n");
                }

                sb.Append("  FROM " + lstTables.SelectedItem.ToString().Trim()+" With(NoLock) " + " WHERE " + primaryKey + "=@" + primaryKey);


                sb.Append("\r\n");
                sb.Append("END try");
                sb.Append("\r\n");
                sb.Append("BEGIN catch");
                sb.Append("\r\n");
                sb.Append("EXEC dbo.Usperrorhandling ");
                sb.Append("\r\n");
                sb.Append("END catch; ");
                sb.Append("\r\n");
                sb.Append("END");

                txtResult.Text = sb.ToString();
            }



        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("USE [SourceProsV11]");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET ANSI_NULLS ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("SET QUOTED_IDENTIFIER ON");
            sb.Append("\r\n");
            sb.Append("GO");
            sb.Append("\r\n");
            sb.Append("CREATE PROCEDURE [dbo].[Usp_GetAll_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");

            sb.Append("-- =============================================");
            sb.Append("\r\n");
            sb.Append("-- Author		: Nikita Shah");
            sb.Append("\r\n");
            sb.Append("-- Create date	: " + DateTime.Now.ToShortDateString());
            sb.Append("\r\n");
            sb.Append("-- Description	: Get All Record of dbo." + lstTables.SelectedItem.ToString().Trim());
            sb.Append("\r\n");
            sb.Append("--Parameters	: Exec [Usp_GetAll_" + lstTables.SelectedItem.ToString().Trim() + "] ");
            sb.Append("\r\n");
            sb.Append("	");
            sb.Append("\r\n");
            sb.Append("-- =============================================");
            sb.Append("\r\n");

            sb.Append("\r\n");


            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
            {
                string sSql = string.Empty;


                sSql = "SELECT * FROM [" + lstTables.SelectedItem.ToString().Trim() + "]";


                OleDbCommand cmd = new OleDbCommand(sSql, conn);
                conn.Open();

                OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable schemaTable = rdr.GetSchemaTable();

                DataRow[] row = schemaTable.Select("IsKey=true");
                string primaryKey = "";
                string secondryCol = "";

                if (row != null && row.Length > 0)
                {
                    primaryKey = row[0]["ColumnName"].ToString();
                }

                row = schemaTable.Select("IsKey=false");
                if (row != null && row.Length > 0)
                {
                    secondryCol = row[0]["ColumnName"].ToString();
                }
                sb.Append("@PageNo int = 1");
                sb.Append("\r\n");
                sb.Append(",@PageSize int = 0");
                sb.Append("\r\n");
                sb.Append(",@SearchString varchar(100)=null");
                sb.Append("\r\n");
                sb.Append(",@OrderBy varchar(50) = '" + secondryCol + "'");
                sb.Append("\r\n");
                sb.Append(",@SortBy bit=0--Asc=0 ,desc=1");
                sb.Append("\r\n");

                rdr.Close();


                sb.Append("AS");
                sb.Append("\r\n");
                sb.Append("BEGIN");
                sb.Append("\r\n");
                sb.Append("BEGIN try ");
                sb.Append("\r\n");
                sb.Append("SET nocount ON; ");
                sb.Append("\r\n");


                sb.Append("\r\n");
                sb.Append("if(@PageSize=0)");
                sb.Append("\r\n");
                sb.Append("begin");
                sb.Append("\r\n");
                sb.Append("Select @PageSize=Count(0) from " + lstTables.SelectedItem.ToString().Trim()+" With(NoLock)");
                sb.Append("\r\n");
                sb.Append("end");
                sb.Append("\r\n");

                sb.Append("\r\n");
                sb.Append("DECLARE @firstRecord INT");
                sb.Append("\r\n");
                sb.Append("SET @firstRecord = (@pageNo - 1) * @pageSize");
                sb.Append("\r\n");

                sb.Append("\r\n");
                int j = 0;
                j = 0;
                sb.Append("SELECT  ");
                foreach (DataRow myField in schemaTable.Rows)
                {

                    if (j == 0)
                    {
                        sb.Append(myField["ColumnName"].ToString());
                    }
                    else
                    {
                        sb.Append("," + myField["ColumnName"].ToString());
                    }
                    j++;
                    sb.Append("\r\n");
                }
                sb.Append(",COUNT(0) over() AS TotalCount");
                sb.Append("\r\n");
                sb.Append("  FROM " + lstTables.SelectedItem.ToString().Trim()+" With(NoLock)");
                sb.Append("\r\n");
                sb.Append("where");
                sb.Append("\r\n");
                sb.Append("((@SearchString<>'' ");
                sb.Append("\r\n");
                sb.Append("	and @SearchString is not null )");
                sb.Append("\r\n");
                sb.Append("	and " + secondryCol + " like '%'+@SearchString+'%')");
                sb.Append("\r\n");
                sb.Append("or ((@SearchString is null or @SearchString = '') and (1=1))");

                sb.Append("\r\n");
                sb.Append("Order by");
                sb.Append("\r\n");



                DataRow lastItem = schemaTable.Rows[schemaTable.Rows.Count - 1];
                foreach (DataRow myField in schemaTable.Rows)
                {
                    sb.Append("CASE WHEN @OrderBy ='" + myField["ColumnName"].ToString() + "' and @SortBy=0 THEN " + myField["ColumnName"].ToString());
                    sb.Append("\r\n");
                    sb.Append("END ASC,");
                    sb.Append("\r\n");
                    sb.Append("CASE WHEN @OrderBy ='" + myField["ColumnName"].ToString() + "' and @SortBy=1 THEN " + myField["ColumnName"].ToString());
                    sb.Append("\r\n");
                    sb.Append("END DESC");
                    if (myField["ColumnName"].ToString() != lastItem["ColumnName"].ToString())
                    {
                        sb.Append(",");
                    }
                    sb.Append("\r\n");
                }


                sb.Append("Offset @firstRecord rows");
                sb.Append("\r\n");
                sb.Append("Fetch Next @pageSize rows only");
                sb.Append("\r\n");
                sb.Append("option (recompile);");
                sb.Append("\r\n");

                sb.Append("\r\n");
                sb.Append("END try");
                sb.Append("\r\n");
                sb.Append("BEGIN catch");
                sb.Append("\r\n");
                sb.Append("EXEC dbo.Usperrorhandling ");
                sb.Append("\r\n");
                sb.Append("END catch; ");
                sb.Append("\r\n");
                sb.Append("END");

                txtResult.Text = sb.ToString();
            }



        }



    }
}