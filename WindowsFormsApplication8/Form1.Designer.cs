namespace WindowsFormsApplication8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNameQuest = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdbGood = new System.Windows.Forms.RadioButton();
            this.rdbStupidious = new System.Windows.Forms.RadioButton();
            this.rdbGrinch = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Is Your Name?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNameQuest
            // 
            this.txbNameQuest.Location = new System.Drawing.Point(26, 107);
            this.txbNameQuest.Name = "txbNameQuest";
            this.txbNameQuest.Size = new System.Drawing.Size(100, 20);
            this.txbNameQuest.TabIndex = 1;
            this.txbNameQuest.TextChanged += new System.EventHandler(this.txbNameQuest_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(192, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(237, 44);
            this.lblResult.TabIndex = 2;
            // 
            // rdbGood
            // 
            this.rdbGood.AutoSize = true;
            this.rdbGood.Location = new System.Drawing.Point(40, 191);
            this.rdbGood.Name = "rdbGood";
            this.rdbGood.Size = new System.Drawing.Size(51, 17);
            this.rdbGood.TabIndex = 3;
            this.rdbGood.TabStop = true;
            this.rdbGood.Text = "Good";
            this.rdbGood.UseVisualStyleBackColor = true;
            this.rdbGood.CheckedChanged += new System.EventHandler(this.rdbGood_CheckedChanged);
            // 
            // rdbStupidious
            // 
            this.rdbStupidious.AutoSize = true;
            this.rdbStupidious.Location = new System.Drawing.Point(40, 238);
            this.rdbStupidious.Name = "rdbStupidious";
            this.rdbStupidious.Size = new System.Drawing.Size(74, 17);
            this.rdbStupidious.TabIndex = 4;
            this.rdbStupidious.TabStop = true;
            this.rdbStupidious.Text = "Stupidious";
            this.rdbStupidious.UseVisualStyleBackColor = true;
            this.rdbStupidious.CheckedChanged += new System.EventHandler(this.rdbStupidious_CheckedChanged);
            // 
            // rdbGrinch
            // 
            this.rdbGrinch.AutoSize = true;
            this.rdbGrinch.Location = new System.Drawing.Point(40, 271);
            this.rdbGrinch.Name = "rdbGrinch";
            this.rdbGrinch.Size = new System.Drawing.Size(130, 17);
            this.rdbGrinch.TabIndex = 5;
            this.rdbGrinch.TabStop = true;
            this.rdbGrinch.Text = "I Feel Like The Grinch";
            this.rdbGrinch.UseVisualStyleBackColor = true;
            this.rdbGrinch.CheckedChanged += new System.EventHandler(this.rdbGrinch_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(52, 330);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 378);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.rdbGrinch);
            this.Controls.Add(this.rdbStupidious);
            this.Controls.Add(this.rdbGood);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbNameQuest);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameQuest;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdbGood;
        private System.Windows.Forms.RadioButton rdbStupidious;
        private System.Windows.Forms.RadioButton rdbGrinch;
        private System.Windows.Forms.Label lblDisplay;
    }
}

