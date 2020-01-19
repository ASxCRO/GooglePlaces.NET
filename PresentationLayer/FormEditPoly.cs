using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormEditPoly : Form
    {
        public Supan_Regions regionToEdit;
        public bool savingSuccessFull = false;
        public FormEditPoly()
        {
            InitializeComponent();
        }

        private void FormEditPoly_Load(object sender, EventArgs e)
        {
            polyNameBox.Text = regionToEdit.NAZIV_REGIJE;
            polyOpisBox.Text = regionToEdit.OPIS_REGIJE;
        }

        private void buttonUredu_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(polyNameBox.Text) && !String.IsNullOrEmpty(polyOpisBox.Text))
            {
                using (var mapDB = new MapEntities())
                {
                    var poly = mapDB.Supan_Regions.Where(r => r.ID == regionToEdit.ID).FirstOrDefault();
                    poly.NAZIV_REGIJE = polyNameBox.Text;
                    poly.OPIS_REGIJE = polyOpisBox.Text;
                    mapDB.SaveChanges();
                }
                savingSuccessFull = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Molimo unesite valjanje vrijednosti naziva/opisa poligona!");
            }

        }

        private void buttonCancelPolyEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
