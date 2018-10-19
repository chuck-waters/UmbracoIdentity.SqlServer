using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalLoginsConversion
{
    public partial class frmScriptWindow : Form
    {
        private string connectionString;
        private bool validConnection;

        public frmScriptWindow(string server, string database, string username, string password)
        {
            InitializeComponent();
            connectionString = $"server={server};database={database};user id={username};password={password};";

            this.validConnection = this.TestConnection();
        }

        private void frmScriptWindow_Load(object sender, EventArgs e)
        {
            StringBuilder script = new StringBuilder();
            script.AppendLine("CREATE TABLE [dbo].[ExternalLogins](");
            script.AppendLine("  [ExternalLoginId] [int] IDENTITY(1,1) NOT NULL,");
            script.AppendLine("  [UserId] [int] NOT NULL,");
            script.AppendLine("  [LoginProvider] [nvarchar](4000) NOT NULL,");
            script.AppendLine("  [ProviderKey] [nvarchar](4000) NOT NULL,");
            script.AppendLine(" CONSTRAINT [PK_dbo.ExternalLogins] PRIMARY KEY CLUSTERED ");
            script.AppendLine(" (");
            script.AppendLine("  [ExternalLoginId] ASC");
            script.AppendLine(" )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]");
            script.AppendLine(") ON [PRIMARY]");
            script.AppendLine("GO");

            txtTableScript.Text = script.ToString();
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTableScript.Text);
        }

        private bool TestConnection()
        {
            bool success = true;
            try
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    con.Open();
                    con.Close();
                }
                btnScriptToolTip.SetToolTip(btnRunScript, "Runs the script against the SQL Database");
            }
            catch (Exception)
            {
                btnScriptToolTip.SetToolTip(btnRunScript, "Check SQL Server connection details on main window");
                success = false;
            }

            return success;
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            if(!this.validConnection)
            {
                MessageBox.Show(btnScriptToolTip.GetToolTip(btnRunScript), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tableExists = false;
                string message = String.Empty;
                var icon = MessageBoxIcon.Information;
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    con.Open();
                    string ifExistsSql = "SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExternalLogins]') AND type in (N'U')";
                    using (SqlCommand cmdIfExists = new SqlCommand(ifExistsSql, con))
                    {
                        var rows = (int)cmdIfExists.ExecuteScalar();
                        if(rows > 0)
                        {
                            tableExists = true;
                            message = $"Table already exists in {con.Database}";
                        }
                    }
                    if(!tableExists)
                    {
                        using (SqlCommand cmdCreateTable = new SqlCommand(txtTableScript.Text, con))
                        {
                            try
                            {
                                cmdCreateTable.ExecuteNonQuery();
                                message = "Table created successfully";
                            }
                            catch(Exception ex)
                            {
                                message = ex.Message;
                                icon = MessageBoxIcon.Error;
                            }
                        }
                    }

                    con.Close();
                }
                
                MessageBox.Show(message, "Complete", MessageBoxButtons.OK, icon);
            }
        }
    }
}
