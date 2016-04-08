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
    public partial class frmConnect : Form
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        public frmConnect()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Store the Oracle settings and test the connection
        /// string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOracleOK_Click(object sender, EventArgs e)
        {
            // Future use; if a current data model and database
            // type need to be identified and saved with the connect
            // string to identify its purpose
            Properties.Settings.Default.CurrentDataModel = "MyOracle";
            Properties.Settings.Default.CurrentDatabaseType = "Oracle";

            // Set the actual connection string properties into
            // the application settings
            Properties.Settings.Default.ProviderString = txtOracleProvider.Text;
            Properties.Settings.Default.Password = txtOraclePassword.Text;
            Properties.Settings.Default.UserID = txtOracleUserID.Text;
            Properties.Settings.Default.ServerName = txtOracleDBname.Text;

            // Set the connection string
            Properties.Settings.Default.ConnString = "Provider=" + Properties.Settings.Default.ProviderString +
                                ";Password=" + Properties.Settings.Default.Password +
                                ";User ID=" + Properties.Settings.Default.UserID +
                                ";Data Source=" + Properties.Settings.Default.ServerName;


            // Save the property settings
            Properties.Settings.Default.Save();

            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test with an open attempt
                        conn.Open();
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        // if the connection fails, inform the user
                        // so they can fix the properties
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }
            }
        }



        /// <summary>
        /// Test the Oracle Connection String
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOracleTest_Click(object sender, EventArgs e)
        {
            try
            {
                // Future use; if a current data model and database
                // type need to be identified and saved with the connect
                // string to identify its purpose
                Properties.Settings.Default.CurrentDataModel = "MyOracle";
                Properties.Settings.Default.CurrentDatabaseType = "Oracle";

                // Set the actual connection string properties into
                // the application settings
                Properties.Settings.Default.ProviderString = txtOracleProvider.Text;
                Properties.Settings.Default.Password = txtOraclePassword.Text;
                Properties.Settings.Default.UserID = txtOracleUserID.Text;
                Properties.Settings.Default.ServerName = txtOracleDBname.Text;

                // Set the connection string
                Properties.Settings.Default.ConnString = "Provider=" + Properties.Settings.Default.ProviderString +
                                    ";Password=" + Properties.Settings.Default.Password +
                                    ";User ID=" + Properties.Settings.Default.UserID +
                                    ";Data Source=" + Properties.Settings.Default.ServerName;

                // Save the property settings
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving connection information.");
            }


            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test the connection with an open attempt
                        conn.Open();
                        MessageBox.Show("Connection attempt successful.", "Connection Test");
                    }
                    catch (Exception ex)
                    {
                        // inform the user if the connection fails
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
        private void btnOracleCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /// <summary>
        /// SQL Server 
        /// Configure for the use of integrated
        /// security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            // if the user has checked the SQL Server connection
            // option to use integrated security, configure the
            //user ID and password controls accordingly

            if (cbxIntegratedSecurity.Checked == true)
            {
                txtSqlServerUserID.Text = string.Empty;
                txtSqlServerPassword.Text = string.Empty;

                txtSqlServerUserID.Enabled = false;
                txtSqlServerPassword.Enabled = false;
            }
            else
            {
                txtSqlServerUserID.Enabled = true;
                txtSqlServerPassword.Enabled = true;
            }
        }



        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSQLserverCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /// <summary>
        /// Test the SQL Server connection string
        /// based upon the user supplied settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSqlServerTest_Click(object sender, EventArgs e)
        {

            try
            {
                // Future use; if a current data model and database
                // type need to be identified and saved with the connect
                // string to identify its purpose
                Properties.Settings.Default.CurrentDataModel = "MySqlServer";
                Properties.Settings.Default.CurrentDatabaseType = "SqlServer";

                // Set the properties for the connection string
                Properties.Settings.Default.ProviderString = txtSqlServerProvider.Text;
                Properties.Settings.Default.Password = txtSqlServerPassword.Text;
                Properties.Settings.Default.UserID = txtSqlServerUserID.Text;
                Properties.Settings.Default.ServerName = txtSqlServerDBName.Text;
                Properties.Settings.Default.InitialCatalog = txtSqlServerInitialCat.Text;

                // configure the connection string based upon the use
                // of integrated security
                if (cbxIntegratedSecurity.Checked == true)
                {
                    Properties.Settings.Default.ConnString = 
                        "Provider=" + Properties.Settings.Default.ProviderString +
                        ";Data Source=" + Properties.Settings.Default.ServerName +
                        ";Initial Catalog=" + Properties.Settings.Default.InitialCatalog +
                        ";Integrated Security=SSPI;";
                }
                else
                {
                    Properties.Settings.Default.ConnString = 
                        "Provider=" + Properties.Settings.Default.ProviderString +
                        ";Password=" + Properties.Settings.Default.Password +
                        ";User ID=" + Properties.Settings.Default.UserID +
                        ";Data Source=" + Properties.Settings.Default.ServerName +
                        ";Initial Catalog=" + Properties.Settings.Default.InitialCatalog;
                }

                // Save the property settings
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                // inform the user if the connection was not saved
                MessageBox.Show(ex.Message, "Error saving connection information.");
            }

            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test the connection with an open attempt
                        conn.Open();
                        MessageBox.Show("Connection Attempt Successful.", "Connection Test");
                    }
                    catch (Exception ex)
                    {
                        // inform the user if the connection test failed
                        MessageBox.Show(ex.Message, "Connection Test");
                    }
                }
            }


        }



        /// <summary>
        /// Persist and test an SQL Server connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSqlServerOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Future use; if a current data model and database
                // type need to be identified and saved with the connect
                // string to identify its purpose
                Properties.Settings.Default.CurrentDataModel = "MySqlServer";
                Properties.Settings.Default.CurrentDatabaseType = "SqlServer";

                // Set the properties for the connection 
                Properties.Settings.Default.ProviderString = txtSqlServerProvider.Text;
                Properties.Settings.Default.Password = txtSqlServerPassword.Text;
                Properties.Settings.Default.UserID = txtSqlServerUserID.Text;
                Properties.Settings.Default.ServerName = txtSqlServerDBName.Text;
                Properties.Settings.Default.InitialCatalog = txtSqlServerInitialCat.Text;

                // configure the connection string based upon
                // the use of integrated security
                if (cbxIntegratedSecurity.Checked == true)
                {
                    Properties.Settings.Default.ConnString =
                        "Provider=" + Properties.Settings.Default.ProviderString +
                        ";Data Source=" + Properties.Settings.Default.ServerName +
                        ";Initial Catalog=" + Properties.Settings.Default.InitialCatalog +
                        ";Integrated Security=SSPI;";
                }
                else
                {
                    Properties.Settings.Default.ConnString =
                        "Provider=" + Properties.Settings.Default.ProviderString +
                        ";Password=" + Properties.Settings.Default.Password +
                        ";User ID=" + Properties.Settings.Default.UserID +
                        ";Data Source=" + Properties.Settings.Default.ServerName +
                        ";Initial Catalog=" + Properties.Settings.Default.InitialCatalog;
                }

                // Save the property settings
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                // inform the user if the connection information was not saved
                MessageBox.Show(ex.Message, "Error saving connection information.");
            }

            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test the connection with an open attempt
                        conn.Open();
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        // inform the user if the connection was not saved
                        MessageBox.Show(ex.Message, "Connection Test");
                    }
                }
            }
        }



        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccessCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /// <summary>
        /// Browse for an access database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "MS Access Database";
            openFile.DefaultExt = "mdb";
            openFile.Filter = "Access Database (*.mdb)|*mdb";
            openFile.ShowDialog();
            txtAccessDBname.Text = openFile.FileName;
        }




        /// <summary>
        /// Test an MS Access database connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccessTest_Click(object sender, EventArgs e)
        {
            try
            {
                // Future use; if a current data model and database
                // type need to be identified and saved with the connect
                // string to identify its purpose
                Properties.Settings.Default.CurrentDataModel = "MyAccess";
                Properties.Settings.Default.CurrentDatabaseType = "Access";

                // Set the access database connection properties
                Properties.Settings.Default.ProviderString = txtAccessProvider.Text;
                Properties.Settings.Default.Password = txtAccessPassword.Text;
                Properties.Settings.Default.UserID = txtAccessUserID.Text;
                Properties.Settings.Default.ServerName = txtAccessDBname.Text;

                // Set the access database connection string
                Properties.Settings.Default.ConnString = "Provider=" + Properties.Settings.Default.ProviderString +
                                    ";Password=" + Properties.Settings.Default.Password +
                                    ";User ID=" + Properties.Settings.Default.UserID +
                                    ";Data Source=" + Properties.Settings.Default.ServerName;

                // Save the properties
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                // inform the user if the connection could not be saved
                MessageBox.Show(ex.Message, "Error saving connection information.");
            }


            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test the connection with an open attempt
                        conn.Open();
                        MessageBox.Show("Access connection test successful", "Connection Test");
                    }
                    catch (Exception ex)
                    {
                        // inform the user if the connection failed
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }
            }

        }



        /// <summary>
        /// Persist and test an Access database connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccessOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Future use; if a current data model and database
                // type need to be identified and saved with the connect
                // string to identify its purpose
                Properties.Settings.Default.CurrentDataModel = "MyAccess";
                Properties.Settings.Default.CurrentDatabaseType = "Access";

                // Set the access database connection properties
                Properties.Settings.Default.ProviderString = txtAccessProvider.Text;
                Properties.Settings.Default.Password = txtAccessPassword.Text;
                Properties.Settings.Default.UserID = txtAccessUserID.Text;
                Properties.Settings.Default.ServerName = txtAccessDBname.Text;

                // Set the access database connection string
                Properties.Settings.Default.ConnString = "Provider=" + Properties.Settings.Default.ProviderString +
                                    ";Password=" + Properties.Settings.Default.Password +
                                    ";User ID=" + Properties.Settings.Default.UserID +
                                    ";Data Source=" + Properties.Settings.Default.ServerName;

                // Save the properties
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                // Inform the user if the connection was not saved
                MessageBox.Show(ex.Message, "Error saving connection information.");
            }


            //Test Connection
            if (Properties.Settings.Default.ConnString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnString))
                {
                    try
                    {
                        // test the database connection string with an open attempt
                        conn.Open();
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        // inform the user if the connection failed
                        MessageBox.Show(ex.Message, "Connection Error");
                    }
                }
            }
        }


    }
}