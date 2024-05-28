namespace MinAndraOchSista
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bHämta = new System.Windows.Forms.Button();
            this.bSkapa = new System.Windows.Forms.Button();
            this.bUppdatera = new System.Windows.Forms.Button();
            this.bRadera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(111, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 344);
            this.listBox1.TabIndex = 0;
            // 
            // bHämta
            // 
            this.bHämta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bHämta.Location = new System.Drawing.Point(111, 29);
            this.bHämta.Name = "bHämta";
            this.bHämta.Size = new System.Drawing.Size(116, 36);
            this.bHämta.TabIndex = 1;
            this.bHämta.Text = "Hämta Data";
            this.bHämta.UseVisualStyleBackColor = false;
            this.bHämta.Click += new System.EventHandler(this.bHämta_Click);
            // 
            // bSkapa
            // 
            this.bSkapa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bSkapa.Location = new System.Drawing.Point(488, 29);
            this.bSkapa.Name = "bSkapa";
            this.bSkapa.Size = new System.Drawing.Size(125, 36);
            this.bSkapa.TabIndex = 2;
            this.bSkapa.Text = "Skapa Ny Data";
            this.bSkapa.UseVisualStyleBackColor = false;
            this.bSkapa.Click += new System.EventHandler(this.bSkapa_Click);
            // 
            // bUppdatera
            // 
            this.bUppdatera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bUppdatera.Location = new System.Drawing.Point(349, 29);
            this.bUppdatera.Name = "bUppdatera";
            this.bUppdatera.Size = new System.Drawing.Size(133, 36);
            this.bUppdatera.TabIndex = 3;
            this.bUppdatera.Text = "Uppdatera Data";
            this.bUppdatera.UseVisualStyleBackColor = false;
            // 
            // bRadera
            // 
            this.bRadera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bRadera.Location = new System.Drawing.Point(233, 29);
            this.bRadera.Name = "bRadera";
            this.bRadera.Size = new System.Drawing.Size(110, 36);
            this.bRadera.TabIndex = 4;
            this.bRadera.Text = "Radera Data";
            this.bRadera.UseVisualStyleBackColor = false;
            this.bRadera.Click += new System.EventHandler(this.bRadera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRadera);
            this.Controls.Add(this.bUppdatera);
            this.Controls.Add(this.bSkapa);
            this.Controls.Add(this.bHämta);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bHämta;
        private System.Windows.Forms.Button bSkapa;
        private System.Windows.Forms.Button bUppdatera;
        private System.Windows.Forms.Button bRadera;
    }
}

