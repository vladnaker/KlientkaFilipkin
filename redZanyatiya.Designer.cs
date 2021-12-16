namespace KlientkaFilipkin
{
    partial class redZanyatiya
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
            this.button1 = new System.Windows.Forms.Button();
            this.sportman = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sportman
            // 
            this.sportman.FormattingEnabled = true;
            this.sportman.Location = new System.Drawing.Point(13, 27);
            this.sportman.Name = "sportman";
            this.sportman.Size = new System.Drawing.Size(338, 21);
            this.sportman.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Спортсмен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Занятие";
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(13, 197);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(143, 23);
            this.buttondel.TabIndex = 0;
            this.buttondel.Text = "Удалить запись";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Visible = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(208, 197);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(143, 23);
            this.buttonedit.TabIndex = 0;
            this.buttonedit.Text = "Изменить запись";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Visible = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // redZanyatiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sportman);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.button1);
            this.Name = "redZanyatiya";
            this.Text = "redZanyatiya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sportman;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonedit;
    }
}