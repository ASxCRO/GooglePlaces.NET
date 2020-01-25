using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormEditPlace : Form
    {
        public Supan_Places placeToEdit;
        public bool savingSuccessFull = false;
        private const string zarez = ",";
        public FormEditPlace()
        {
            InitializeComponent();

        }


        private void FormEditPlace_Load(object sender, EventArgs e)
        {
            placeNameBox.Text = placeToEdit.PLACE_NAME;
            placeToEdit.PLACE_ADDRESS = Regex.Replace(placeToEdit.PLACE_ADDRESS, @"\t|\n|\r", "");
            string[] adresa = placeToEdit.PLACE_ADDRESS.Split(',');
            ulicaBox.Text = adresa[adresa.Count()-3].TrimStart();
            gradBox.Text = adresa[adresa.Count() - 2].TrimStart();
            drzavaBox.Text = adresa[adresa.Count() - 1].TrimStart();
            placeOpisBox.Text = placeToEdit.PLACE_DESCRIPTION;
        }

        private void buttonUredu_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(placeNameBox.Text) && !String.IsNullOrEmpty(ulicaBox.Text) && !String.IsNullOrEmpty(gradBox.Text) && !String.IsNullOrEmpty(drzavaBox.Text))
            {
                using (var mapDB = new MapEntities())
                {
                    var place = mapDB.Supan_Places.Where(p => p.PLACE_LAT == placeToEdit.PLACE_LAT && p.PLACE_LNG == placeToEdit.PLACE_LNG).FirstOrDefault();
                    place.PLACE_NAME = placeNameBox.Text;
                    place.PLACE_ADDRESS = ulicaBox.Text + zarez + gradBox.Text + zarez + drzavaBox.Text;
                    place.PLACE_DESCRIPTION = placeOpisBox.Text;
                    mapDB.SaveChanges();
                }
                savingSuccessFull = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Molimo unesite vrijednosti naziva/adrese lokacije!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
