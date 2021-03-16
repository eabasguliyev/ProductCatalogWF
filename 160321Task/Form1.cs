using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _160321Task.Entities;
using _160321Task.Enums;

namespace _160321Task
{
    public partial class Form1 : Form
    {
        public List<Product> Products { get; set; }
        public Form1()
        {
            InitializeComponent();
            Products = new List<Product>();
        }

        private void DraggablePnl_MouseDown(object sender, MouseEventArgs e)
        {
            DraggableForm.MouseDown(Cursor.Position, this.Location);
        }

        private void DraggablePnl_MouseMove(object sender, MouseEventArgs e)
        {
            var newLocation = DraggableForm.MouseMove();

            if (newLocation != Point.Empty)
                this.Location = newLocation;
        }

        private void DraggablePnl_MouseUp(object sender, MouseEventArgs e)
        {
            DraggableForm.MouseUp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.OperationType = OperationType.Add;

            Products.Add(form2.Product);

            form2.ShowDialog();
        }

        private void CreateNewProductPanel(int productNo)
        {
            var productPanel = new Panel();
            productPanel.BackColor = Color.FromArgb(173, 173, 173);
            productPanel.Location = new Point(0, productNo * 86);
            productPanel.Size = new Size(464, 86);
            productPanel.Name = $"ProductPanel{productNo}";

            var selectedPanel = new Panel();
            selectedPanel.BackColor = Color.FromArgb(173, 173, 173);
            selectedPanel.Location = new Point(10, 18);
            selectedPanel.Size = new Size(50, 51);
            selectedPanel.Name = $"SelectedPanel{productNo}";

            productPanel.Controls.Add(selectedPanel);

            var noLbl = new Label();
            noLbl.BackColor = Color.FromArgb(173, 173, 173);
            noLbl.Font = new Font("Microsoft Sans Serif", 12);
            noLbl.Location = new Point(16, 16);
            noLbl.Size = new Size(18, 20);
            noLbl.AutoSize = true;
            noLbl.Text = (productNo + 1).ToString(); // bunu sileceksen
            noLbl.Name = $"NoLbl{productNo}";

            selectedPanel.Controls.Add(noLbl);

            var productTitleLbl = new Label();
            productTitleLbl.BackColor = Color.FromArgb(173, 173, 173);
            productTitleLbl.Font = new Font("Microsoft Sans Serif", 12);
            productTitleLbl.Location = new Point(73, 9);
            productTitleLbl.Size = new Size(51, 20);
            productTitleLbl.AutoSize = true;
            productTitleLbl.Text = "Iphone"; // bunu sileceksen

            productPanel.Controls.Add(productTitleLbl);

            var productCountryLbl = new Label();
            productCountryLbl.BackColor = Color.FromArgb(173, 173, 173);
            productCountryLbl.Font = new Font("Microsoft Sans Serif", 12);
            productCountryLbl.Location = new Point(73, 34);
            productCountryLbl.AutoSize = true;
            productCountryLbl.Text = "USA"; // bunu sileceksen

            productPanel.Controls.Add(productCountryLbl);

            var productPriceLbl = new Label();
            productPriceLbl.BackColor = Color.FromArgb(173, 173, 173);
            productPriceLbl.Font = new Font("Microsoft Sans Serif", 12);
            productPriceLbl.Location = new Point(73, 58);
            productPriceLbl.AutoSize = true;
            productPriceLbl.Text = "3$"; // bunu sileceksen

            productPanel.Controls.Add(productPriceLbl);

            var productImagePcBx = new PictureBox();
            
            productImagePcBx.Location = new Point(390, 11);
            productImagePcBx.Size = new Size(65, 60);
            productImagePcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            productImagePcBx.BackColor = Color.White;

            productPanel.Controls.Add(productImagePcBx);
            ProductsPnl.Controls.Add(productPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNewProductPanel(0);
            CreateNewProductPanel(1);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.OperationType = OperationType.Edit;

            form2.ShowDialog();
        }

        private void FillProductToProductPanel(Product product, Panel productPanel)
        {

        }
    }
}
