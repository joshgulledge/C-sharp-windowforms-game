
namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HitPointsDisplay = new System.Windows.Forms.Label();
            this.GoldDisplay = new System.Windows.Forms.Label();
            this.ExpDisplay = new System.Windows.Forms.Label();
            this.LevelDisplay = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HitPointsDisplay
            // 
            this.HitPointsDisplay.AutoSize = true;
            this.HitPointsDisplay.Location = new System.Drawing.Point(110, 19);
            this.HitPointsDisplay.Name = "HitPointsDisplay";
            this.HitPointsDisplay.Size = new System.Drawing.Size(22, 25);
            this.HitPointsDisplay.TabIndex = 4;
            this.HitPointsDisplay.Text = "0";
            this.HitPointsDisplay.Click += new System.EventHandler(this.label5_Click);
            // 
            // GoldDisplay
            // 
            this.GoldDisplay.AutoSize = true;
            this.GoldDisplay.Location = new System.Drawing.Point(110, 45);
            this.GoldDisplay.Name = "GoldDisplay";
            this.GoldDisplay.Size = new System.Drawing.Size(22, 25);
            this.GoldDisplay.TabIndex = 5;
            this.GoldDisplay.Text = "0";
            this.GoldDisplay.Click += new System.EventHandler(this.label6_Click);
            // 
            // ExpDisplay
            // 
            this.ExpDisplay.AutoSize = true;
            this.ExpDisplay.Location = new System.Drawing.Point(110, 73);
            this.ExpDisplay.Name = "ExpDisplay";
            this.ExpDisplay.Size = new System.Drawing.Size(22, 25);
            this.ExpDisplay.TabIndex = 6;
            this.ExpDisplay.Text = "0";
            this.ExpDisplay.Click += new System.EventHandler(this.label7_Click);
            // 
            // LevelDisplay
            // 
            this.LevelDisplay.AutoSize = true;
            this.LevelDisplay.Location = new System.Drawing.Point(110, 99);
            this.LevelDisplay.Name = "LevelDisplay";
            this.LevelDisplay.Size = new System.Drawing.Size(22, 25);
            this.LevelDisplay.TabIndex = 8;
            this.LevelDisplay.Text = "0";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(428, 225);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 34);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 634);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.LevelDisplay);
            this.Controls.Add(this.ExpDisplay);
            this.Controls.Add(this.GoldDisplay);
            this.Controls.Add(this.HitPointsDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HitPointsDisplay;
        private System.Windows.Forms.Label GoldDisplay;
        private System.Windows.Forms.Label ExpDisplay;
        private System.Windows.Forms.Label LevelDisplay;
        private System.Windows.Forms.Button btnTest;
    }
}

