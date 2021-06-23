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
            this.TxtGameVer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtHotkey1 = new System.Windows.Forms.TextBox();
            this.TxtHotkey2 = new System.Windows.Forms.TextBox();
            this.TxtHotkey3 = new System.Windows.Forms.TextBox();
            this.TxtHotkey4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.LogGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Enabled = false;
            this.LogBox.Location = new System.Drawing.Point(6, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(373, 113);
            this.LogBox.TabIndex = 0;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.LogBox);
            this.LogGroupBox.Location = new System.Drawing.Point(372, 184);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(385, 155);
            this.LogGroupBox.TabIndex = 1;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Logs:";
            // 
            // Personnage1TextBox
            // 
            this.Personnage1TextBox.Location = new System.Drawing.Point(135, 19);
            this.Personnage1TextBox.Name = "Personnage1TextBox";
            this.Personnage1TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage1TextBox.TabIndex = 2;
            // 
            // Personnage2TextBox
            // 
            this.Personnage2TextBox.Location = new System.Drawing.Point(135, 45);
            this.Personnage2TextBox.Name = "Personnage2TextBox";
            this.Personnage2TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage2TextBox.TabIndex = 3;
            // 
            // Personnage3TextBox
            // 
            this.Personnage3TextBox.Location = new System.Drawing.Point(135, 71);
            this.Personnage3TextBox.Name = "Personnage3TextBox";
            this.Personnage3TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage3TextBox.TabIndex = 4;
            // 
            // Personnage4TextBox
            // 
            this.Personnage4TextBox.Location = new System.Drawing.Point(135, 97);
            this.Personnage4TextBox.Name = "Personnage4TextBox";
            this.Personnage4TextBox.Size = new System.Drawing.Size(171, 20);
            this.Personnage4TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom personnage #1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom personnage #2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom personnage #3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom personnage #4:";
            // 
            // ValidCharnamesBtn
            // 
            this.ValidCharnamesBtn.Location = new System.Drawing.Point(88, 45);
            this.ValidCharnamesBtn.Name = "ValidCharnamesBtn";
            this.ValidCharnamesBtn.Size = new System.Drawing.Size(176, 23);
            this.ValidCharnamesBtn.TabIndex = 10;
            this.ValidCharnamesBtn.Text = "Lancer Multifus";
            this.ValidCharnamesBtn.UseVisualStyleBackColor = true;
            this.ValidCharnamesBtn.Click += new System.EventHandler(this.ValidCharnamesBtn_Click);
            // 
            // TxtGameVer
            // 
            this.TxtGameVer.Location = new System.Drawing.Point(88, 19);
            this.TxtGameVer.Name = "TxtGameVer";
            this.TxtGameVer.Size = new System.Drawing.Size(176, 20);
            this.TxtGameVer.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Version du jeu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Personnage1TextBox);
            this.groupBox1.Controls.Add(this.Personnage2TextBox);
            this.groupBox1.Controls.Add(this.Personnage3TextBox);
            this.groupBox1.Controls.Add(this.Personnage4TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 157);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnages:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.TxtHotkey1);
            this.groupBox2.Controls.Add(this.TxtHotkey2);
            this.groupBox2.Controls.Add(this.TxtHotkey3);
            this.groupBox2.Controls.Add(this.TxtHotkey4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 157);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paramétrage Hotkeys:";
            // 
            // TxtHotkey1
            // 
            this.TxtHotkey1.Location = new System.Drawing.Point(95, 19);
            this.TxtHotkey1.Name = "TxtHotkey1";
            this.TxtHotkey1.Size = new System.Drawing.Size(171, 20);
            this.TxtHotkey1.TabIndex = 10;
            this.TxtHotkey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey1_KeyDown);
            // 
            // TxtHotkey2
            // 
            this.TxtHotkey2.Location = new System.Drawing.Point(95, 45);
            this.TxtHotkey2.Name = "TxtHotkey2";
            this.TxtHotkey2.Size = new System.Drawing.Size(171, 20);
            this.TxtHotkey2.TabIndex = 11;
            this.TxtHotkey2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey2_KeyDown);
            // 
            // TxtHotkey3
            // 
            this.TxtHotkey3.Location = new System.Drawing.Point(95, 71);
            this.TxtHotkey3.Name = "TxtHotkey3";
            this.TxtHotkey3.Size = new System.Drawing.Size(171, 20);
            this.TxtHotkey3.TabIndex = 12;
            this.TxtHotkey3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey3_KeyDown);
            // 
            // TxtHotkey4
            // 
            this.TxtHotkey4.Location = new System.Drawing.Point(95, 97);
            this.TxtHotkey4.Name = "TxtHotkey4";
            this.TxtHotkey4.Size = new System.Drawing.Size(171, 20);
            this.TxtHotkey4.TabIndex = 13;
            this.TxtHotkey4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey4_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Personnage #4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personnage #1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Personnage #3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Personnage #2:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtGameVer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ValidCharnamesBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 155);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paramétrage:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "*Exemple: 2.57.8.11";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(135, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Se souvenir des personnages";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(95, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Se souvenir des Hotkeys";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(88, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(177, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Se souvenir de la version de jeu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 400);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multifus 1.1";
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox TxtGameVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtHotkey1;
        private System.Windows.Forms.TextBox TxtHotkey2;
        private System.Windows.Forms.TextBox TxtHotkey3;
        private System.Windows.Forms.TextBox TxtHotkey4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}