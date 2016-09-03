namespace Tritech_Glenn_Seplowitz
{
    partial class frmComputeCarColor
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
            this.lblStartPoint = new System.Windows.Forms.Label();
            this.lblRedColor = new System.Windows.Forms.Label();
            this.grpStartingPoint = new System.Windows.Forms.GroupBox();
            this.grpGetCarColor = new System.Windows.Forms.GroupBox();
            this.lblComputedCarColor = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComputeColor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpStartingPoint.SuspendLayout();
            this.grpGetCarColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartPoint
            // 
            this.lblStartPoint.AutoSize = true;
            this.lblStartPoint.Location = new System.Drawing.Point(9, 16);
            this.lblStartPoint.Name = "lblStartPoint";
            this.lblStartPoint.Size = new System.Drawing.Size(289, 13);
            this.lblStartPoint.TabIndex = 0;
            this.lblStartPoint.Text = "Hello, We will assume today is Monday and the car color is: ";
            // 
            // lblRedColor
            // 
            this.lblRedColor.AutoSize = true;
            this.lblRedColor.ForeColor = System.Drawing.Color.Red;
            this.lblRedColor.Location = new System.Drawing.Point(9, 38);
            this.lblRedColor.Name = "lblRedColor";
            this.lblRedColor.Size = new System.Drawing.Size(27, 13);
            this.lblRedColor.TabIndex = 1;
            this.lblRedColor.Text = "Red";
            // 
            // grpStartingPoint
            // 
            this.grpStartingPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStartingPoint.Controls.Add(this.lblStartPoint);
            this.grpStartingPoint.Controls.Add(this.lblRedColor);
            this.grpStartingPoint.Location = new System.Drawing.Point(12, 12);
            this.grpStartingPoint.Name = "grpStartingPoint";
            this.grpStartingPoint.Size = new System.Drawing.Size(649, 71);
            this.grpStartingPoint.TabIndex = 2;
            this.grpStartingPoint.TabStop = false;
            this.grpStartingPoint.Text = "Starting Point";
            // 
            // grpGetCarColor
            // 
            this.grpGetCarColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGetCarColor.Controls.Add(this.lblComputedCarColor);
            this.grpGetCarColor.Controls.Add(this.lblCarColor);
            this.grpGetCarColor.Controls.Add(this.txtDays);
            this.grpGetCarColor.Controls.Add(this.label1);
            this.grpGetCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGetCarColor.Location = new System.Drawing.Point(12, 98);
            this.grpGetCarColor.Name = "grpGetCarColor";
            this.grpGetCarColor.Size = new System.Drawing.Size(649, 108);
            this.grpGetCarColor.TabIndex = 3;
            this.grpGetCarColor.TabStop = false;
            this.grpGetCarColor.Text = "Get the Future Car Color";
            // 
            // lblComputedCarColor
            // 
            this.lblComputedCarColor.AutoSize = true;
            this.lblComputedCarColor.ForeColor = System.Drawing.Color.Black;
            this.lblComputedCarColor.Location = new System.Drawing.Point(9, 83);
            this.lblComputedCarColor.Name = "lblComputedCarColor";
            this.lblComputedCarColor.Size = new System.Drawing.Size(48, 13);
            this.lblComputedCarColor.TabIndex = 4;
            this.lblComputedCarColor.Text = "No Color";
            // 
            // lblCarColor
            // 
            this.lblCarColor.AutoSize = true;
            this.lblCarColor.Location = new System.Drawing.Point(9, 61);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(113, 13);
            this.lblCarColor.TabIndex = 3;
            this.lblCarColor.Text = "The future car color is:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(193, 16);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Days from Monday:";
            // 
            // btnComputeColor
            // 
            this.btnComputeColor.Location = new System.Drawing.Point(205, 229);
            this.btnComputeColor.Name = "btnComputeColor";
            this.btnComputeColor.Size = new System.Drawing.Size(126, 23);
            this.btnComputeColor.TabIndex = 4;
            this.btnComputeColor.Text = "Compute Car Color";
            this.btnComputeColor.UseVisualStyleBackColor = true;
            this.btnComputeColor.Click += new System.EventHandler(this.btnComputeColor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(363, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmComputeCarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 278);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnComputeColor);
            this.Controls.Add(this.grpGetCarColor);
            this.Controls.Add(this.grpStartingPoint);
            this.Name = "frmComputeCarColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compute Car Color";
            this.Load += new System.EventHandler(this.frmComputeCarColor_Load);
            this.grpStartingPoint.ResumeLayout(false);
            this.grpStartingPoint.PerformLayout();
            this.grpGetCarColor.ResumeLayout(false);
            this.grpGetCarColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.Label lblRedColor;
        private System.Windows.Forms.GroupBox grpStartingPoint;
        private System.Windows.Forms.GroupBox grpGetCarColor;
        private System.Windows.Forms.Label lblComputedCarColor;
        private System.Windows.Forms.Label lblCarColor;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComputeColor;
        private System.Windows.Forms.Button btnClose;
    }
}

