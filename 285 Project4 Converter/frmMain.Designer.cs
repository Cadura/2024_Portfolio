namespace _285_Project4_Converter
{
    partial class frmMain
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
            this.lblEnterDist = new System.Windows.Forms.Label();
            this.txtEnterDist = new System.Windows.Forms.TextBox();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.grpTo = new System.Windows.Forms.GroupBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lblConvtDist = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFrom.SuspendLayout();
            this.grpTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterDist
            // 
            this.lblEnterDist.Location = new System.Drawing.Point(58, 30);
            this.lblEnterDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterDist.Name = "lblEnterDist";
            this.lblEnterDist.Size = new System.Drawing.Size(142, 19);
            this.lblEnterDist.TabIndex = 0;
            this.lblEnterDist.Text = "Enter a distance to convert:";
            // 
            // txtEnterDist
            // 
            this.txtEnterDist.Location = new System.Drawing.Point(205, 28);
            this.txtEnterDist.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterDist.Name = "txtEnterDist";
            this.txtEnterDist.Size = new System.Drawing.Size(116, 20);
            this.txtEnterDist.TabIndex = 1;
            this.txtEnterDist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.lstFrom);
            this.grpFrom.Location = new System.Drawing.Point(32, 61);
            this.grpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Padding = new System.Windows.Forms.Padding(2);
            this.grpFrom.Size = new System.Drawing.Size(150, 74);
            this.grpFrom.TabIndex = 2;
            this.grpFrom.TabStop = false;
            this.grpFrom.Text = "From";
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstFrom.Location = new System.Drawing.Point(23, 17);
            this.lstFrom.Margin = new System.Windows.Forms.Padding(2);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(91, 43);
            this.lstFrom.TabIndex = 0;
            // 
            // grpTo
            // 
            this.grpTo.Controls.Add(this.lstTo);
            this.grpTo.Location = new System.Drawing.Point(196, 61);
            this.grpTo.Margin = new System.Windows.Forms.Padding(2);
            this.grpTo.Name = "grpTo";
            this.grpTo.Padding = new System.Windows.Forms.Padding(2);
            this.grpTo.Size = new System.Drawing.Size(150, 74);
            this.grpTo.TabIndex = 3;
            this.grpTo.TabStop = false;
            this.grpTo.Text = "To";
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstTo.Location = new System.Drawing.Point(26, 17);
            this.lstTo.Margin = new System.Windows.Forms.Padding(2);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(91, 43);
            this.lstTo.TabIndex = 1;
            // 
            // lblConvtDist
            // 
            this.lblConvtDist.AutoSize = true;
            this.lblConvtDist.Location = new System.Drawing.Point(83, 146);
            this.lblConvtDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConvtDist.Name = "lblConvtDist";
            this.lblConvtDist.Size = new System.Drawing.Size(104, 13);
            this.lblConvtDist.TabIndex = 4;
            this.lblConvtDist.Text = "Converted Distance:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(197, 142);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 22);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(104, 191);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(71, 28);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "C&onvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 191);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 244);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblConvtDist);
            this.Controls.Add(this.grpTo);
            this.Controls.Add(this.grpFrom);
            this.Controls.Add(this.txtEnterDist);
            this.Controls.Add(this.lblEnterDist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpFrom.ResumeLayout(false);
            this.grpTo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDist;
        private System.Windows.Forms.TextBox txtEnterDist;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.GroupBox grpTo;
        private System.Windows.Forms.Label lblConvtDist;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
    }
}

