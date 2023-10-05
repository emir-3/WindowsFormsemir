
namespace WindowsFormsemir.formas
{
    partial class Formapesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.Label();
            this.textLatidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxpesos = new System.Windows.Forms.TextBox();
            this.textBoxdolares = new System.Windows.Forms.TextBox();
            this.textBoxeuros = new System.Windows.Forms.TextBox();
            this.buttondolares = new System.Windows.Forms.Button();
            this.buttoneuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "conversión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textEdad
            // 
            this.textEdad.AutoSize = true;
            this.textEdad.BackColor = System.Drawing.Color.Pink;
            this.textEdad.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textEdad.Location = new System.Drawing.Point(87, 107);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(129, 39);
            this.textEdad.TabIndex = 26;
            this.textEdad.Text = "pesos";
            this.textEdad.Click += new System.EventHandler(this.textEdad_Click);
            // 
            // textLatidos
            // 
            this.textLatidos.AutoSize = true;
            this.textLatidos.BackColor = System.Drawing.Color.Pink;
            this.textLatidos.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLatidos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textLatidos.Location = new System.Drawing.Point(50, 175);
            this.textLatidos.Name = "textLatidos";
            this.textLatidos.Size = new System.Drawing.Size(167, 39);
            this.textLatidos.TabIndex = 27;
            this.textLatidos.Text = "dolares";
            this.textLatidos.Click += new System.EventHandler(this.textLatidos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(87, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "euros";
            // 
            // textBoxpesos
            // 
            this.textBoxpesos.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpesos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxpesos.Location = new System.Drawing.Point(232, 103);
            this.textBoxpesos.Name = "textBoxpesos";
            this.textBoxpesos.Size = new System.Drawing.Size(436, 43);
            this.textBoxpesos.TabIndex = 29;
            this.textBoxpesos.TextChanged += new System.EventHandler(this.textBoxpesos_TextChanged);
            // 
            // textBoxdolares
            // 
            this.textBoxdolares.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdolares.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxdolares.Location = new System.Drawing.Point(232, 174);
            this.textBoxdolares.Name = "textBoxdolares";
            this.textBoxdolares.Size = new System.Drawing.Size(436, 43);
            this.textBoxdolares.TabIndex = 30;
            // 
            // textBoxeuros
            // 
            this.textBoxeuros.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxeuros.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxeuros.Location = new System.Drawing.Point(232, 245);
            this.textBoxeuros.Name = "textBoxeuros";
            this.textBoxeuros.Size = new System.Drawing.Size(436, 43);
            this.textBoxeuros.TabIndex = 31;
            // 
            // buttondolares
            // 
            this.buttondolares.BackColor = System.Drawing.Color.Pink;
            this.buttondolares.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondolares.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttondolares.Location = new System.Drawing.Point(232, 323);
            this.buttondolares.Name = "buttondolares";
            this.buttondolares.Size = new System.Drawing.Size(141, 52);
            this.buttondolares.TabIndex = 32;
            this.buttondolares.Text = "dolares";
            this.buttondolares.UseVisualStyleBackColor = false;
            this.buttondolares.Click += new System.EventHandler(this.buttondolares_Click);
            // 
            // buttoneuros
            // 
            this.buttoneuros.BackColor = System.Drawing.Color.Pink;
            this.buttoneuros.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneuros.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttoneuros.Location = new System.Drawing.Point(403, 323);
            this.buttoneuros.Name = "buttoneuros";
            this.buttoneuros.Size = new System.Drawing.Size(141, 52);
            this.buttoneuros.TabIndex = 33;
            this.buttoneuros.Text = "euros";
            this.buttoneuros.UseVisualStyleBackColor = false;
            this.buttoneuros.Click += new System.EventHandler(this.buttoeuros_Click);
            // 
            // Formapesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsemir.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoneuros);
            this.Controls.Add(this.buttondolares);
            this.Controls.Add(this.textBoxeuros);
            this.Controls.Add(this.textBoxdolares);
            this.Controls.Add(this.textBoxpesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLatidos);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Formapesos";
            this.Text = "Formapesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textEdad;
        private System.Windows.Forms.Label textLatidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxpesos;
        private System.Windows.Forms.TextBox textBoxdolares;
        private System.Windows.Forms.TextBox textBoxeuros;
        private System.Windows.Forms.Button buttondolares;
        private System.Windows.Forms.Button buttoneuros;
    }
}