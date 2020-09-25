using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace UWP
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private static readonly string _conn = "HostName=ecwin20-iothub.azure-devices.net;DeviceId=uwp;SharedAccessKey=++bmt4TL7p26xrbOWIaSvmBIH9yvzyTYcg9l50VjW3Q=";

        private static readonly DeviceClient deviceClient =
            DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);


        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
        }
    }
}
