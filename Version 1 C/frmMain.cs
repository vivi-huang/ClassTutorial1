using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Matthias Otto, NMIT, 2010-2016
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        clsArtistList _ArtistList;
        private clsArtistList theArtistList = new clsArtistList();
       // private const string _fileName = "gallery.xml";

        private void UpdateDisplay()
        {
            string[] lcDisplayList = new string[theArtistList.Count];

            lstArtists.DataSource = null;
            theArtistList.Keys.CopyTo(lcDisplayList, 0);
            lstArtists.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(theArtistList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            theArtistList.NewArtist();
            UpdateDisplay();
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                theArtistList.EditArtist(lcKey);
                UpdateDisplay();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _ArtistList.Save();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                lstArtists.ClearSelected();
                theArtistList.Remove(lcKey);
                UpdateDisplay();
            }
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            _ArtistList.Retrieve();
            UpdateDisplay();
        }
    }
}