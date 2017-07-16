namespace RestaurantManager.ViewAndBindingModels.ViewModels
{
    public class MenuItemIndexViewModel
    {
        private MenuItemFullViewModel postMenuItemModel = new MenuItemFullViewModel();
        public MenuItemPdfViewModel ItemPdfViewModel { get; set; }

        public MenuItemFullViewModel PostMenuItemModel
        {
            get { return this.postMenuItemModel; }
            set { this.postMenuItemModel = value; }
        }
    }
}
