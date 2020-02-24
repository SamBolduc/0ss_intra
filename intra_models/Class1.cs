using System;
using System.ComponentModel;

namespace intra_models
{
    public class Class1 : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string ContactInfo { get; set; }
        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
