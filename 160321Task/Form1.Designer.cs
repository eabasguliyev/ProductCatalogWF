
namespace _160321Task
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
            this.ProductPnl = new System.Windows.Forms.Panel();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductCountryLbl = new System.Windows.Forms.Label();
            this.ProductTitleLbl = new System.Windows.Forms.Label();
            this.SelectedPnl = new System.Windows.Forms.Panel();
            this.NoLbl = new System.Windows.Forms.Label();
            this.ListControlPnl = new System.Windows.Forms.Panel();
            this.DraggablePnl = new System.Windows.Forms.Panel();
            this.ProgramTitleLbl = new System.Windows.Forms.Label();
            this.ProductsPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ProductPcBx = new System.Windows.Forms.PictureBox();
            this.ProductPnl.SuspendLayout();
            this.SelectedPnl.SuspendLayout();
            this.ListControlPnl.SuspendLayout();
            this.DraggablePnl.SuspendLayout();
            this.ProductsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPcBx)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPnl
            // 
            this.ProductPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.ProductPnl.Controls.Add(this.ProductPriceLbl);
            this.ProductPnl.Controls.Add(this.ProductCountryLbl);
            this.ProductPnl.Controls.Add(this.ProductTitleLbl);
            this.ProductPnl.Controls.Add(this.ProductPcBx);
            this.ProductPnl.Controls.Add(this.SelectedPnl);
            this.ProductPnl.Location = new System.Drawing.Point(0, 1);
            this.ProductPnl.Name = "ProductPnl";
            this.ProductPnl.Size = new System.Drawing.Size(727, 106);
            this.ProductPnl.TabIndex = 0;
            this.ProductPnl.Visible = false;
            this.ProductPnl.Click += new System.EventHandler(this.ProductPnl_Click);
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductPriceLbl.Location = new System.Drawing.Point(97, 72);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(56, 25);
            this.ProductPriceLbl.TabIndex = 4;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ProductCountryLbl
            // 
            this.ProductCountryLbl.AutoSize = true;
            this.ProductCountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCountryLbl.Location = new System.Drawing.Point(97, 42);
            this.ProductCountryLbl.Name = "ProductCountryLbl";
            this.ProductCountryLbl.Size = new System.Drawing.Size(81, 25);
            this.ProductCountryLbl.TabIndex = 3;
            this.ProductCountryLbl.Text = "Country";
            // 
            // ProductTitleLbl
            // 
            this.ProductTitleLbl.AutoSize = true;
            this.ProductTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductTitleLbl.Location = new System.Drawing.Point(97, 11);
            this.ProductTitleLbl.Name = "ProductTitleLbl";
            this.ProductTitleLbl.Size = new System.Drawing.Size(64, 25);
            this.ProductTitleLbl.TabIndex = 2;
            this.ProductTitleLbl.Text = "Name";
            // 
            // SelectedPnl
            // 
            this.SelectedPnl.Controls.Add(this.NoLbl);
            this.SelectedPnl.Location = new System.Drawing.Point(13, 22);
            this.SelectedPnl.Name = "SelectedPnl";
            this.SelectedPnl.Size = new System.Drawing.Size(67, 63);
            this.SelectedPnl.TabIndex = 2;
            // 
            // NoLbl
            // 
            this.NoLbl.AutoSize = true;
            this.NoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoLbl.Location = new System.Drawing.Point(22, 20);
            this.NoLbl.Name = "NoLbl";
            this.NoLbl.Size = new System.Drawing.Size(23, 25);
            this.NoLbl.TabIndex = 0;
            this.NoLbl.Text = "1";
            // 
            // ListControlPnl
            // 
            this.ListControlPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListControlPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ListControlPnl.Controls.Add(this.ClearBtn);
            this.ListControlPnl.Controls.Add(this.RemoveBtn);
            this.ListControlPnl.Controls.Add(this.EditBtn);
            this.ListControlPnl.Controls.Add(this.AddBtn);
            this.ListControlPnl.Location = new System.Drawing.Point(725, 46);
            this.ListControlPnl.Name = "ListControlPnl";
            this.ListControlPnl.Size = new System.Drawing.Size(75, 508);
            this.ListControlPnl.TabIndex = 1;
            this.ListControlPnl.MouseEnter += new System.EventHandler(this.ListControlPnl_MouseEnter);
            this.ListControlPnl.MouseLeave += new System.EventHandler(this.ListControlPnl_MouseLeave);
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
            this.DraggablePnl.Size = new System.Drawing.Size(800, 46);
            this.DraggablePnl.TabIndex = 1;
            this.DraggablePnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseDown);
            this.DraggablePnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseMove);
            this.DraggablePnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggablePnl_MouseUp);
            // 
            // ProgramTitleLbl
            // 
            this.ProgramTitleLbl.AutoSize = true;
            this.ProgramTitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramTitleLbl.ForeColor = System.Drawing.Color.White;
            this.ProgramTitleLbl.Location = new System.Drawing.Point(21, 8);
            this.ProgramTitleLbl.Name = "ProgramTitleLbl";
            this.ProgramTitleLbl.Size = new System.Drawing.Size(84, 28);
            this.ProgramTitleLbl.TabIndex = 2;
            this.ProgramTitleLbl.Text = "Catalog";
            // 
            // ProductsPnl
            // 
            this.ProductsPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsPnl.AutoScroll = true;
            this.ProductsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.ProductsPnl.Controls.Add(this.ProductPnl);
            this.ProductsPnl.Location = new System.Drawing.Point(-1, 45);
            this.ProductsPnl.Name = "ProductsPnl";
            this.ProductsPnl.Size = new System.Drawing.Size(727, 509);
            this.ProductsPnl.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::_160321Task.Properties.Resources.close_window;
            this.pictureBox1.Location = new System.Drawing.Point(739, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Image = global::_160321Task.Properties.Resources.clear_symbol_24px;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(14, 321);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(49, 54);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.Image = global::_160321Task.Properties.Resources.remove_24px;
            this.RemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.Location = new System.Drawing.Point(14, 252);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(49, 54);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = global::_160321Task.Properties.Resources.edit_24px;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.Location = new System.Drawing.Point(14, 183);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(49, 54);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::_160321Task.Properties.Resources.add_new_26px;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(14, 115);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(49, 54);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProductPcBx
            // 
            this.ProductPcBx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProductPcBx.BackColor = System.Drawing.Color.White;
            this.ProductPcBx.Location = new System.Drawing.Point(629, 13);
            this.ProductPcBx.Name = "ProductPcBx";
            this.ProductPcBx.Size = new System.Drawing.Size(87, 74);
            this.ProductPcBx.TabIndex = 1;
            this.ProductPcBx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.DraggablePnl);
            this.Controls.Add(this.ListControlPnl);
            this.Controls.Add(this.ProductsPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProductPnl.ResumeLayout(false);
            this.ProductPnl.PerformLayout();
            this.SelectedPnl.ResumeLayout(false);
            this.SelectedPnl.PerformLayout();
            this.ListControlPnl.ResumeLayout(false);
            this.DraggablePnl.ResumeLayout(false);
            this.DraggablePnl.PerformLayout();
            this.ProductsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPcBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductPnl;
        private System.Windows.Forms.Panel ListControlPnl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel DraggablePnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProgramTitleLbl;
        private System.Windows.Forms.PictureBox ProductPcBx;
        private System.Windows.Forms.Label NoLbl;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Label ProductCountryLbl;
        private System.Windows.Forms.Label ProductTitleLbl;
        private System.Windows.Forms.Panel SelectedPnl;
        private System.Windows.Forms.Panel ProductsPnl;
    }
}

