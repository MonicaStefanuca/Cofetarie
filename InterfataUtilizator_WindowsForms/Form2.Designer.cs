namespace InterfataUtilizator_WindowsForms
{
    partial class AdaugaProdus
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
            this.NumeProdus = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.Pret = new System.Windows.Forms.Label();
            this.Gramaj = new System.Windows.Forms.Label();
            this.Descriere = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.idProdus = new System.Windows.Forms.TextBox();
            this.descriereProdus = new System.Windows.Forms.TextBox();
            this.pretProdus = new System.Windows.Forms.TextBox();
            this.gramajProdus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adauga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumarProdusePreparate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pretBox = new System.Windows.Forms.CheckBox();
            this.gramajBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NumeProdus
            // 
            this.NumeProdus.Location = new System.Drawing.Point(147, 106);
            this.NumeProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumeProdus.Name = "NumeProdus";
            this.NumeProdus.Size = new System.Drawing.Size(248, 22);
            this.NumeProdus.TabIndex = 0;
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Nume.Location = new System.Drawing.Point(16, 103);
            this.Nume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(64, 25);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume";
            this.Nume.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pret
            // 
            this.Pret.AutoSize = true;
            this.Pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pret.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Pret.Location = new System.Drawing.Point(17, 224);
            this.Pret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(47, 25);
            this.Pret.TabIndex = 2;
            this.Pret.Text = "Pret";
            this.Pret.Click += new System.EventHandler(this.label2_Click);
            // 
            // Gramaj
            // 
            this.Gramaj.AutoSize = true;
            this.Gramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gramaj.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Gramaj.Location = new System.Drawing.Point(17, 269);
            this.Gramaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gramaj.Name = "Gramaj";
            this.Gramaj.Size = new System.Drawing.Size(75, 25);
            this.Gramaj.TabIndex = 3;
            this.Gramaj.Text = "Gramaj";
            this.Gramaj.Click += new System.EventHandler(this.label3_Click);
            // 
            // Descriere
            // 
            this.Descriere.AutoSize = true;
            this.Descriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriere.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Descriere.Location = new System.Drawing.Point(16, 187);
            this.Descriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descriere.Name = "Descriere";
            this.Descriere.Size = new System.Drawing.Size(95, 25);
            this.Descriere.TabIndex = 4;
            this.Descriere.Text = "Descriere";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.SaddleBrown;
            this.id.Location = new System.Drawing.Point(16, 145);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 25);
            this.id.TabIndex = 5;
            this.id.Text = "Id";
            // 
            // idProdus
            // 
            this.idProdus.Location = new System.Drawing.Point(147, 145);
            this.idProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idProdus.Name = "idProdus";
            this.idProdus.Size = new System.Drawing.Size(248, 22);
            this.idProdus.TabIndex = 6;
            // 
            // descriereProdus
            // 
            this.descriereProdus.Location = new System.Drawing.Point(147, 187);
            this.descriereProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriereProdus.Name = "descriereProdus";
            this.descriereProdus.Size = new System.Drawing.Size(248, 22);
            this.descriereProdus.TabIndex = 7;
            // 
            // pretProdus
            // 
            this.pretProdus.Location = new System.Drawing.Point(147, 227);
            this.pretProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pretProdus.Name = "pretProdus";
            this.pretProdus.Size = new System.Drawing.Size(248, 22);
            this.pretProdus.TabIndex = 8;
            // 
            // gramajProdus
            // 
            this.gramajProdus.Location = new System.Drawing.Point(147, 269);
            this.gramajProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gramajProdus.Name = "gramajProdus";
            this.gramajProdus.Size = new System.Drawing.Size(248, 22);
            this.gramajProdus.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(43, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 52);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adaugare produs";
            // 
            // adauga
            // 
            this.adauga.BackColor = System.Drawing.Color.SaddleBrown;
            this.adauga.ForeColor = System.Drawing.Color.PeachPuff;
            this.adauga.Location = new System.Drawing.Point(161, 447);
            this.adauga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(100, 28);
            this.adauga.TabIndex = 11;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 310);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 13;
            // 
            // NumarProdusePreparate
            // 
            this.NumarProdusePreparate.AutoSize = true;
            this.NumarProdusePreparate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumarProdusePreparate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.NumarProdusePreparate.Location = new System.Drawing.Point(17, 310);
            this.NumarProdusePreparate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumarProdusePreparate.Name = "NumarProdusePreparate";
            this.NumarProdusePreparate.Size = new System.Drawing.Size(75, 25);
            this.NumarProdusePreparate.TabIndex = 12;
            this.NumarProdusePreparate.Text = "Numar ";
            this.NumarProdusePreparate.Click += new System.EventHandler(this.NumarProdusePreparate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(17, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "produse preparate";
            // 
            // pretBox
            // 
            this.pretBox.AutoSize = true;
            this.pretBox.BackColor = System.Drawing.Color.BurlyWood;
            this.pretBox.Location = new System.Drawing.Point(224, 394);
            this.pretBox.Name = "pretBox";
            this.pretBox.Size = new System.Drawing.Size(168, 20);
            this.pretBox.TabIndex = 15;
            this.pretBox.Text = "Am introdus pretul in lei.";
            this.pretBox.UseVisualStyleBackColor = false;
            // 
            // gramajBox
            // 
            this.gramajBox.AutoSize = true;
            this.gramajBox.BackColor = System.Drawing.Color.BurlyWood;
            this.gramajBox.Location = new System.Drawing.Point(224, 420);
            this.gramajBox.Name = "gramajBox";
            this.gramajBox.Size = new System.Drawing.Size(212, 20);
            this.gramajBox.TabIndex = 16;
            this.gramajBox.Text = "Am introdus gramajul in grame.";
            this.gramajBox.UseVisualStyleBackColor = false;
            // 
            // AdaugaProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(448, 498);
            this.Controls.Add(this.gramajBox);
            this.Controls.Add(this.pretBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumarProdusePreparate);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gramajProdus);
            this.Controls.Add(this.pretProdus);
            this.Controls.Add(this.descriereProdus);
            this.Controls.Add(this.idProdus);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Descriere);
            this.Controls.Add(this.Gramaj);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.NumeProdus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdaugaProdus";
            this.Text = "AdaugaProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeProdus;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Pret;
        private System.Windows.Forms.Label Gramaj;
        private System.Windows.Forms.Label Descriere;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idProdus;
        private System.Windows.Forms.TextBox descriereProdus;
        private System.Windows.Forms.TextBox pretProdus;
        private System.Windows.Forms.TextBox gramajProdus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NumarProdusePreparate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox pretBox;
        private System.Windows.Forms.CheckBox gramajBox;
    }
}