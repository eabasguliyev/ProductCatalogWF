using System;
using System.Drawing;
using System.Windows.Forms;
using _160321Task.Entities;
using _160321Task.Enums;

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
                ProgramTitleLbl.Text = "Edit";
        }
    }
}
