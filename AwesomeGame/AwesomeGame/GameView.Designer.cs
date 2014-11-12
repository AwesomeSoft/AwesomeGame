namespace AwesomeGame
{
    partial class GameView
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.buttonKeyUp = new System.Windows.Forms.Button();
            this.buttonKeyLeft = new System.Windows.Forms.Button();
            this.buttonKeyDown = new System.Windows.Forms.Button();
            this.buttonKeyRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(694, 447);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // buttonKeyUp
            // 
            this.buttonKeyUp.Location = new System.Drawing.Point(87, 474);
            this.buttonKeyUp.Name = "buttonKeyUp";
            this.buttonKeyUp.Size = new System.Drawing.Size(75, 23);
            this.buttonKeyUp.TabIndex = 1;
            this.buttonKeyUp.Text = "up";
            this.buttonKeyUp.UseVisualStyleBackColor = true;
            this.buttonKeyUp.Click += new System.EventHandler(this.buttonKeyUp_Click);
            // 
            // buttonKeyLeft
            // 
            this.buttonKeyLeft.Location = new System.Drawing.Point(12, 503);
            this.buttonKeyLeft.Name = "buttonKeyLeft";
            this.buttonKeyLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonKeyLeft.TabIndex = 2;
            this.buttonKeyLeft.Text = "left";
            this.buttonKeyLeft.UseVisualStyleBackColor = true;
            // 
            // buttonKeyDown
            // 
            this.buttonKeyDown.Location = new System.Drawing.Point(87, 503);
            this.buttonKeyDown.Name = "buttonKeyDown";
            this.buttonKeyDown.Size = new System.Drawing.Size(75, 23);
            this.buttonKeyDown.TabIndex = 3;
            this.buttonKeyDown.Text = "down";
            this.buttonKeyDown.UseVisualStyleBackColor = true;
            // 
            // buttonKeyRight
            // 
            this.buttonKeyRight.Location = new System.Drawing.Point(166, 504);
            this.buttonKeyRight.Name = "buttonKeyRight";
            this.buttonKeyRight.Size = new System.Drawing.Size(75, 21);
            this.buttonKeyRight.TabIndex = 4;
            this.buttonKeyRight.Text = "right";
            this.buttonKeyRight.UseVisualStyleBackColor = true;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 565);
            this.Controls.Add(this.buttonKeyRight);
            this.Controls.Add(this.buttonKeyDown);
            this.Controls.Add(this.buttonKeyLeft);
            this.Controls.Add(this.buttonKeyUp);
            this.Controls.Add(this.GamePanel);
            this.DoubleBuffered = true;
            this.Name = "GameView";
            this.Text = "AwesomeGame";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button buttonKeyUp;
        private System.Windows.Forms.Button buttonKeyLeft;
        private System.Windows.Forms.Button buttonKeyDown;
        private System.Windows.Forms.Button buttonKeyRight;
    }
}

