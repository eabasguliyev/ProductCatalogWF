using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using _160321Task.Entities;
using _160321Task.Enums;
using _160321Task.Helpers;

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

            FileHelper.FileName = "Products.json";

            if (File.Exists(FileHelper.FileName))
            {
                Products = FileHelper.ReadFromJson();


                if(Products != null)
                {
                    for (int i = 0; i < Products.Count; i++)
                    {
                        var productPanel = CreateNewProductPanel(i);

                        FillProductToProductPanel(Products[i], productPanel);
                    }
                }
                else
                { 
                    Products = new List<Product>();
                }
            }
            else
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

            FileHelper.WriteToJson(Products);
            
            if (!ClearBtn.Enabled)
                ClearBtn.Enabled = true;
        }

        private Panel CreateNewProductPanel(int productNo)
        {
            var productPanel = new Panel();
            productPanel.BackColor = Color.FromArgb(173, 173, 173);
            productPanel.Location = new Point(0, productNo * 86);
            productPanel.Size = new Size(464, 86);
            productPanel.Name = $"ProductPnl{productNo}";
            productPanel.Tag = productNo;
            productPanel.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
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
            productPriceLbl.Name = $"ProductPriceLbl{productNo}";


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
            ClearButtonTexts();

            DisableButtonsUseability();

            ClearBtn.Enabled = (Products.Count != 0);
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
            FileHelper.WriteToJson(Products);
        }

        private Panel GetProductPanel(int tag)
        {
            foreach (Control productPanel in ProductsPnl.Controls)
            {
                if ((int) productPanel.Tag == tag)
                    return (Panel) productPanel;
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

            if (product.ImageBitmap != null)
            {
                var image = productPanel.Controls[$"ProductPcBx{tag}"] as PictureBox;

                image.Image = (Image)product.ImageBitmap;
            }
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
            EnableButtonsUseability();
        }

        private void ChangeColorSelectedPanel(Panel panel, Rgb panelColor, Color lblColor)
        {
            var tag = (int) panel.Tag;
            var selectedPnl = panel.Controls[$"SelectedPnl{tag}"] as Panel;

            selectedPnl.BackColor = Color.FromArgb(panelColor.Red, panelColor.Green, panelColor.Blue);
            selectedPnl.Controls[$"NoLbl{tag}"].BackColor =
                Color.FromArgb(panelColor.Red, panelColor.Green, panelColor.Blue);
            selectedPnl.Controls[$"NoLbl{tag}"].ForeColor = lblColor;
        }

        private void UpdateProductNo(Panel productPanel, int panelNo)
        {
            var tag = (int) productPanel.Tag;

            productPanel.Controls[$"SelectedPnl{tag}"].Controls[$"NoLbl{tag}"].Text = panelNo.ToString();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var panelIndex = GetPanelIndex(SelectedProductPanel);

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
            DisableButtonsUseability();
            FileHelper.WriteToJson(Products);

            if (Products.Count == 0)
                ClearBtn.Enabled = false;
        }

        private int GetPanelIndex(Panel panel)
        {
            for (int i = 0; i < ProductsPnl.Controls.Count; i++)
            {
                if (ProductsPnl.Controls[i] == panel)
                    return i;
            }

            throw new InvalidOperationException($"There is no panel associated this tag -> {(int) panel.Tag}");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ProductsPnl.Controls.Clear();
            Products.Clear();
            SelectedProductPanel = null;
            DisableButtonsUseability();
            ClearBtn.Enabled = !ClearBtn.Enabled;
            FileHelper.WriteToJson(Products);
        }

        private void DisableButtonsUseability()
        {
            EditBtn.Enabled = false;
            RemoveBtn.Enabled = false;
            //ClearBtn.Enabled = false;
        }
        private void EnableButtonsUseability()
        {
            EditBtn.Enabled = true;
            RemoveBtn.Enabled = true;
            //ClearBtn.Enabled = false;
        }

        private void SetForm2StartLocation(Form form2)
        {
            form2.Location = new Point(this.Location.X + this.Size.Width,
                this.Location.Y + (this.Size.Height - form2.Size.Height));
        }

        private void ChangeListControlView(int x, int width)
        {
            var newLocation = ListControlPnl.Location;
            var newSize = ListControlPnl.Size;

            newLocation.X = x;
            newSize.Width = width;

            ListControlPnl.Location = newLocation;
            ListControlPnl.Size = newSize;
        }

        private void ChangeProductsListView(int width)
        {
            var newSize = ProductsPnl.Size;

            newSize.Width = width;

            ProductsPnl.Size = newSize;
        }
        private void ClearButtonTexts()
        {
            AddBtn.Text = string.Empty;
            EditBtn.Text = string.Empty;
            RemoveBtn.Text = string.Empty;
            ClearBtn.Text = string.Empty;
        }

        private void SetButtonTexts()
        {
            AddBtn.Text = "Add";
            EditBtn.Text = "Edit";
            RemoveBtn.Text = "Remove";
            ClearBtn.Text = "Clear";
        }

        private void ListControlPnl_MouseEnter(object sender, EventArgs e)
        {
            ChangeListControlView(462, 138);
            ChangeProductsListView(463);
            SetButtonTexts();
        }

        private void ListControlPnl_MouseLeave(object sender, EventArgs e)
        {
            var mousePosition = GetMousePosition();

            if (mousePosition.X >= ListControlPnl.Location.X &&
                mousePosition.X <= ListControlPnl.Location.X + ListControlPnl.Width &&
                mousePosition.Y >= ListControlPnl.Location.Y &&
                mousePosition.Y <= ListControlPnl.Location.Y + ListControlPnl.Height)
                return;

            ChangeListControlView(544, 56);
            ChangeProductsListView(545);
            ClearButtonTexts();
        }

        private Point GetMousePosition()
        {
            return new Point()
            {
                X = Control.MousePosition.X - this.Location.X - 8,
                Y = Control.MousePosition.Y - this.Location.Y - 30,
            };
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.red_close_window;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.close_window;
        }
    }
}
