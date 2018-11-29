namespace LottoTeamQuiz
{
    partial class FrmShopRankInfo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid_SecondShow = new System.Windows.Forms.DataGridView();
            this.grid_FirestShow = new System.Windows.Forms.DataGridView();
            this.web_Browser = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SecondShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_FirestShow)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grid_SecondShow);
            this.splitContainer1.Panel1.Controls.Add(this.grid_FirestShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.web_Browser);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // grid_SecondShow
            // 
            this.grid_SecondShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SecondShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_SecondShow.Location = new System.Drawing.Point(0, 0);
            this.grid_SecondShow.Name = "grid_SecondShow";
            this.grid_SecondShow.RowTemplate.Height = 23;
            this.grid_SecondShow.Size = new System.Drawing.Size(266, 227);
            this.grid_SecondShow.TabIndex = 1;
            // 
            // grid_FirestShow
            // 
            this.grid_FirestShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_FirestShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_FirestShow.Location = new System.Drawing.Point(0, 0);
            this.grid_FirestShow.Name = "grid_FirestShow";
            this.grid_FirestShow.RowTemplate.Height = 23;
            this.grid_FirestShow.Size = new System.Drawing.Size(266, 450);
            this.grid_FirestShow.TabIndex = 0;
            // 
            // web_Browser
            // 
            this.web_Browser.Location = new System.Drawing.Point(0, 396);
            this.web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Browser.Name = "web_Browser";
            this.web_Browser.Size = new System.Drawing.Size(530, 54);
            this.web_Browser.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(438, 293);
            this.textBox1.TabIndex = 1;
            // 
            // FrmShopRankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmShopRankInfo";
            this.Text = "FrmShopRankInfo";
            this.Load += new System.EventHandler(this.FrmShopRankInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SecondShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_FirestShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grid_FirestShow;
        private System.Windows.Forms.WebBrowser web_Browser;
        private System.Windows.Forms.DataGridView grid_SecondShow;
        private System.Windows.Forms.TextBox textBox1;
    }
}