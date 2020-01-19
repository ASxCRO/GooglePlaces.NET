using DataAccessLayer;
using GMap.NET.WindowsForms;
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
    public partial class FormSavePolygon : Form
    {
        public GMapPolygon polygon;
        public bool savingSuccessfull = false;
        public Supan_Regions region;
        private Supan_RegionPoints regionPoints;
        public FormSavePolygon(GMapPolygon poly)
        {
            InitializeComponent();
            polygon = poly;
            region = new Supan_Regions();
            //polygon.Points
            regionPoints = new Supan_RegionPoints();
        }

        private void buttonUredu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nazivPoligonaTextBox.Text) || string.IsNullOrWhiteSpace(opisPoligonaTextBox.Text))
            {
                MessageBox.Show("Molimo unesite valjani naziv/opis.");
            }
            else
            {
                try
                {
                    using (var mapDB = new MapEntities())
                    {
                        var polyAlreadyInDataBase = mapDB.Supan_Regions.Where(p => p.NAZIV_REGIJE == nazivPoligonaTextBox.Text && p.OPIS_REGIJE == opisPoligonaTextBox.Text).FirstOrDefault();
                        if (polyAlreadyInDataBase != null)
                        {
                            MessageBox.Show("Ta regija već je zapisana u bazi! Provjerite spremljene poligone.");
                        }
                        else
                        {
                            var regionToSave = new Supan_Regions { NAZIV_REGIJE = nazivPoligonaTextBox.Text, OPIS_REGIJE = opisPoligonaTextBox.Text };
                            mapDB.Supan_Regions.Add(regionToSave);
                            mapDB.SaveChanges();
                            var regionId = mapDB.Supan_Regions.Where(r=>r.NAZIV_REGIJE == regionToSave.NAZIV_REGIJE && r.OPIS_REGIJE == regionToSave.OPIS_REGIJE).Select(r=>r.ID).FirstOrDefault();
                            foreach (var point in polygon.Points)
                            {
                                decimal lat = Convert.ToDecimal(point.Lat);
                                decimal lng = Convert.ToDecimal(point.Lng);
                                lat = decimal.Round(lat, 6, MidpointRounding.AwayFromZero);
                                lng = decimal.Round(lng, 6, MidpointRounding.AwayFromZero);
                                mapDB.Supan_RegionPoints.Add(
                                    new Supan_RegionPoints { ID_REGIJE = regionId, LAT = lat, LNG = lng }); 
                            }
                            try
                            {
                                mapDB.SaveChanges();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Dogodila se pogreška!'.");
                                throw;
                            }
                            MessageBox.Show("Uspješno ste spremili regiju. Spremljeni poligon nalazi se pod opcijom 'Spremljene lokacije / poligoni'.");
                            savingSuccessfull = true;
                            this.Hide();

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
            }
            
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
