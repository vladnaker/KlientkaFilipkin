namespace KlientkaFilipkin
{
    partial class redSportman
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
            this.sportman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.club = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(17, 218);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(143, 23);
            this.buttondel.TabIndex = 22;
            this.buttondel.Text = "Удалить запись";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Visible = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(228, 218);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(143, 23);
            this.buttonedit.TabIndex = 23;
            this.buttonedit.Text = "Изменить запись";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Visible = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sportman
            // 
            this.sportman.Location = new System.Drawing.Point(12, 155);
            this.sportman.Name = "sportman";
            this.sportman.Size = new System.Drawing.Size(359, 20);
            this.sportman.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Спортсмен";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Клуб";
            // 
            // club
            // 
            this.club.FormattingEnabled = true;
            this.club.Location = new System.Drawing.Point(12, 56);
            this.club.Name = "club";
            this.club.Size = new System.Drawing.Size(359, 21);
            this.club.TabIndex = 18;
            // 
            // redSportman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 313);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sportman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.club);
            this.Name = "redSportman";
            this.Text = "redSportman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sportman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox club;
    }
}