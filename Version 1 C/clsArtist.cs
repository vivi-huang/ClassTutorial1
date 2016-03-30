using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        private static frmArtist artistDialog = new frmArtist();

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Speciality
        {
            get
            {
                return _Speciality;
            }

            set
            {
                _Speciality = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public decimal TotalValue
        {
            get
            {
                return _TotalValue;
            }

            set
            {
                _TotalValue = value;
            }
        }

        public clsWorksList WorksList
        {
            get
            {
                return _WorksList;
            }

            set
            {
                _WorksList = value;
            }
        }

        public clsArtistList ArtistList
        {
            get
            {
                return _ArtistList;
            }

            set
            {
                _ArtistList = value;
            }
        }

        //private byte _SortOrder;

        public clsArtist(clsArtistList prArtistList)
        {
            WorksList = new clsWorksList();
            ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(Name, Speciality, Phone, WorksList, ArtistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref _Name, ref _Speciality, ref _Phone);
                TotalValue = WorksList.GetTotalValue();
            }
        }

        //public string GetKey()
        //{
        //    return Name;
        //}

        //public decimal GetWorksValue()
        //{
        //    return TotalValue;
        //}
    }
}
