using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormSavePlace : Form
    {
        public Supan_Places place;
        public bool savingSuccessfull = false;
        public FormSavePlace()
        {
            InitializeComponent();
            place = new Supan_Places();
        }

        private void buttonUredu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var mapDB = new MapEntities())
                {
                    var placeAlreadyInDataBase = mapDB.Supan_Places.Where(p => p.PLACE_NAME == place.PLACE_NAME && p.PLACE_ADDRESS == place.PLACE_ADDRESS).FirstOrDefault();
                    if(placeAlreadyInDataBase != null)
                    {
                        MessageBox.Show("Ta lokacija već je zapisana u bazi! Provjerite spremljene lokacije.");
                    }
                    else
                    {
                        mapDB.Supan_Places.Add(place);
                        mapDB.SaveChanges();
                        MessageBox.Show("Uspješno ste spremili lokaciju. Spremljena lokacija nalazi se pod opcijom 'Spremljene lokacije'.");
                        savingSuccessfull = true;
                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            this.Hide();
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
