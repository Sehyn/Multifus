namespace Multifus
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LogBox = new System.Windows.Forms.TextBox();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.Personnage1TextBox = new System.Windows.Forms.TextBox();
            this.Personnage2TextBox = new System.Windows.Forms.TextBox();
            this.Personnage3TextBox = new System.Windows.Forms.TextBox();
            this.Personnage4TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidCharnamesBtn = new System.Windows.Forms.Button();
            this.CharSwap = new System.Windows.Forms.Timer(this.components);
            this.LogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Enabled = false;
            this.LogBox.Location = new System.Drawing.Point(6, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(264, 113);
            this.LogBox.TabIndex = 0;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogBox);
            this.LogGroupBox.Location = new System.Drawing.Point(291, 12);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(276, 147);
            this.LogGroupBox.TabIndex = 1;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Logs:";
            // 
            // Personnage1TextBox
            // 
            this.Personnage1TextBox.Location = new System.Drawing.Point(114, 18);
            this.Personnage1TextBox.Name = "Personnage1TextBox";
            this.Personnage1TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage1TextBox.TabIndex = 2;
            // 
            // Personnage2TextBox
            // 
            this.Personnage2TextBox.Location = new System.Drawing.Point(114, 44);
            this.Personnage2TextBox.Name = "Personnage2TextBox";
            this.Personnage2TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage2TextBox.TabIndex = 3;
            // 
            // Personnage3TextBox
            // 
            this.Personnage3TextBox.Location = new System.Drawing.Point(114, 70);
            this.Personnage3TextBox.Name = "Personnage3TextBox";
            this.Personnage3TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage3TextBox.TabIndex = 4;
            // 
            // Personnage4TextBox
            // 
            this.Personnage4TextBox.Location = new System.Drawing.Point(114, 96);
            this.Personnage4TextBox.Name = "Personnage4TextBox";
            this.Personnage4TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage4TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom personnage #1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom personnage #2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom personnage #3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom personnage #4:";
            // 
            // ValidCharnamesBtn
            // 
            this.ValidCharnamesBtn.Location = new System.Drawing.Point(114, 121);
            this.ValidCharnamesBtn.Name = "ValidCharnamesBtn";
            this.ValidCharnamesBtn.Size = new System.Drawing.Size(171, 23);
            this.ValidCharnamesBtn.TabIndex = 10;
            this.ValidCharnamesBtn.Text = "Valider le nom des personnages";
            this.ValidCharnamesBtn.UseVisualStyleBackColor = true;
            this.ValidCharnamesBtn.Click += new System.EventHandler(this.ValidCharnamesBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 150);
            this.Controls.Add(this.ValidCharnamesBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Personnage4TextBox);
            this.Controls.Add(this.Personnage3TextBox);
            this.Controls.Add(this.Personnage2TextBox);
            this.Controls.Add(this.Personnage1TextBox);
            this.Controls.Add(this.LogGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multifus 1.0";
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.TextBox Personnage1TextBox;
        private System.Windows.Forms.TextBox Personnage2TextBox;
        private System.Windows.Forms.TextBox Personnage3TextBox;
        private System.Windows.Forms.TextBox Personnage4TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ValidCharnamesBtn;
        private System.Windows.Forms.Timer CharSwap;
    }
}