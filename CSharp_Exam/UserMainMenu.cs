using CSharp_Exam.Entities;
using CSharp_Exam.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace CSharp_Exam
{

    public partial class UserMainMenu : Form
    {
        string photopath;
        byte[] binaryphoto;

        int sortOption = 1;
        int sortOrder = 1;

        private dbContext _dbContext = new dbContext();
        ImageConverter imageConverter = new ImageConverter();

        List<ListItems> listItems = new List<ListItems>();

        public UserMainMenu()
        {
            InitializeComponent();

            //BackColor = Color.FromArgb(4);
        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            populateItems(sortOption, sortOrder);

            var sortOptions = new List<string>
            {
                "Id",
                "Title",
                "Description",
                "Cost"
            };
            scSortOptions.DataSource = sortOptions;
        }

        public void populateItems(int sortOption, int sortOrder)
        {
            var items = _dbContext.Items.Select(x => new ListItems
            {
                Id = x.Id,
                Icon = x.Icon,
                Title = x.Title,
                Description = x.Description,
                Cost = x.Cost,

            }).ToList();

            var sortedItems = items.OrderBy(x => x.Title);

            switch(sortOption)
            {
                case 1: sortedItems = items.OrderBy(x => x.Id); break;
                case 2: sortedItems = items.OrderBy(x => x.Title); break;
                case 3: sortedItems = items.OrderBy(x => x.Description); break;
                case 4: sortedItems = items.OrderBy(x => x.Cost); break;
            }

            var newSortedItems = sortedItems.Reverse();

            if (sortOrder == 1)
                newSortedItems = sortedItems;

            flpItemsList.Controls.Clear();
            
            foreach (var item in newSortedItems)
            {
                flpItemsList.Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpegs|*.Jpegs|png|*.png|Gif|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps";
            file.Title = "Select an image";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbSetPic.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }

        private void bAddNewItem_Click(object sender, EventArgs e)
        {

            _dbContext.Items.Add(new Item
            {
                Icon = imageConverter.imageToByteArray(pbSetPic.Image),
                Title = tbTitle.Text,
                Description = tbDescription.Text,
                Cost = Convert.ToDecimal(tbCost.Text),
            });
            _dbContext.SaveChanges();
            populateItems(sortOption, sortOrder);
            flpItemsList.Refresh();
        }

        private void UserMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.Refresh();
        }

        private void btnRefreshItemsList_Click(object sender, EventArgs e)
        {
            populateItems(sortOption, sortOrder);
            flpItemsList.Refresh();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            

            int idToDelete = Convert.ToInt32(tbIdToDelete.Text);
            var user = _dbContext.Items.FirstOrDefault(x => x.Id == idToDelete);

            if (user != null)
            {
                MessageBoxResult confirmResult = MessageBox.Show(
                    "Are you sure to delete this item ??",
                    "Confirm Delete!!",
                    MessageBoxButton.YesNo);

                if (confirmResult == MessageBoxResult.Yes)
                {

                    Item itemDelete = _dbContext.Items.Find(idToDelete);
                    _dbContext.Items.Remove(itemDelete);
                    _dbContext.SaveChanges();

                }
                populateItems(sortOption, sortOrder);
                flpItemsList.Refresh();
            }
            else
            {
                MessageBox.Show("Item with such id does not exist");
            }
        }

        private void cbTitle_CheckedChanged(object sender, EventArgs e)
        {
            tbNewTitle.Enabled = cbTitle.Checked ? true : false;
            if(!cbTitle.Checked || !cbCost.Checked || !cbDescription.Checked || !cbPicture.Checked)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void cbCost_CheckedChanged(object sender, EventArgs e)
        {
            tbNewCost.Enabled = cbCost.Checked ? true : false;
            if (!cbTitle.Checked || !cbCost.Checked || !cbDescription.Checked || !cbPicture.Checked)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void cbDescription_CheckedChanged(object sender, EventArgs e)
        {
            tbNewDescription.Enabled = cbDescription.Checked ? true : false;
            if (!cbTitle.Checked || !cbCost.Checked || !cbDescription.Checked || !cbPicture.Checked)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void cbPicture_CheckedChanged(object sender, EventArgs e)
        {
            btnSetNewPicture.Enabled = cbPicture.Checked ? true : false;
            if (cbPicture.Checked)
            {
                btnUpdate.Enabled = true;
            }
            if (!cbTitle.Checked || !cbCost.Checked || !cbDescription.Checked || !cbPicture.Checked)
            {
                btnUpdate.Enabled = false;
            }
        }

        private void tbNewTitle_TextChanged(object sender, EventArgs e)
        {
            if (cbTitle.Checked && lWrongIdToUpdate.Text == "OK!")
            {
                btnUpdate.Enabled = (tbNewTitle.Text == "" ? false : true);
            }
        }
        private void tbNewCost_ValueChanged(object sender, EventArgs e)
        {
            if (cbCost.Checked && lWrongIdToUpdate.Text == "OK!")
            {
                btnUpdate.Enabled = (tbNewCost.Text == "" ? false : true);
            }
        }

        private void tbNewDescription_TextChanged(object sender, EventArgs e)
        {
            if (cbDescription.Checked && lWrongIdToUpdate.Text == "OK!")
            {
                btnUpdate.Enabled = (tbNewDescription.Text == "" ? false : true);
            }
        }

        private void tbIdToUpdate_TextChanged(object sender, EventArgs e)
        {
            if (tbIdToUpdate.Text == "")
            {
                btnUpdate.Enabled = false;
                lWrongIdToUpdate.Text = "";
            }
            else
            {
                int idToUpdate = Convert.ToInt32(tbIdToUpdate.Text);
                var user = _dbContext.Items.FirstOrDefault(x => x.Id == idToUpdate);

                if (user == null)
                {
                    lWrongIdToUpdate.Text = "Item don't exist";
                    lWrongIdToUpdate.ForeColor = Color.Red;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lWrongIdToUpdate.Text = "OK!";
                    lWrongIdToUpdate.ForeColor = Color.Green;

                    if(cbTitle.Checked || cbCost.Checked || cbDescription.Checked || cbPicture.Checked)
                    {
                        btnUpdate.Enabled = true;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbIdToUpdate.Text);
            var item = _dbContext.Items.FirstOrDefault(x => x.Id == id);

            if (cbTitle.Checked)
            {
                item.Title = tbNewTitle.Text;
            }

            if (cbDescription.Checked)
            {
                item.Description = tbNewDescription.Text;
            }

            if (cbCost.Checked)
            {
                item.Cost = Convert.ToDecimal(tbNewCost.Text);
            }

            if (cbPicture.Checked)
            {
                item.Icon = imageConverter.imageToByteArray(pbSetNewPic.Image);
            }

            _dbContext.SaveChanges();
            populateItems(sortOption, sortOrder);
            flpItemsList.Refresh();
        }

        private void btnSetNewPicture_Click(object sender, EventArgs e)
        {
            if (lWrongIdToUpdate.Text == "OK!")
            {
                btnUpdate.Enabled = true;
            }

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpegs|*.Jpegs|png|*.png|Gif|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps";
            file.Title = "Select an image";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbSetNewPic.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }

        private void tbIdToDelete_Click(object sender, EventArgs e)
        {
            tbIdToUpdate.Text = "";
        }

        private void tbIdToUpdate_Click(object sender, EventArgs e)
        {
            tbIdToDelete.Text = "";
        }

        private void cbAscDesc_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAscDesc.Checked)
            {
                cbAscDesc.Text = "Desc";
                sortOrder = 2;
            }
            else
            {
                cbAscDesc.Text = "Asc";
                sortOrder = 1;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch(scSortOptions.SelectedValue)
            {
                case "Id": sortOption = 1; break;
                case "Title": sortOption = 2; break;
                case "Description": sortOption = 3; break;
                case "Cost": sortOption = 4; break;
            }

            populateItems(sortOption, sortOrder);
        }
    }
}
