namespace KlientkaFilipkin
{
    partial class redCharac
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
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.charac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sport_sooruj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(17, 206);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(143, 23);
            this.buttondel.TabIndex = 29;
            this.buttondel.Text = "Удалить запись";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Visible = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(228, 206);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(143, 23);
            this.buttonedit.TabIndex = 30;
            this.buttonedit.Text = "Изменить запись";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Visible = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // charac
            // 
            this.charac.Location = new System.Drawing.Point(12, 143);
            this.charac.Name = "charac";
            this.charac.Size = new System.Drawing.Size(359, 20);
            this.charac.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Характеристика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Спорт. сооружение";
            // 
            // sport_sooruj
            // 
            this.sport_sooruj.FormattingEnabled = true;
            this.sport_sooruj.Location = new System.Drawing.Point(12, 44);
            this.sport_sooruj.Name = "sport_sooruj";
            this.sport_sooruj.Size = new System.Drawing.Size(359, 21);
            this.sport_sooruj.TabIndex = 25;
            // 
            // redCharac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 303);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.charac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sport_sooruj);
            this.Name = "redCharac";
            this.Text = "redCharac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox charac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sport_sooruj;
    }
}