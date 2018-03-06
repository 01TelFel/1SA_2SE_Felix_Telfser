namespace Auto_Simulation
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Auto_erstellen = new System.Windows.Forms.Button();
            this.Tanken = new System.Windows.Forms.Button();
            this.Tanken_E = new System.Windows.Forms.TextBox();
            this.Fahren_E = new System.Windows.Forms.TextBox();
            this.Verbrauch = new System.Windows.Forms.TextBox();
            this.Tankgröße = new System.Windows.Forms.TextBox();
            this.PS = new System.Windows.Forms.TextBox();
            this.Marke = new System.Windows.Forms.TextBox();
            this.Farbe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Fahren = new System.Windows.Forms.Button();
            this.TankBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Auto_erstellen
            // 
            this.Auto_erstellen.Location = new System.Drawing.Point(188, 155);
            this.Auto_erstellen.Name = "Auto_erstellen";
            this.Auto_erstellen.Size = new System.Drawing.Size(202, 38);
            this.Auto_erstellen.TabIndex = 0;
            this.Auto_erstellen.Text = "Auto erstellen";
            this.Auto_erstellen.UseVisualStyleBackColor = true;
            this.Auto_erstellen.Click += new System.EventHandler(this.Auto_erstellen_Click);
            // 
            // Tanken
            // 
            this.Tanken.Location = new System.Drawing.Point(234, 268);
            this.Tanken.Name = "Tanken";
            this.Tanken.Size = new System.Drawing.Size(90, 25);
            this.Tanken.TabIndex = 1;
            this.Tanken.Text = "Tanken!";
            this.Tanken.UseVisualStyleBackColor = true;
            this.Tanken.Click += new System.EventHandler(this.Tanken_Click);
            // 
            // Tanken_E
            // 
            this.Tanken_E.Location = new System.Drawing.Point(44, 271);
            this.Tanken_E.Name = "Tanken_E";
            this.Tanken_E.Size = new System.Drawing.Size(100, 20);
            this.Tanken_E.TabIndex = 2;
            // 
            // Fahren_E
            // 
            this.Fahren_E.Location = new System.Drawing.Point(44, 379);
            this.Fahren_E.Name = "Fahren_E";
            this.Fahren_E.Size = new System.Drawing.Size(100, 20);
            this.Fahren_E.TabIndex = 3;
            // 
            // Verbrauch
            // 
            this.Verbrauch.Location = new System.Drawing.Point(349, 77);
            this.Verbrauch.Name = "Verbrauch";
            this.Verbrauch.Size = new System.Drawing.Size(121, 20);
            this.Verbrauch.TabIndex = 4;
            // 
            // Tankgröße
            // 
            this.Tankgröße.Location = new System.Drawing.Point(349, 51);
            this.Tankgröße.Name = "Tankgröße";
            this.Tankgröße.Size = new System.Drawing.Size(121, 20);
            this.Tankgröße.TabIndex = 5;
            // 
            // PS
            // 
            this.PS.Location = new System.Drawing.Point(120, 104);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(121, 20);
            this.PS.TabIndex = 6;
            // 
            // Marke
            // 
            this.Marke.Location = new System.Drawing.Point(120, 51);
            this.Marke.Name = "Marke";
            this.Marke.Size = new System.Drawing.Size(121, 20);
            this.Marke.TabIndex = 7;
            // 
            // Farbe
            // 
            this.Farbe.FormattingEnabled = true;
            this.Farbe.Items.AddRange(new object[] {
            "Rot",
            "Schwarz",
            "Grün",
            "Violett",
            "Blau",
            "Grau",
            "Silber",
            "Weiß",
            "Orange",
            "Gelb",
            "Braun"});
            this.Farbe.Location = new System.Drawing.Point(120, 77);
            this.Farbe.Name = "Farbe";
            this.Farbe.Size = new System.Drawing.Size(121, 21);
            this.Farbe.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Farbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "PS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tankgröße:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Verbrauch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Liter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "km";
            // 
            // Fahren
            // 
            this.Fahren.Location = new System.Drawing.Point(234, 376);
            this.Fahren.Name = "Fahren";
            this.Fahren.Size = new System.Drawing.Size(90, 25);
            this.Fahren.TabIndex = 16;
            this.Fahren.Text = "Fahren!";
            this.Fahren.UseVisualStyleBackColor = true;
            this.Fahren.Click += new System.EventHandler(this.Fahren_Click);
            // 
            // TankBar
            // 
            this.TankBar.Location = new System.Drawing.Point(44, 297);
            this.TankBar.Name = "TankBar";
            this.TankBar.Size = new System.Drawing.Size(280, 26);
            this.TankBar.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Neues Auto erstellen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tanken:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fahren:";
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(413, 256);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(227, 153);
            this.InfoBox.TabIndex = 21;
            this.InfoBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Informationen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 442);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TankBar);
            this.Controls.Add(this.Fahren);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Farbe);
            this.Controls.Add(this.Marke);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.Tankgröße);
            this.Controls.Add(this.Verbrauch);
            this.Controls.Add(this.Fahren_E);
            this.Controls.Add(this.Tanken_E);
            this.Controls.Add(this.Tanken);
            this.Controls.Add(this.Auto_erstellen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Auto_erstellen;
        private System.Windows.Forms.Button Tanken;
        private System.Windows.Forms.TextBox Tanken_E;
        private System.Windows.Forms.TextBox Fahren_E;
        private System.Windows.Forms.TextBox Verbrauch;
        private System.Windows.Forms.TextBox Tankgröße;
        private System.Windows.Forms.TextBox PS;
        private System.Windows.Forms.TextBox Marke;
        private System.Windows.Forms.ComboBox Farbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Fahren;
        private System.Windows.Forms.ProgressBar TankBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Label label11;
    }
}

