using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;

namespace ShoppingList
{
    [Table("List")]
    public class List: INotifyPropertyChanged
    {
        private int list_id;
        [PrimaryKey, AutoIncrement]
        public int List_Id
        {
            get
            {
                return list_id;
            }
            set
            {
                this.list_id = value;
                OnPropertyChanged(nameof(List_Id));
            }
        }
        private DateTime created_date;
        [NotNull]
        public DateTime Created_Date
        {
            get
            {
                return created_date;
            }
            set
            {
                this.created_date = value;
                OnPropertyChanged(nameof(Created_Date));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
