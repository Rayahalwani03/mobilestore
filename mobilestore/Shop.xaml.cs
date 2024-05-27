using mobilestore.ShopDB;
using mobilestore.StoreDB;

namespace mobilestore;

public partial class Shop : ContentPage
{
	public Shop()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UpdatePriceLabel();
    }

    private void UpdatePriceLabel()
    {
        price1.Text = $"Total: {SharedCpuData.SelectedCpu + SharedStorageData.SelectedStorage + SharedMonitorData.SelectedMonitor}";
    }





    public static class GlobalSizes
	{
        public static int memorysize = 150;
        public static int monitorsize = 450;
        public static int storagesize = 300;
	}



    private void Memory_minus_Clicked(object sender, EventArgs e)
    {

    }

    private void Memory_plus_Clicked(object sender, EventArgs e)
    {

            

    }

    private void Storage_minus_Clicked(object sender, EventArgs e)
    {

    }

    private void Storage_plus_Clicked(object sender, EventArgs e)
    {

    }

    private void Monitor_minus_Clicked(object sender, EventArgs e)
    {

    }

    private void Monitor_plus_Clicked(object sender, EventArgs e)
    {

    }
}