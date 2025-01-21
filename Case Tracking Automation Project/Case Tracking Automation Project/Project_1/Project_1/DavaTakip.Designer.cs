namespace Project_1
{
    partial class DavaTakip
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
            DavaNotextBox = new TextBox();
            DavaNo = new Label();
            dataGridViewDavaTakip = new DataGridView();
            Ara = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaTakip).BeginInit();
            SuspendLayout();
            // 
            // DavaNotextBox
            // 
            DavaNotextBox.BackColor = Color.White;
            DavaNotextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DavaNotextBox.Location = new Point(146, 21);
            DavaNotextBox.Name = "DavaNotextBox";
            DavaNotextBox.Size = new Size(174, 30);
            DavaNotextBox.TabIndex = 13;
            // 
            // DavaNo
            // 
            DavaNo.AutoSize = true;
            DavaNo.BackColor = Color.Transparent;
            DavaNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DavaNo.Location = new Point(34, 21);
            DavaNo.Name = "DavaNo";
            DavaNo.Size = new Size(81, 23);
            DavaNo.TabIndex = 12;
            DavaNo.Text = "Dava No:";
            // 
            // dataGridViewDavaTakip
            // 
            dataGridViewDavaTakip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDavaTakip.Location = new Point(34, 72);
            dataGridViewDavaTakip.Name = "dataGridViewDavaTakip";
            dataGridViewDavaTakip.RowHeadersWidth = 51;
            dataGridViewDavaTakip.Size = new Size(670, 270);
            dataGridViewDavaTakip.TabIndex = 14;
            // 
            // Ara
            // 
            Ara.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Ara.Location = new Point(452, 22);
            Ara.Name = "Ara";
            Ara.Size = new Size(94, 29);
            Ara.TabIndex = 15;
            Ara.Text = "Ara";
            Ara.UseVisualStyleBackColor = true;
            Ara.Click += Ara_Click;
            // 
            // DavaTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 379);
            Controls.Add(Ara);
            Controls.Add(dataGridViewDavaTakip);
            Controls.Add(DavaNotextBox);
            Controls.Add(DavaNo);
            Name = "DavaTakip";
            Text = "DavaTakip";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDavaTakip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DavaNotextBox;
        private Label DavaNo;
        private DataGridView dataGridViewDavaTakip;
        private Button Ara;
    }
}