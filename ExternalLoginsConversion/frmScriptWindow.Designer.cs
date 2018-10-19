namespace ExternalLoginsConversion
{
    partial class frmScriptWindow
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
            this.components = new System.ComponentModel.Container();
            this.txtTableScript = new System.Windows.Forms.RichTextBox();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.btnScriptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtTableScript
            // 
            this.txtTableScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableScript.Location = new System.Drawing.Point(12, 12);
            this.txtTableScript.Name = "txtTableScript";
            this.txtTableScript.ReadOnly = true;
            this.txtTableScript.Size = new System.Drawing.Size(363, 247);
            this.txtTableScript.TabIndex = 0;
            this.txtTableScript.Text = "";
            // 
            // btnClipboard
            // 
            this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClipboard.Location = new System.Drawing.Point(12, 265);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(114, 23);
            this.btnClipboard.TabIndex = 1;
            this.btnClipboard.Text = "Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScript.Location = new System.Drawing.Point(300, 265);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(75, 23);
            this.btnRunScript.TabIndex = 2;
            this.btnRunScript.Text = "Run Script";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // btnScriptToolTip
            // 
            this.btnScriptToolTip.AutomaticDelay = 200;
            this.btnScriptToolTip.AutoPopDelay = 2000;
            this.btnScriptToolTip.InitialDelay = 200;
            this.btnScriptToolTip.ReshowDelay = 100;
            // 
            // frmScriptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.btnRunScript);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.txtTableScript);
            this.Name = "frmScriptWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Table SQL Script";
            this.Load += new System.EventHandler(this.frmScriptWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTableScript;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.ToolTip btnScriptToolTip;
    }
}