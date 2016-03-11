using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.NotifyPropertyChanged("OrdersItems");
        }

        public List<Order> OrderItems
        {
            get { return base.Repository.Orders; }
            set
            {
                base.Repository.Orders = value;
                this.NotifyPropertyChanged("OrderItems");
            }
        }
    }
}
