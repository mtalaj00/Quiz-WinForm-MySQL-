namespace nekiProjekt
{
    partial class QuizMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMain));
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(525, 363);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(200, 50);
            this.buttonD.TabIndex = 19;
            this.buttonD.Tag = "4";
            this.buttonD.Text = "button1";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(175, 363);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(200, 50);
            this.buttonC.TabIndex = 18;
            this.buttonC.Tag = "3";
            this.buttonC.Text = "button2";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(525, 294);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(200, 50);
            this.buttonB.TabIndex = 17;
            this.buttonB.Tag = "2";
            this.buttonB.Text = "buttonB";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.buttonA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(175, 294);
            this.buttonA.MaximumSize = new System.Drawing.Size(400, 50);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(200, 50);
            this.buttonA.TabIndex = 16;
            this.buttonA.Tag = "1";
            this.buttonA.Text = "buttonA";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(182, 88);
            this.label1.MaximumSize = new System.Drawing.Size(550, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Koji je band osnovao Jimmy   Page ? ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuizMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currect";
            this.Load += new System.EventHandler(this.Currect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        public System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label label1;
    }
}