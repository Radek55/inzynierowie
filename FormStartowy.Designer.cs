using AplikacjaInzynierka.Constans;
namespace AplikacjaInzynierka.Wprowadzenie
{
    partial class FormStartowy
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
            this.WprowadzenieTekst = new System.Windows.Forms.Label();
            this.WprowadzeniePrzycisk = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.kod = new System.Windows.Forms.TextBox();
            this.instrukcja = new System.Windows.Forms.Label();
            this.dalej = new System.Windows.Forms.Button();
            this.nagranie1 = new System.Windows.Forms.Label();
            this.nagranie2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // WprowadzenieTekst
            // 
            this.WprowadzenieTekst.AutoSize = true;
            this.WprowadzenieTekst.Location = new System.Drawing.Point(54, 85);
            this.WprowadzenieTekst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WprowadzenieTekst.Name = "WprowadzenieTekst";
            this.WprowadzenieTekst.Size = new System.Drawing.Size(176, 105);
            this.WprowadzenieTekst.TabIndex = 1;
            this.WprowadzenieTekst.Text = "Siema, tutaj tekst wprowadzenia\r\nw\r\nw\r\nw\r\n\r\n\r\nPodaj kod użytkownika";
            this.WprowadzenieTekst.Click += new System.EventHandler(this.label1_Click);
            // 
            // WprowadzeniePrzycisk
            // 
            this.WprowadzeniePrzycisk.Location = new System.Drawing.Point(538, 270);
            this.WprowadzeniePrzycisk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.WprowadzeniePrzycisk.Name = "WprowadzeniePrzycisk";
            this.WprowadzeniePrzycisk.Size = new System.Drawing.Size(81, 23);
            this.WprowadzeniePrzycisk.TabIndex = 2;
            this.WprowadzeniePrzycisk.Text = "Start";
            this.WprowadzeniePrzycisk.UseVisualStyleBackColor = true;
            this.WprowadzeniePrzycisk.Click += new System.EventHandler(this.WprowadzeniePrzycisk_Click);
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(54, 193);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(236, 23);
            this.kod.TabIndex = 3;
            // 
            // instrukcja
            // 
            this.instrukcja.AutoSize = true;
            this.instrukcja.Location = new System.Drawing.Point(54, 85);
            this.instrukcja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instrukcja.Name = "instrukcja";
            this.instrukcja.Size = new System.Drawing.Size(83, 15);
            this.instrukcja.TabIndex = 4;
            this.instrukcja.Text = "tekst instrukcji\r\n";
            // 
            // dalej
            // 
            this.dalej.Location = new System.Drawing.Point(538, 270);
            this.dalej.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(81, 23);
            this.dalej.TabIndex = 5;
            this.dalej.Text = "Dalej";
            this.dalej.UseVisualStyleBackColor = true;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // nagranie1
            // 
            this.nagranie1.AutoSize = true;
            this.nagranie1.Location = new System.Drawing.Point(166, 85);
            this.nagranie1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nagranie1.Name = "nagranie1";
            this.nagranie1.Size = new System.Drawing.Size(64, 15);
            this.nagranie1.TabIndex = 6;
            this.nagranie1.Text = "Nagranie 1";
            // 
            // nagranie2
            // 
            this.nagranie2.AutoSize = true;
            this.nagranie2.Location = new System.Drawing.Point(414, 85);
            this.nagranie2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nagranie2.Name = "nagranie2";
            this.nagranie2.Size = new System.Drawing.Size(64, 15);
            this.nagranie2.TabIndex = 7;
            this.nagranie2.Text = "Nagranie 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(438, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(185, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 310);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nagranie2);
            this.Controls.Add(this.nagranie1);
            this.Controls.Add(this.dalej);
            this.Controls.Add(this.instrukcja);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.WprowadzeniePrzycisk);
            this.Controls.Add(this.WprowadzenieTekst);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormStartowy";
            this.Text = "Badanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WprowadzenieTekst;
        private Button WprowadzeniePrzycisk;
        private FontDialog fontDialog1;
        private FontDialog fontDialog2;
        private TextBox kod;
        private Label instrukcja;
        private Button dalej;
        private Label nagranie1;
        private Label nagranie2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}