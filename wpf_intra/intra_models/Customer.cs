using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Customer : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string ContactInfo { get; set; }
        public string PicturePath { get; set; }

        private string _info;

        public string Info {
            get => LastName + ", " + Name;
            private set
            {
                this._info = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
