namespace MishinMetodLagranga
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.funcPrinterBox = new System.Windows.Forms.PictureBox();
            this.dgvCoords = new System.Windows.Forms.DataGridView();
            this.buttonFuncPrint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFuncInCoord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.funcPrinterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcPrinterBox
            // 
            this.funcPrinterBox.BackColor = System.Drawing.SystemColors.Control;
            this.funcPrinterBox.Location = new System.Drawing.Point(25, 98);
            this.funcPrinterBox.Margin = new System.Windows.Forms.Padding(4);
            this.funcPrinterBox.Name = "funcPrinterBox";
            this.funcPrinterBox.Size = new System.Drawing.Size(558, 387);
            this.funcPrinterBox.TabIndex = 0;
            this.funcPrinterBox.TabStop = false;
            this.funcPrinterBox.Click += new System.EventHandler(this.funcPrinterBox_Click);
            // 
            // dgvCoords
            // 
            this.dgvCoords.AllowUserToResizeColumns = false;
            this.dgvCoords.AllowUserToResizeRows = false;
            this.dgvCoords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCoords.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCoords.Location = new System.Drawing.Point(646, 98);
            this.dgvCoords.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCoords.Name = "dgvCoords";
            this.dgvCoords.RowHeadersVisible = false;
            this.dgvCoords.RowHeadersWidth = 51;
            this.dgvCoords.Size = new System.Drawing.Size(325, 387);
            this.dgvCoords.TabIndex = 1;
            this.dgvCoords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoords_CellContentClick);
            this.dgvCoords.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoords_CellEndEdit);
            this.dgvCoords.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoords_CellMouseClick);
            // 
            // buttonFuncPrint
            // 
            this.buttonFuncPrint.BackColor = System.Drawing.Color.Black;
            this.buttonFuncPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFuncPrint.ForeColor = System.Drawing.Color.White;
            this.buttonFuncPrint.Location = new System.Drawing.Point(629, 15);
            this.buttonFuncPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFuncPrint.Name = "buttonFuncPrint";
            this.buttonFuncPrint.Size = new System.Drawing.Size(313, 44);
            this.buttonFuncPrint.TabIndex = 2;
            this.buttonFuncPrint.Text = "В полном размере";
            this.buttonFuncPrint.UseVisualStyleBackColor = false;
            this.buttonFuncPrint.Click += new System.EventHandler(this.buttonFuncPrint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(30, 11);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(157, 34);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить таблицу";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFuncInCoord
            // 
            this.buttonFuncInCoord.BackColor = System.Drawing.Color.Black;
            this.buttonFuncInCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFuncInCoord.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFuncInCoord.Location = new System.Drawing.Point(288, 15);
            this.buttonFuncInCoord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFuncInCoord.Name = "buttonFuncInCoord";
            this.buttonFuncInCoord.Size = new System.Drawing.Size(278, 44);
            this.buttonFuncInCoord.TabIndex = 4;
            this.buttonFuncInCoord.Text = " В системе координат";
            this.buttonFuncInCoord.UseVisualStyleBackColor = false;
            this.buttonFuncInCoord.Click += new System.EventHandler(this.buttonFuncInCoord_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите способ просмотра функции:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonFuncInCoord);
            this.groupBox1.Controls.Add(this.buttonFuncPrint);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(954, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(280, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Location = new System.Drawing.Point(25, 493);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(946, 53);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(781, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Закртыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "     X";
            this.Column1.MaxInputLength = 8;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "     Y";
            this.Column2.MaxInputLength = 8;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = " X";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 573);
            this.Controls.Add(this.dgvCoords);
            this.Controls.Add(this.funcPrinterBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1001, 620);
            this.MinimumSize = new System.Drawing.Size(1001, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерполяция с помощью полиномов Лагранжа";
            ((System.ComponentModel.ISupportInitialize)(this.funcPrinterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFuncPrint;
        private System.Windows.Forms.PictureBox funcPrinterBox;
        private System.Windows.Forms.DataGridView dgvCoords;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFuncInCoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}