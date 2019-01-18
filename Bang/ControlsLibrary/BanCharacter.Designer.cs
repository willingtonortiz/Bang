namespace Bang.custom_controls
{
    partial class BanCharacter
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageCharacter = new System.Windows.Forms.PictureBox();
            this.imageLife = new System.Windows.Forms.PictureBox();
            this.imageArrow = new System.Windows.Forms.PictureBox();
            this.labelLife = new System.Windows.Forms.Label();
            this.labelArrow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCharacter
            // 
            this.imageCharacter.Location = new System.Drawing.Point(4, 20);
            this.imageCharacter.Name = "imageCharacter";
            this.imageCharacter.Size = new System.Drawing.Size(58, 57);
            this.imageCharacter.TabIndex = 61;
            this.imageCharacter.TabStop = false;
            // 
            // imageLife
            // 
            this.imageLife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageLife.Location = new System.Drawing.Point(7, 83);
            this.imageLife.Name = "imageLife";
            this.imageLife.Size = new System.Drawing.Size(18, 18);
            this.imageLife.TabIndex = 63;
            this.imageLife.TabStop = false;
            // 
            // imageArrow
            // 
            this.imageArrow.Location = new System.Drawing.Point(7, 107);
            this.imageArrow.Name = "imageArrow";
            this.imageArrow.Size = new System.Drawing.Size(18, 18);
            this.imageArrow.TabIndex = 64;
            this.imageArrow.TabStop = false;
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLife.Location = new System.Drawing.Point(31, 83);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(34, 17);
            this.labelLife.TabIndex = 62;
            this.labelLife.Text = "x 11";
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrow.Location = new System.Drawing.Point(31, 107);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(26, 17);
            this.labelArrow.TabIndex = 65;
            this.labelArrow.Text = "x 7";
            // 
            // BanCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.imageCharacter);
            this.Controls.Add(this.imageLife);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.imageArrow);
            this.Name = "BanCharacter";
            this.Size = new System.Drawing.Size(65, 136);
            ((System.ComponentModel.ISupportInitialize)(this.imageCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCharacter;
        private System.Windows.Forms.PictureBox imageLife;
        private System.Windows.Forms.PictureBox imageArrow;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Label labelArrow;
    }
}
