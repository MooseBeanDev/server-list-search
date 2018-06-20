namespace AddressSearch1
{
    partial class ColumnDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnDialog));
            this.checkListBoxColumns = new System.Windows.Forms.CheckedListBox();
            this.panelColumns = new System.Windows.Forms.Panel();
            this.labelColumns = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkListBoxColumns
            // 
            this.checkListBoxColumns.CheckOnClick = true;
            this.checkListBoxColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListBoxColumns.FormattingEnabled = true;
            this.checkListBoxColumns.Items.AddRange(new object[] {
            "Name",
            "Address",
            "Domain",
            "Function",
            "Type",
            "OS",
            "Network Description",
            "Primary Address",
            "Primary Admin",
            "Secondary Admin"});
            this.checkListBoxColumns.Location = new System.Drawing.Point(0, 0);
            this.checkListBoxColumns.Name = "checkListBoxColumns";
            this.checkListBoxColumns.Size = new System.Drawing.Size(235, 270);
            this.checkListBoxColumns.TabIndex = 0;
            this.checkListBoxColumns.SelectedIndexChanged += new System.EventHandler(this.checkListBoxColumns_SelectedIndexChanged);
            // 
            // panelColumns
            // 
            this.panelColumns.Controls.Add(this.checkListBoxColumns);
            this.panelColumns.Location = new System.Drawing.Point(12, 25);
            this.panelColumns.Name = "panelColumns";
            this.panelColumns.Size = new System.Drawing.Size(235, 270);
            this.panelColumns.TabIndex = 1;
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(13, 9);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(155, 13);
            this.labelColumns.TabIndex = 2;
            this.labelColumns.Text = "Check Box To Display Columns";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(174, 301);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Apply";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 301);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 301);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ColumnDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 331);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.panelColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColumnDialog";
            this.Text = "Choose Columns";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColumnDialog_FormClosed);
            this.Load += new System.EventHandler(this.ColumnDialog_Load);
            this.panelColumns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBoxColumns;
        private System.Windows.Forms.Panel panelColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}