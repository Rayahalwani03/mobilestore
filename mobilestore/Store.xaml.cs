

using mobilestore.StoreDB;

namespace mobilestore;

public partial class Store : ContentPage
{
	public Store()
	{
		InitializeComponent();
	}

    

    private void CalculateCpu()
    {
        if (rbcorei3.IsChecked)
            SharedCpuData.SelectedCpu = GlobalPrices.cpui3;
        else if (rbcorei5.IsChecked)
            SharedCpuData.SelectedCpu = GlobalPrices.cpui5;
        else if (rbcorei7.IsChecked)
            SharedCpuData.SelectedCpu = GlobalPrices.cpui7;
        else if (rbcorei9.IsChecked)
            SharedCpuData.SelectedCpu = GlobalPrices.cpui9;
        price.Text = $"Total: {SharedCpuData.SelectedCpu + SharedStorageData.SelectedStorage + SharedMonitorData.SelectedMonitor}";
    }
    private void CalculateStorage()
    {
        if (rbhdd.IsChecked)
            SharedStorageData.SelectedStorage = GlobalPrices.hdd;
        else if (rbssd.IsChecked)
            SharedStorageData.SelectedStorage = GlobalPrices.ssd;
        price.Text = $"Total: {SharedCpuData.SelectedCpu + SharedStorageData.SelectedStorage + SharedMonitorData.SelectedMonitor}";
    }

    private void CalculateMonitor()
    {
        if (rbphillips.IsChecked)
            SharedMonitorData.SelectedMonitor = GlobalPrices.phillips;
        else if (rbnec.IsChecked)
            SharedMonitorData.SelectedMonitor = GlobalPrices.nec;
        else if (rbhp.IsChecked)
            SharedMonitorData.SelectedMonitor = GlobalPrices.hp;

        price.Text = $"Total: {SharedCpuData.SelectedCpu + SharedStorageData.SelectedStorage + SharedMonitorData.SelectedMonitor}";
    }
    public static class GlobalPrices
    {
        public static int cpui3 = 1500;
        public static int cpui5 = 1700;
        public static int cpui7 = 2000;
        public static int cpui9 = 2500;

        public static int hdd = 300;
        public static int ssd = 500;

        public static int phillips = 403;
        public static int nec = 432;
        public static int hp = 543;
    }

    

    private void rbcorei9_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateCpu();
    }

    private void rbcorei7_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateCpu();
    }

    private void rbcorei5_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateCpu();
    }

    private void rbcorei3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateCpu();
    }

    private void rbhdd_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateStorage();
    }

    private void rbssd_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateStorage();
    }


    private void rbphillips_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateMonitor();
    }

    private void rbnec_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateMonitor();
    }

    private void rbhp_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculateMonitor();
    }

}