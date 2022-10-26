using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.IO;

namespace RentalApp
{
    public partial class ucProperties : UserControl
    {
        public ucProperties()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();
        string location;

        private void ucProperties_Load(object sender, EventArgs e)
        {
            cmbPropertyTypeID.DataSource = bll.PropertyTypeGET();
            cmbPropertyTypeID.DisplayMember = "PropertyTypeDescription";
            cmbPropertyTypeID.ValueMember = "PropertyTypeID";

            cmbSuburbID.DataSource = bll.SurbubGet();
            cmbSuburbID.DisplayMember = "SurbubDescription";
            cmbSuburbID.ValueMember = "SurbubID";

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if (string.IsNullOrEmpty(txtPropDesc.Text))
            {
                errorProperties.SetError(txtPropDesc, "Please enter description");
            }
            else
            {
                validate = true;
                errorProperties.Clear();
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProperties.SetError(txtPrice, "Please enter price");
            }
            else
            {
                validate = true;
                errorProperties.Clear();
            }
            if (string.IsNullOrEmpty(cmbPropertyTypeID.Text))
            {
                errorProperties.SetError(cmbPropertyTypeID, "Please select property type");
            }
            else
            {
                validate = true;
                errorProperties.Clear();
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProperties.SetError(cmbStatus, "Please select status");
            }
            else
            {
                validate = true;
                errorProperties.Clear();
            }
            if (string.IsNullOrEmpty(cmbSuburbID.Text))
            {
                errorProperties.SetError(cmbSuburbID, "Please select suburb");
            }
            else
            {
                validate = true;
                errorProperties.Clear();
            }
            if (validate)
            {
                Property prop = new Property();
                prop.Description = txtPropDesc.Text;
                prop.Price = int.Parse(txtPrice.Text);
                Image img = pictureBox1.Image;
                byte[] picArr;
                ImageConverter converter = new ImageConverter();
                picArr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                prop.PropertyTypeID = int.Parse(cmbPropertyTypeID.SelectedValue.ToString());
                prop.Status = (cmbStatus.Text);
                prop.SurbubID = int.Parse(cmbSuburbID.SelectedValue.ToString());
                prop.Image = picArr;


                int x = bll.PropertyInsert(prop);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added");
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                location = ofd.FileName.ToString();
                pictureBox1.ImageLocation = location;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.PropertyGET();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Property prop = new Property();
            prop.PropertyID = int.Parse(txtPropertyID.Text);
            prop.Price = int.Parse(txtPrice.Text);
            prop.Status = cmbStatus.Text;
            prop.PropertyTypeID = int.Parse(cmbPropertyTypeID.SelectedValue.ToString());

            int x = bll.PropertyUpdate(prop);
            if(x > 0)
            {
                MessageBox.Show(x + " Updated");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Property prop = new Property();
            prop.PropertyID = int.Parse(txtPropertyID.Text);

            int x = bll.PropertyDelete(prop);
            if(x > 0)
            {
                MessageBox.Show(x + " Deleted");
            }
        }

        private void dgvProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void dgvProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dgvProperty.DataSource as DataTable;
            if(dgvProperty.Rows.Count > 0)
            {
                DataRow row = dt.Rows[e.RowIndex];
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtPropDesc.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                byte[] picData = (byte[])dgvProperty.CurrentRow.Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(picData);
                pictureBox1.Image = Image.FromStream(ms);
                cmbPropertyTypeID.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSuburbID.Text = dgvProperty.SelectedRows[0].Cells["SurbubID"].Value.ToString();
            }
        }

       
    }
}
