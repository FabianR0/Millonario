namespace Millo
{
    partial class Form2
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
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gradient1 = new Millo.Gradient();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preguntas Triviales";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(156, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "QUESTION #5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(156, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "QUESTION #1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(156, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "QUESTION #2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(156, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "QUESTION #4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(156, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "QUESTION #3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gradient1
            // 
            this.gradient1.AutoScroll = true;
            this.gradient1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradient1.ColorBottom = System.Drawing.Color.RoyalBlue;
            this.gradient1.ColorTop = System.Drawing.SystemColors.ActiveBorder;
            this.gradient1.Controls.Add(this.button3);
            this.gradient1.Controls.Add(this.button4);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.button5);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Location = new System.Drawing.Point(12, 50);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(452, 505);
            this.gradient1.TabIndex = 6;
            this.gradient1.Visible = false;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 580);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Gradient gradient1;
    }
}