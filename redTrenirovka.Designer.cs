namespace KlientkaFilipkin
{
    partial class redTrenirovka
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
            this.zanyatiya = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trener = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zanyatiya
            // 
            this.zanyatiya.FormattingEnabled = true;
            this.zanyatiya.Location = new System.Drawing.Point(12, 59);
            this.zanyatiya.Name = "zanyatiya";
            this.zanyatiya.Size = new System.Drawing.Size(422, 21);
            this.zanyatiya.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Занятия";
            // 
            // trener
            // 
            this.trener.FormattingEnabled = true;
            this.trener.Location = new System.Drawing.Point(12, 144);
            this.trener.Name = "trener";
            this.trener.Size = new System.Drawing.Size(422, 21);
            this.trener.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(193, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тренер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(184, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тренировка";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(51, 310);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(143, 23);
            this.buttondel.TabIndex = 6;
            this.buttondel.Text = "Удалить запись";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Visible = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(246, 310);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(143, 23);
            this.buttonedit.TabIndex = 7;
            this.buttonedit.Text = "Изменить запись";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Visible = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redTrenirovka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 409);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trener);
            this.Controls.Add(this.zanyatiya);
            this.Name = "redTrenirovka";
            this.Text = "redTrenirovka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox zanyatiya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox trener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button button1;
    }
}