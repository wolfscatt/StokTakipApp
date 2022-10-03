using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListCompanies();
            LoadProducts();
        }

        private void ListCompanies()
        {
            cmbCompany.DataSource = _productService.GetAll();
            cmbCompany.DisplayMember = "Company";
            cmbCompany.ValueMember = "Company";
        }

        private void ListCategories()
        {
            cmbCategory.DataSource = _productService.GetAll();
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "Category";
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    Category = cmbCategory.Text,
                    Name = tbxName.Text,
                    Company = cmbCompany.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    StockAmount = Convert.ToInt32(tbxAmount.Text)
                });
                LoadProducts();
                MessageBox.Show("Ekleme İşlemi Başarılı");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    Category = cmbCategory.Text,
                    Name = tbxName.Text,
                    Company = cmbCompany.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    StockAmount = Convert.ToInt32(tbxAmount.Text)
                });
                LoadProducts();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
                _productService.Delete(new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                });

            LoadProducts();
            MessageBox.Show("Silme İşlemi Başarılı!");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("               İletişim Bilgileri:\n" +
                            "Ad Soyad: Ömer Faruk BİNGÖL\n" +
                            "Telefon No: 0553 697 26 26\n" +
                            "E-Mail: tufar220@gmail.com");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbCategory.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxName.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            cmbCompany.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPrice.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxAmount.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void SearchProducts()
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
                dgwProducts.DataSource = _productService.GetProducts(tbxSearch.Text);
            else
                LoadProducts();
        }
    }
}
