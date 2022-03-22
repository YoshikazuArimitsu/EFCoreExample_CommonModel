using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CommonModelLib
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string name)
        {
            var h = PropertyChanged;
            if (h == null)
            {
                return;
            }
            h(this, new PropertyChangedEventArgs(name));
        }
    }
}
