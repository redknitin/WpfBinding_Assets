using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedlyHigh
{
    public class AssetEntity : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime CommissionedDate { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan WarrantyPeriod { get; set; }
        public int ParentID { get; set; }

        protected void NotifyChange(string aChange)
        {
            throw new NotImplementedException();
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(aChange));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
