using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;

namespace ShoppingList.Models
{
    [Table("Items")]
    public class Items
    {
        private int item_id;
        [PrimaryKey, AutoIncrement]
        public int Item_Id
        {
            get
            {
                return item_id;
            }
            set
            {
                this.item_id = value;
                OnPropertyChanged(nameof(Item_Id));
            }
        }
        private string item_name;
        [NotNull, MaxLength(50)]
        public string Item_Name
        {
            get
            {
                return item_name;
            }
            set
            {
                this.item_name = value;
                OnPropertyChanged(nameof(Item_Name));
            }
        }
        private string item_description;
        [NotNull, MaxLength(100)]
        public string Item_Description
        {
            get
            {
                return item_description;
            }
            set
            {
                this.item_description = value;
                OnPropertyChanged(nameof(Item_Description));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
