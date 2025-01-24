namespace Prozor
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
            this.gumb = new System.Windows.Forms.Button();
            this.labela = new System.Windows.Forms.Label();
            this.pitanje = new System.Windows.Forms.Label();
            this.milanovic = new System.Windows.Forms.Button();
            this.primorac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumb
            // 
            this.gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumb.ForeColor = System.Drawing.Color.Red;
            this.gumb.Location = new System.Drawing.Point(156, 139);
            this.gumb.Name = "gumb";
            this.gumb.Size = new System.Drawing.Size(166, 53);
            this.gumb.TabIndex = 0;
            this.gumb.Text = "Klikni me!";
            this.gumb.UseVisualStyleBackColor = true;
            this.gumb.Click += new System.EventHandler(this.gumb_Click);
            this.gumb.MouseEnter += new System.EventHandler(this.gumb_MouseEnter);
            this.gumb.MouseLeave += new System.EventHandler(this.gumb_MouseLeave);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(408, 151);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(35, 13);
            this.labela.TabIndex = 1;
            this.labela.Text = "label1";
            // 
            // pitanje
            // 
            this.pitanje.AutoSize = true;
            this.pitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitanje.Location = new System.Drawing.Point(112, 254);
            this.pitanje.Name = "pitanje";
            this.pitanje.Padding = new System.Windows.Forms.Padding(5);
            this.pitanje.Size = new System.Drawing.Size(165, 30);
            this.pitanje.TabIndex = 2;
            this.pitanje.Text = "Za koga ćeš glasati?";
            // 
            // milanovic
            // 
            this.milanovic.Location = new System.Drawing.Point(116, 346);
            this.milanovic.Name = "milanovic";
            this.milanovic.Size = new System.Drawing.Size(103, 23);
            this.milanovic.TabIndex = 3;
            this.milanovic.Text = "Zoran Milanović";
            this.milanovic.UseVisualStyleBackColor = true;
            this.milanovic.Click += new System.EventHandler(this.milanovic_Click);
            // 
            // primorac
            // 
            this.primorac.Location = new System.Drawing.Point(116, 304);
            this.primorac.Name = "primorac";
            this.primorac.Size = new System.Drawing.Size(103, 23);
            this.primorac.TabIndex = 4;
            this.primorac.Text = "Dragan Primorac";
            this.primorac.UseVisualStyleBackColor = true;
            this.primorac.MouseEnter += new System.EventHandler(this.primorac_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primorac);
            this.Controls.Add(this.milanovic);
            this.Controls.Add(this.pitanje);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.gumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumb;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label pitanje;
        private System.Windows.Forms.Button milanovic;
        private System.Windows.Forms.Button primorac;
    }
}

