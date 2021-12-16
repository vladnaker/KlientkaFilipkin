namespace KlientkaFilipkin
{
    partial class trenirovka
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zanyatiya = new System.Windows.Forms.ComboBox();
            this.trener = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить новую запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(650, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Фильтр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trener);
            this.panel1.Controls.Add(this.zanyatiya);
            this.panel1.Location = new System.Drawing.Point(592, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 110);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // zanyatiya
            // 
            this.zanyatiya.FormattingEnabled = true;
            this.zanyatiya.Location = new System.Drawing.Point(3, 18);
            this.zanyatiya.Name = "zanyatiya";
            this.zanyatiya.Size = new System.Drawing.Size(189, 21);
            this.zanyatiya.TabIndex = 0;
            this.zanyatiya.Tag = "ID_zanyatiya";
            // 
            // trener
            // 
            this.trener.FormattingEnabled = true;
            this.trener.Location = new System.Drawing.Point(4, 73);
            this.trener.Name = "trener";
            this.trener.Size = new System.Drawing.Size(188, 21);
            this.trener.TabIndex = 1;
            this.trener.Tag = "ID_trener";
            // 
            // trenirovka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "trenirovka";
            this.Text = "trenirovka";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox trener;
        private System.Windows.Forms.ComboBox zanyatiya;
    }
}