namespace Multifus
{
    partial class Bienvenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenue));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.CharteUtilisation = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.RefuseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MultifusLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CharteUtilisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-34, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Location = new System.Drawing.Point(6, 25);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(422, 182);
            this.DisclaimerLabel.TabIndex = 1;
            this.DisclaimerLabel.Text = resources.GetString("DisclaimerLabel.Text");
            // 
            // CharteUtilisation
            // 
            this.CharteUtilisation.Controls.Add(this.label3);
            this.CharteUtilisation.Controls.Add(this.DisclaimerLabel);
            this.CharteUtilisation.Location = new System.Drawing.Point(125, 5);
            this.CharteUtilisation.Name = "CharteUtilisation";
            this.CharteUtilisation.Size = new System.Drawing.Size(440, 230);
            this.CharteUtilisation.TabIndex = 2;
            this.CharteUtilisation.TabStop = false;
            this.CharteUtilisation.Text = "Charte d\'utilisation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(268, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dernière mise à jour le 09/10/20 - à 15:31";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(125, 241);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(440, 25);
            this.AcceptBtn.TabIndex = 3;
            this.AcceptBtn.Text = "J\'accepte et ai conscience de la charte d\'utilisation";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // RefuseBtn
            // 
            this.RefuseBtn.Location = new System.Drawing.Point(125, 270);
            this.RefuseBtn.Name = "RefuseBtn";
            this.RefuseBtn.Size = new System.Drawing.Size(440, 25);
            this.RefuseBtn.TabIndex = 4;
            this.RefuseBtn.Text = "Je refuse la charte d\'utilisation";
            this.RefuseBtn.UseVisualStyleBackColor = true;
            this.RefuseBtn.Click += new System.EventHandler(this.RefuseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(2, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(39, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "1.0";
            // 
            // MultifusLink
            // 
            this.MultifusLink.AutoSize = true;
            this.MultifusLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.MultifusLink.Location = new System.Drawing.Point(18, 155);
            this.MultifusLink.Name = "MultifusLink";
            this.MultifusLink.Size = new System.Drawing.Size(84, 12);
            this.MultifusLink.TabIndex = 7;
            this.MultifusLink.TabStop = true;
            this.MultifusLink.Text = "https://multifus.net";
            // 
            // Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 300);
            this.Controls.Add(this.MultifusLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefuseBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.CharteUtilisation);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multifus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CharteUtilisation.ResumeLayout(false);
            this.CharteUtilisation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DisclaimerLabel;
        private System.Windows.Forms.GroupBox CharteUtilisation;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button RefuseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel MultifusLink;
    }
}

