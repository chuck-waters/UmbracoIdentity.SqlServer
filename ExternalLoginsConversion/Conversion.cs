using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace ExternalLoginsConversion
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void btnCEFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open SDF File";
            ofd.Filter = "All files (*.*)|*.*|SQL CE (*.sdf)|*.sdf";
            ofd.FilterIndex = 2;
            ofd.InitialDirectory = "c:\\";
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnConvertData_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(txtFilePath.Text.Trim()))
            {
                MessageBox.Show("SQL Server CE File Does Not Exist.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var convertData = new ConvertData();
            convertData.GetSQLCEData(txtFilePath.Text.Trim());
            convertData.LoadDataIntoSqlServer(txtServer.Text.Trim(), txtDatabase.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
        }

        private void lnkTableScript_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmScriptWindow scriptWindow = new frmScriptWindow(txtServer.Text.Trim(), txtDatabase.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
            scriptWindow.ShowDialog(this);
        }
    }
}
