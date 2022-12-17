using CSharp_Exam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;


namespace CSharp_Exam
{
    public partial class ListItems : UserControl
    {
        dbContext _dbContext = new dbContext();
        public ListItems()
        {
            InitializeComponent();
        }

        #region Properties
        ImageConverter ImageConverter = new ImageConverter();

        private int _id;
        private string _title;
        private string _description;
        private decimal _cost;
        private Image _icon;

        [Category("Custom props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; lId.Text = value.ToString(); }
        }


        [Category("Custom props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lTitle.Text = value; }
        }

        [Category("Custom props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lDescription.Text = value; }
        }

        [Category("Custom props")]
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; lCost.Text = value.ToString(); }
        }

        [Category("Custom props")]
        public byte[] Icon
        {
            get { return ImageConverter.imageToByteArray(_icon); }
            set { _icon = ImageConverter.byteArrayToImage(value); pbIcon.Image = ImageConverter.byteArrayToImage(value); }
        }


        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {


            using (_dbContext)
            {
                Item deptDelete = _dbContext.Items.Find(Id);
                _dbContext.Items.Remove(deptDelete);
                _dbContext.SaveChanges();
            }

        }
    }
}
