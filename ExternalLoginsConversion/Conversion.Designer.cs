namespace ExternalLoginsConversion
{
    partial class Conversion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSqlServerCE = new System.Windows.Forms.Label();
            this.lblSqlServer = new System.Windows.Forms.Label();
            this.btnCEFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnConvertData = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkTableScript = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSqlServerCE
            // 
            this.lblSqlServerCE.AutoSize = true;
            this.lblSqlServerCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqlServerCE.Location = new System.Drawing.Point(12, 27);
            this.lblSqlServerCE.Name = "lblSqlServerCE";
            this.lblSqlServerCE.Size = new System.Drawing.Size(185, 17);
            this.lblSqlServerCE.TabIndex = 0;
            this.lblSqlServerCE.Text = "SQL Server CE (Source)";
            // 
            // lblSqlServer
            // 
            this.lblSqlServer.AutoSize = true;
            this.lblSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqlServer.Location = new System.Drawing.Point(12, 105);
            this.lblSqlServer.Name = "lblSqlServer";
            this.lblSqlServer.Size = new System.Drawing.Size(191, 17);
            this.lblSqlServer.TabIndex = 1;
            this.lblSqlServer.Text = "SQL Server (Destination)";
            // 
            // btnCEFilePath
            // 
            this.btnCEFilePath.Location = new System.Drawing.Point(15, 74);
            this.btnCEFilePath.Name = "btnCEFilePath";
            this.btnCEFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnCEFilePath.TabIndex = 1;
            this.btnCEFilePath.Text = "Browse";
            this.btnCEFilePath.UseVisualStyleBackColor = true;
            this.btnCEFilePath.Click += new System.EventHandler(this.btnCEFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(15, 48);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(307, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnConvertData
            // 
            this.btnConvertData.Location = new System.Drawing.Point(87, 245);
            this.btnConvertData.Name = "btnConvertData";
            this.btnConvertData.Size = new System.Drawing.Size(235, 23);
            this.btnConvertData.TabIndex = 1;
            this.btnConvertData.Text = "Convert Data";
            this.btnConvertData.UseVisualStyleBackColor = true;
            this.btnConvertData.Click += new System.EventHandler(this.btnConvertData_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(87, 138);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(235, 20);
            this.txtServer.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 142);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Server";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(15, 169);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(87, 165);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(235, 20);
            this.txtDatabase.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 196);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(87, 192);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // lnkTableScript
            // 
            this.lnkTableScript.AutoSize = true;
            this.lnkTableScript.Location = new System.Drawing.Point(214, 109);
            this.lnkTableScript.Name = "lnkTableScript";
            this.lnkTableScript.Size = new System.Drawing.Size(108, 13);
            this.lnkTableScript.TabIndex = 11;
            this.lnkTableScript.TabStop = true;
            this.lnkTableScript.Text = "Get SQL Table Script";
            this.lnkTableScript.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTableScript_LinkClicked);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 312);
            this.Controls.Add(this.lnkTableScript);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblSqlServer);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnConvertData);
            this.Controls.Add(this.btnCEFilePath);
            this.Controls.Add(this.lblSqlServerCE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL CE Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSqlServerCE;
        private System.Windows.Forms.Label lblSqlServer;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnCEFilePath;
        private System.Windows.Forms.Button btnConvertData;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkTableScript;
    }
}