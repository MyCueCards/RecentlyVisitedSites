namespace EhrmanHarleyRecentlyVisitedSites
{
    partial class RecentlyVisitedSites
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPoorlyDrawnLines = new System.Windows.Forms.LinkLabel();
            this.lblTrashBird = new System.Windows.Forms.LinkLabel();
            this.lblTheJoyOfSeex = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblPoorlyDrawnLines);
            this.flowLayoutPanel1.Controls.Add(this.lblTrashBird);
            this.flowLayoutPanel1.Controls.Add(this.lblTheJoyOfSeex);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 125);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // lblPoorlyDrawnLines
            // 
            this.lblPoorlyDrawnLines.AutoSize = true;
            this.lblPoorlyDrawnLines.Location = new System.Drawing.Point(3, 0);
            this.lblPoorlyDrawnLines.Name = "lblPoorlyDrawnLines";
            this.lblPoorlyDrawnLines.Size = new System.Drawing.Size(198, 25);
            this.lblPoorlyDrawnLines.TabIndex = 0;
            this.lblPoorlyDrawnLines.TabStop = true;
            this.lblPoorlyDrawnLines.Text = "Poorly Drawn Lines";
            this.lblPoorlyDrawnLines.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.lblPoorlyDrawnLines.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // lblTrashBird
            // 
            this.lblTrashBird.AutoSize = true;
            this.lblTrashBird.Location = new System.Drawing.Point(3, 25);
            this.lblTrashBird.Name = "lblTrashBird";
            this.lblTrashBird.Size = new System.Drawing.Size(111, 25);
            this.lblTrashBird.TabIndex = 0;
            this.lblTrashBird.TabStop = true;
            this.lblTrashBird.Text = "Trash Bird";
            this.lblTrashBird.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.lblTrashBird.MouseHover += new System.EventHandler(this.linkLabel2_MouseHover);
            // 
            // lblTheJoyOfSeex
            // 
            this.lblTheJoyOfSeex.AutoSize = true;
            this.lblTheJoyOfSeex.Location = new System.Drawing.Point(3, 50);
            this.lblTheJoyOfSeex.Name = "lblTheJoyOfSeex";
            this.lblTheJoyOfSeex.Size = new System.Drawing.Size(168, 25);
            this.lblTheJoyOfSeex.TabIndex = 0;
            this.lblTheJoyOfSeex.TabStop = true;
            this.lblTheJoyOfSeex.Text = "The Joy of Seex";
            this.lblTheJoyOfSeex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            this.lblTheJoyOfSeex.MouseHover += new System.EventHandler(this.linkLabel3_MouseHover);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(344, 21);
            this.lblDescription.MaximumSize = new System.Drawing.Size(300, 400);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 25);
            this.lblDescription.TabIndex = 1;
            // 
            // RecentlyVisitedSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RecentlyVisitedSites";
            this.Text = "RecentlyVisitedSites";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel lblPoorlyDrawnLines;
        private System.Windows.Forms.LinkLabel lblTrashBird;
        private System.Windows.Forms.LinkLabel lblTheJoyOfSeex;
        private System.Windows.Forms.Label lblDescription;
    }
}

