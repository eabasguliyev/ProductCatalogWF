
namespace _160321Task
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
            this.ProgramTitleLbl = new System.Windows.Forms.Label();
            this.DraggablePnl = new System.Windows.Forms.Panel();
            this.ProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginCountryTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DraggablePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgramTitleLbl
            // 
            this.ProgramTitleLbl.AutoSize = true;
            this.ProgramTitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramTitleLbl.ForeColor = System.Drawing.Color.White;
            this.ProgramTitleLbl.Location = new System.Drawing.Point(21, 8);
            this.ProgramTitleLbl.Name = "ProgramTitleLbl";
            this.ProgramTitleLbl.Size = new System.Drawing.Size(55, 28);
            this.ProgramTitleLbl.TabIndex = 2;
            this.ProgramTitleLbl.Text = "Title";
            // 
            // DraggablePnl
            // 
            this.DraggablePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DraggablePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.DraggablePnl.Controls.Add(this.ProgramTitleLbl);
            this.DraggablePnl.Controls.Add(this.pictureBox1);
            this.DraggablePnl.Location = new System.Drawing.Point(0, 0);
            this.DraggablePnl.Name = "DraggablePnl";
            this.DraggablePnl.Size = new System.Drawing.Size(433, 46);
            this.DraggablePnl.TabIndex = 2;
            this.DraggablePnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseDown);
            this.DraggablePnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseMove);
            this.DraggablePnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseUp);
            // 
            // ProductNameTxtBx
            // 
            this.ProductNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameTxtBx.Location = new System.Drawing.Point(26, 89);
            this.ProductNameTxtBx.MaxLength = 20;
            this.ProductNameTxtBx.Name = "ProductNameTxtBx";
            this.ProductNameTxtBx.Size = new System.Drawing.Size(382, 34);
            this.ProductNameTxtBx.TabIndex = 3;
            this.ProductNameTxtBx.Text = "Iphone";
            this.ProductNameTxtBx.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Origin country:";
            // 
            // OriginCountryTxtBx
            // 
            this.OriginCountryTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OriginCountryTxtBx.Location = new System.Drawing.Point(26, 172);
            this.OriginCountryTxtBx.MaxLength = 20;
            this.OriginCountryTxtBx.Name = "OriginCountryTxtBx";
            this.OriginCountryTxtBx.Size = new System.Drawing.Size(382, 34);
            this.OriginCountryTxtBx.TabIndex = 5;
            this.OriginCountryTxtBx.Text = "USA";
            this.OriginCountryTxtBx.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Price:";
            // 
            // ProductPriceTxtBx
            // 
            this.ProductPriceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductPriceTxtBx.Location = new System.Drawing.Point(25, 254);
            this.ProductPriceTxtBx.MaxLength = 10;
            this.ProductPriceTxtBx.Name = "ProductPriceTxtBx";
            this.ProductPriceTxtBx.Size = new System.Drawing.Size(382, 34);
            this.ProductPriceTxtBx.TabIndex = 7;
            this.ProductPriceTxtBx.Text = "1000";
            this.ProductPriceTxtBx.WordWrap = false;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(27, 307);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(129, 46);
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(268, 307);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(139, 46);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::_160321Task.Properties.Resources.close_window;
            this.pictureBox1.Location = new System.Drawing.Point(381, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(433, 370);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductPriceTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OriginCountryTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameTxtBx);
            this.Controls.Add(this.DraggablePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DraggablePnl.ResumeLayout(false);
            this.DraggablePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramTitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DraggablePnl;
        private System.Windows.Forms.TextBox ProductNameTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OriginCountryTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductPriceTxtBx;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}