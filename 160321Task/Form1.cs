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

        public Panel SelectedProductPanel { get; set; }
        //public static int ProductCont = 0;
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
            SetForm2StartLocation(form2);

            if (form2.ShowDialog() == DialogResult.Cancel)
                return;

            Products.Add(form2.Product);

            var newProductPanel = CreateNewProductPanel(Products.Count - 1);

            FillProductToProductPanel(form2.Product, newProductPanel);

        }

        private Panel CreateNewProductPanel(int productNo)
        {
            var productPanel = new Panel();
            productPanel.BackColor = Color.FromArgb(173, 173, 173);
            productPanel.Location = new Point(0, productNo * 86);
            productPanel.Size = new Size(464, 86);
            productPanel.Name = $"ProductPnl{productNo}";
            productPanel.Tag = productNo;
            productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            productPanel.Click += ProductPnl_Click;

            var selectedPanel = new Panel();
            selectedPanel.BackColor = Color.FromArgb(173, 173, 173);
            selectedPanel.Location = new Point(10, 18);
            selectedPanel.Size = new Size(50, 51);
            selectedPanel.Name = $"SelectedPnl{productNo}";

            productPanel.Controls.Add(selectedPanel);

            var noLbl = new Label();
            noLbl.BackColor = Color.FromArgb(173, 173, 173);
            noLbl.Font = new Font("Microsoft Sans Serif", 12);
            noLbl.Location = new Point(16, 16);
            noLbl.Size = new Size(18, 20);
            noLbl.AutoSize = true;
            noLbl.Name = $"NoLbl{productNo}";

            selectedPanel.Controls.Add(noLbl);

            var productTitleLbl = new Label();
            productTitleLbl.BackColor = Color.FromArgb(173, 173, 173);
            productTitleLbl.Font = new Font("Microsoft Sans Serif", 12);
            productTitleLbl.Location = new Point(73, 9);
            productTitleLbl.Size = new Size(51, 20);
            productTitleLbl.AutoSize = true;
            productTitleLbl.Name = $"ProductTitleLbl{productNo}";
            
            productPanel.Controls.Add(productTitleLbl);

            var productCountryLbl = new Label();
            productCountryLbl.BackColor = Color.FromArgb(173, 173, 173);
            productCountryLbl.Font = new Font("Microsoft Sans Serif", 12);
            productCountryLbl.Location = new Point(73, 34);
            productCountryLbl.AutoSize = true;
            productCountryLbl.Name = $"ProductCountryLbl{productNo}";


            productPanel.Controls.Add(productCountryLbl);

            var productPriceLbl = new Label();
            productPriceLbl.BackColor = Color.FromArgb(173, 173, 173);
            productPriceLbl.Font = new Font("Microsoft Sans Serif", 12);
            productPriceLbl.Location = new Point(73, 58);
            productPriceLbl.AutoSize = true;
            productPriceLbl.Name= $"ProductPriceLbl{productNo}";


            productPanel.Controls.Add(productPriceLbl);

            var productImagePcBx = new PictureBox();

            var newLocation = new Point(0, 11)
            {
                X = ProductsPnl.Height > (Products.Count - 1) * ProductPnl.Height ? 390 : 373
            };


            productImagePcBx.Location = newLocation;
            productImagePcBx.Size = new Size(65, 60);
            productImagePcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            productImagePcBx.BackColor = Color.White;
            productImagePcBx.Name = $"ProductPcBx{productNo}";
            productImagePcBx.Anchor = System.Windows.Forms.AnchorStyles.Right;

            productPanel.Controls.Add(productImagePcBx);
            ProductsPnl.Controls.Add(productPanel);

            return productPanel;
            //MessageBox.Show($"{productImagePcBx.Parent.Tag}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductPnl.Dispose();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.OperationType = OperationType.Edit;
            SetForm2StartLocation(form2);

            var productNo = (int) SelectedProductPanel.Tag;
            var product = Products[productNo];


            form2.Product = product;

            form2.ShowDialog();

            product.UpdateProduct(form2.Product);
            FillProductToProductPanel(product, SelectedProductPanel);
        }

        private Panel GetProductPanel(int tag)
        {
            foreach (Control productPanel in ProductsPnl.Controls)
            {
                if ((int) productPanel.Tag == tag)
                    return (Panel)productPanel;
            }

            throw new InvalidOperationException($"There is no product panel associated this tag -> {tag}");

        }

        private void FillProductToProductPanel(Product product, Panel productPanel)
        {
            var tag = (int) productPanel.Tag;
            productPanel.Controls[$"SelectedPnl{tag}"].Controls[$"NoLbl{tag}"].Text = (tag + 1).ToString();
            productPanel.Controls[$"ProductTitleLbl{tag}"].Text = product.Name;
            productPanel.Controls[$"ProductCountryLbl{tag}"].Text = product.OriginCountry;
            productPanel.Controls[$"ProductPriceLbl{tag}"].Text = $"{product.Price} usd";
        }

        private void ProductPnl_Click(object sender, EventArgs e)
        {
            var newSelectedPanel = sender as Panel;

            if (newSelectedPanel == null)
                return;

            if (SelectedProductPanel != null)
            {
                ChangeColorSelectedPanel(SelectedProductPanel, new Rgb(173, 173, 173), Color.Black);
            }

            ChangeColorSelectedPanel(newSelectedPanel, new Rgb(47, 57, 77), Color.White);
            SelectedProductPanel = newSelectedPanel;
        }

        private void ChangeColorSelectedPanel(Panel panel, Rgb panelColor, Color lblColor)
        {
            var tag = (int)panel.Tag;
            var selectedPnl = panel.Controls[$"SelectedPnl{tag}"] as Panel;
                
            selectedPnl.BackColor = Color.FromArgb(panelColor.Red, panelColor.Green, panelColor.Blue);
            selectedPnl.Controls[$"NoLbl{tag}"].BackColor = Color.FromArgb(panelColor.Red, panelColor.Green, panelColor.Blue);
            selectedPnl.Controls[$"NoLbl{tag}"].ForeColor = lblColor;
        }

        private void UpdateProductNo(Panel productPanel, int panelNo)
        {
            var tag = (int)productPanel.Tag;

            productPanel.Controls[$"SelectedPnl{tag}"].Controls[$"NoLbl{tag}"].Text = panelNo.ToString();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var panelIndex = GetPanelIndex(SelectedProductPanel);
            //var productIndex = panelIndex - 1; // because one panel created before;

            // 1
            // 2
            // 3
            if (panelIndex != ProductsPnl.Controls.Count - 1)
            {
                var currentPanelLocation = SelectedProductPanel.Location;

                for (int i = panelIndex + 1; i < ProductsPnl.Controls.Count; i++)
                {
                    var productPanel = ProductsPnl.Controls[i] as Panel;

                    productPanel.Location = new Point(productPanel.Location.X,
                        currentPanelLocation.Y);

                    UpdateProductNo(productPanel, i);
                    currentPanelLocation.Y += productPanel.Height;
                }
            }

            SelectedProductPanel.Dispose();
            Products.RemoveAt(panelIndex);
            SelectedProductPanel = null;
        }

        private int GetPanelIndex(Panel panel)
        {
            for (int i = 0; i < ProductsPnl.Controls.Count; i++)
            {
                if (ProductsPnl.Controls[i] == panel)
                    return i;
            }

            throw new InvalidOperationException($"There is no panel associated this tag -> {(int)panel.Tag}");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ProductsPnl.Controls.Clear();
            Products.Clear();
            SelectedProductPanel = null;
        }

        private void DefaultButtonStates()
        {
            // to do: disable edit, remove, clear buttons
        }
        private void SetForm2StartLocation(Form form2)
        {
            form2.Location = new Point(this.Location.X + this.Size.Width, 
                this.Location.Y + (this.Size.Height - form2.Size.Height));
        }
    }
}
