using System;
using System.Drawing;
using System.Windows.Forms;
using _160321Task.Entities;
using _160321Task.Enums;
using _160321Task.Helpers;

namespace _160321Task
{
    public partial class Form2 : Form
    {
        public Product Product { get; set; }
        public OperationType OperationType { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputs())
                return;

            Product = new Product();

            Product.Name = ProductNameTxtBx.Text;
            Product.OriginCountry = OriginCountryTxtBx.Text;
            Product.Price = Convert.ToDouble(ProductPriceTxtBx.Text);

            if (!string.IsNullOrWhiteSpace(ImagePathTxtBx.Text))
            {
                Product.Image = Image.FromFile(ImagePathTxtBx.Text);
                Product.ImageBytes = ImageHelper.ConvertImageToBytes(Product.Image);
            }


            this.DialogResult = DialogResult.OK;
        }

        private bool CheckUserInputs()
        {
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (OperationType == OperationType.Add)
                ProgramTitleLbl.Text = "Add";
            else if (OperationType == OperationType.Edit)
            {
                ProgramTitleLbl.Text = "Edit";

                if (Product != null)
                {
                    LoadProductToForm(Product);
                }
            }
        }

        public void RemoveText(TextBox textBox, string text)
        {
            if (textBox.Text == "text")
            {
                textBox.Text = "";
            }
        }

        public void AddText(TextBox textBox, string text)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                textBox.Text = text;
        }

        private void LoadProductToForm(Product product)
        {
            ProductNameTxtBx.Text = product.Name;
            OriginCountryTxtBx.Text = product.OriginCountry;
            ProductPriceTxtBx.Text = product.Price.ToString();
        }

        private void ImagePathTxtBx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Select Product Image",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + 
                         "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePathTxtBx.Text = openFileDialog1.FileName;
            }
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
