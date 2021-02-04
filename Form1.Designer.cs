
namespace Music2021
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
            this.DGVOwner = new System.Windows.Forms.DataGridView();
            this.lblOwner = new System.Windows.Forms.Label();
            this.DGVCdTracks = new System.Windows.Forms.DataGridView();
            this.DGVCd = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCdTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCd)).BeginInit();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVOwner
            // 
            this.DGVOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOwner.Location = new System.Drawing.Point(66, 55);
            this.DGVOwner.Name = "DGVOwner";
            this.DGVOwner.Size = new System.Drawing.Size(505, 150);
            this.DGVOwner.TabIndex = 0;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = System.Drawing.Color.Lime;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(62, 32);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(60, 20);
            this.lblOwner.TabIndex = 1;
            this.lblOwner.Text = "Owner";
            // 
            // DGVCdTracks
            // 
            this.DGVCdTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCdTracks.Location = new System.Drawing.Point(82, 52);
            this.DGVCdTracks.Name = "DGVCdTracks";
            this.DGVCdTracks.Size = new System.Drawing.Size(414, 150);
            this.DGVCdTracks.TabIndex = 2;
            // 
            // DGVCd
            // 
            this.DGVCd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCd.Location = new System.Drawing.Point(89, 73);
            this.DGVCd.Name = "DGVCd";
            this.DGVCd.Size = new System.Drawing.Size(498, 150);
            this.DGVCd.TabIndex = 3;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(686, 268);
            this.Menu.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVOwner);
            this.tabPage1.Controls.Add(this.lblOwner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Owner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVCdTracks);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(678, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CDTracks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCdTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCd)).EndInit();
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.DataGridView DGVCdTracks;
        private System.Windows.Forms.DataGridView DGVCd;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

