namespace TimeTraderForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNY = new System.Windows.Forms.Label();
            this.grpNY = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLondon = new System.Windows.Forms.Label();
            this.pbLondon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpNY.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLondon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblNY
            // 
            this.lblNY.AutoSize = true;
            this.lblNY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNY.Location = new System.Drawing.Point(73, 233);
            this.lblNY.Name = "lblNY";
            this.lblNY.Size = new System.Drawing.Size(95, 16);
            this.lblNY.TabIndex = 1;
            this.lblNY.Text = "LOCAL TIME";
            this.lblNY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpNY
            // 
            this.grpNY.Controls.Add(this.pictureBox1);
            this.grpNY.Controls.Add(this.lblNY);
            this.grpNY.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNY.Location = new System.Drawing.Point(12, 12);
            this.grpNY.Name = "grpNY";
            this.grpNY.Size = new System.Drawing.Size(248, 262);
            this.grpNY.TabIndex = 3;
            this.grpNY.TabStop = false;
            this.grpNY.Text = "New York TIME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLondon);
            this.groupBox2.Controls.Add(this.pbLondon);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 262);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "London TIME";
            // 
            // lblLondon
            // 
            this.lblLondon.AutoSize = true;
            this.lblLondon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLondon.Location = new System.Drawing.Point(73, 233);
            this.lblLondon.Name = "lblLondon";
            this.lblLondon.Size = new System.Drawing.Size(95, 16);
            this.lblLondon.TabIndex = 1;
            this.lblLondon.Text = "LOCAL TIME";
            this.lblLondon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLondon
            // 
            this.pbLondon.Location = new System.Drawing.Point(23, 22);
            this.pbLondon.Name = "pbLondon";
            this.pbLondon.Size = new System.Drawing.Size(205, 205);
            this.pbLondon.TabIndex = 0;
            this.pbLondon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpNY);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpNY.ResumeLayout(false);
            this.grpNY.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLondon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNY;
        private System.Windows.Forms.GroupBox grpNY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLondon;
        private System.Windows.Forms.PictureBox pbLondon;
    }
}

