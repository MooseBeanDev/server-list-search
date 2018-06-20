namespace AddressSearch1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddressDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnConnectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColumns = new System.Windows.Forms.Button();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchColumn = new System.Windows.Forms.ComboBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelSearchColumn = new System.Windows.Forms.Label();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.labelOpenDetails = new System.Windows.Forms.Label();
            this.richTextBoxFunction = new System.Windows.Forms.RichTextBox();
            this.buttonRDP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxAddress
            // 
            this.textboxAddress.Location = new System.Drawing.Point(12, 24);
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(149, 20);
            this.textboxAddress.TabIndex = 0;
            this.textboxAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textboxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxAddress_KeyDown);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(9, 9);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(44, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Search:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(167, 22);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(64, 23);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Search";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnAddress,
            this.columnAddressDescription,
            this.columnConnectionType});
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(819, 462);
            this.dataGridResults.TabIndex = 5;
            this.dataGridResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResults_CellContentClick);
            this.dataGridResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridResults_CellMouseClick);
            this.dataGridResults.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResults_RowEnter);
            this.dataGridResults.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridResults_RowHeaderMouseClick);
            this.dataGridResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridResults_KeyDown);
            this.dataGridResults.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridResults_KeyUp);
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Width = 140;
            // 
            // columnAddress
            // 
            this.columnAddress.HeaderText = "Address";
            this.columnAddress.Name = "columnAddress";
            // 
            // columnAddressDescription
            // 
            this.columnAddressDescription.HeaderText = "Address Description";
            this.columnAddressDescription.Name = "columnAddressDescription";
            this.columnAddressDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAddressDescription.Width = 120;
            // 
            // columnConnectionType
            // 
            this.columnConnectionType.HeaderText = "Primary Connection";
            this.columnConnectionType.Name = "columnConnectionType";
            this.columnConnectionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnConnectionType.Width = 120;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(237, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridResults);
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 462);
            this.panel1.TabIndex = 7;
            // 
            // buttonColumns
            // 
            this.buttonColumns.Location = new System.Drawing.Point(319, 22);
            this.buttonColumns.Name = "buttonColumns";
            this.buttonColumns.Size = new System.Drawing.Size(104, 23);
            this.buttonColumns.TabIndex = 8;
            this.buttonColumns.Text = "Change Columns";
            this.buttonColumns.UseVisualStyleBackColor = true;
            this.buttonColumns.Click += new System.EventHandler(this.buttonColumns_Click);
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "LIKE",
            "EQUALS"});
            this.comboBoxCondition.Location = new System.Drawing.Point(12, 62);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(98, 21);
            this.comboBoxCondition.TabIndex = 9;
            this.comboBoxCondition.SelectedIndexChanged += new System.EventHandler(this.comboBoxCondition_SelectedIndexChanged);
            this.comboBoxCondition.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCondition_SelectionChangeCommitted);
            // 
            // comboBoxSearchColumn
            // 
            this.comboBoxSearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchColumn.FormattingEnabled = true;
            this.comboBoxSearchColumn.Items.AddRange(new object[] {
            "IP Address",
            "ServerName",
            "Primary Admin",
            "Secondary Admin"});
            this.comboBoxSearchColumn.Location = new System.Drawing.Point(119, 62);
            this.comboBoxSearchColumn.Name = "comboBoxSearchColumn";
            this.comboBoxSearchColumn.Size = new System.Drawing.Size(122, 21);
            this.comboBoxSearchColumn.TabIndex = 10;
            this.comboBoxSearchColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchColumn_SelectedIndexChanged_1);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(9, 48);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(54, 13);
            this.labelCondition.TabIndex = 11;
            this.labelCondition.Text = "Condition:";
            this.labelCondition.Click += new System.EventHandler(this.labelCondition_Click);
            // 
            // labelSearchColumn
            // 
            this.labelSearchColumn.AutoSize = true;
            this.labelSearchColumn.Location = new System.Drawing.Point(116, 48);
            this.labelSearchColumn.Name = "labelSearchColumn";
            this.labelSearchColumn.Size = new System.Drawing.Size(82, 13);
            this.labelSearchColumn.TabIndex = 12;
            this.labelSearchColumn.Text = "Search Column:";
            // 
            // buttonFunction
            // 
            this.buttonFunction.Location = new System.Drawing.Point(521, 4);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(89, 23);
            this.buttonFunction.TabIndex = 13;
            this.buttonFunction.Text = "Open Details";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // labelOpenDetails
            // 
            this.labelOpenDetails.AutoSize = true;
            this.labelOpenDetails.Location = new System.Drawing.Point(521, 13);
            this.labelOpenDetails.Name = "labelOpenDetails";
            this.labelOpenDetails.Size = new System.Drawing.Size(93, 13);
            this.labelOpenDetails.TabIndex = 14;
            this.labelOpenDetails.Text = "Click Row Header";
            this.labelOpenDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxFunction
            // 
            this.richTextBoxFunction.Location = new System.Drawing.Point(521, 32);
            this.richTextBoxFunction.Name = "richTextBoxFunction";
            this.richTextBoxFunction.ReadOnly = true;
            this.richTextBoxFunction.Size = new System.Drawing.Size(311, 77);
            this.richTextBoxFunction.TabIndex = 15;
            this.richTextBoxFunction.Text = "";
            // 
            // buttonRDP
            // 
            this.buttonRDP.Location = new System.Drawing.Point(743, 4);
            this.buttonRDP.Name = "buttonRDP";
            this.buttonRDP.Size = new System.Drawing.Size(89, 23);
            this.buttonRDP.TabIndex = 16;
            this.buttonRDP.Text = "RDP";
            this.buttonRDP.UseVisualStyleBackColor = true;
            this.buttonRDP.Click += new System.EventHandler(this.buttonRDP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 589);
            this.Controls.Add(this.buttonRDP);
            this.Controls.Add(this.richTextBoxFunction);
            this.Controls.Add(this.labelOpenDetails);
            this.Controls.Add(this.buttonFunction);
            this.Controls.Add(this.labelSearchColumn);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.comboBoxSearchColumn);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.buttonColumns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textboxAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(591, 283);
            this.Name = "Form1";
            this.Text = "AddressSearch v02.12.2018.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddressDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnConnectionType;
        private System.Windows.Forms.Button buttonColumns;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.ComboBox comboBoxSearchColumn;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelSearchColumn;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Label labelOpenDetails;
        private System.Windows.Forms.RichTextBox richTextBoxFunction;
        private System.Windows.Forms.Button buttonRDP;
    }
}

