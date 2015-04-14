namespace SerpientesEscaleras
{
    partial class Tablero
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtJug1 = new System.Windows.Forms.TextBox();
            this.txtJug2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdJug1 = new System.Windows.Forms.Button();
            this.cmdJug2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmdJuegoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador 1";
            // 
            // txtJug1
            // 
            this.txtJug1.Enabled = false;
            this.txtJug1.Location = new System.Drawing.Point(14, 64);
            this.txtJug1.Name = "txtJug1";
            this.txtJug1.Size = new System.Drawing.Size(132, 20);
            this.txtJug1.TabIndex = 3;
            // 
            // txtJug2
            // 
            this.txtJug2.Enabled = false;
            this.txtJug2.Location = new System.Drawing.Point(207, 64);
            this.txtJug2.Name = "txtJug2";
            this.txtJug2.Size = new System.Drawing.Size(132, 20);
            this.txtJug2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jugador 2";
            // 
            // cmdJug1
            // 
            this.cmdJug1.Location = new System.Drawing.Point(40, 114);
            this.cmdJug1.Name = "cmdJug1";
            this.cmdJug1.Size = new System.Drawing.Size(75, 23);
            this.cmdJug1.TabIndex = 0;
            this.cmdJug1.Text = "Lanzar";
            this.cmdJug1.UseVisualStyleBackColor = true;
            this.cmdJug1.Click += new System.EventHandler(this.Lanzar);
            // 
            // cmdJug2
            // 
            this.cmdJug2.Enabled = false;
            this.cmdJug2.Location = new System.Drawing.Point(227, 114);
            this.cmdJug2.Name = "cmdJug2";
            this.cmdJug2.Size = new System.Drawing.Size(75, 23);
            this.cmdJug2.TabIndex = 1;
            this.cmdJug2.Text = "Lanzar";
            this.cmdJug2.UseVisualStyleBackColor = true;
            this.cmdJug2.Click += new System.EventHandler(this.Lanzar);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdJuegoNuevo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmdJuegoNuevo
            // 
            this.cmdJuegoNuevo.Name = "cmdJuegoNuevo";
            this.cmdJuegoNuevo.Size = new System.Drawing.Size(86, 20);
            this.cmdJuegoNuevo.Text = "Juego nuevo";
            this.cmdJuegoNuevo.Click += new System.EventHandler(this.cmdJuegoNuevo_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 154);
            this.Controls.Add(this.cmdJug2);
            this.Controls.Add(this.cmdJug1);
            this.Controls.Add(this.txtJug2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJug1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJug1;
        private System.Windows.Forms.TextBox txtJug2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdJug1;
        private System.Windows.Forms.Button cmdJug2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmdJuegoNuevo;

    }
}

