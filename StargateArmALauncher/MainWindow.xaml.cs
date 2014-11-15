using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Design
using MahApps.Metro.Controls;

//Data
using System.Xml;
using Microsoft.Win32;

namespace StargateArmALauncher
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public class serverList
    {
        public string serverName { set; get; }
        public string serverIP { set; get; }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static String a3path;
        public static String a3path2;
        public static String modpath;
        public static XmlDocument serverXMLreader = new XmlDocument();
        List<serverList> srvList = new List<serverList>();
        public static String mainServer = "http://stargate.tdc-clan.eu";
        Functions functions = new Functions();
        public bool dlServerOnline;
        public bool installed;
        public static String srvLauncherVersion;

        public String infotext = "";

        public MainWindow()
        {
            //Pfad
            installed = true;
            a3path = (String)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\bohemia interactive\ArmA 3", "main", "");
            a3path2 = (String)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\bohemia interactive studio\ArmA 3", "main", "");
            if (String.IsNullOrEmpty(a3path))
            {
                installed = false;
            }
            else if (String.IsNullOrEmpty(a3path2))
            {
                installed = false;
            }
            else if (!installed)
            {
                MessageBox.Show("You dont have a valid ArmA 3 installation installed on your computer");
                Environment.Exit(0);
            }
            if (!String.IsNullOrEmpty(a3path2))
            {
                a3path = a3path2;
            }
            modpath = a3path + "/StargateArmA";

            // Server Config & check
            serverXMLreader.Load(mainServer + "/launcher/server.xml");
            XmlNodeList xnList = serverXMLreader.SelectNodes("/server/config");
            foreach (XmlNode xn in xnList)
            {
                foreach (XmlNode xnconfig in xn.ChildNodes)
                {
                    switch (xnconfig.Name)
                    {
                        case "launcher":
                            srvLauncherVersion = xnconfig.Attributes["version"].InnerText;
                            break;
                        case "infotext":
                            infotext = xnconfig.InnerText;
                            break;
                        case "dlserver":
                            foreach (XmlNode xnfile in xnconfig.ChildNodes)
                            {
                                serverList tmpdata = new serverList();
                                tmpdata.serverName = xnfile.Attributes["name"].InnerText;
                                tmpdata.serverIP = xnfile.Attributes["ip"].InnerText;
                                srvList.Add(tmpdata);
                            }
                            break;
                    }
                }
            }
            // display
            InitializeComponent();
        }

        private void FormLoad()
        {
            // Downloadserver
            foreach (serverList tmpdata in srvList)
            {
                ComboboxItem tmpitem = new ComboboxItem();
                tmpitem.Text = tmpdata.serverName;
                tmpitem.Value = tmpdata.serverIP;
                if (tmpitem != null)
                {
                    combobox_dlserver.Items.Add(tmpitem);
                }
            }
            if (combobox_dlserver.Items.Count > 0) combobox_dlserver.SelectedIndex = 0;

            //Branch
            combobox_branch.Items.Add("stable");
            combobox_branch.Items.Add("dev");
            combobox_branch.SelectedIndex = 0;

            //Buttons
            button_updater_updateLauncher.IsEnabled = false;

            //Infotext
            textbox_main_infotext.Text = infotext;

            //Labels
            if (functions.httpCheck(mainServer)) label_main_serveronline.Content = "online";
            else label_main_serveronline.Content = "offline";

        }

        private void Button_startgame_Click(object sender, RoutedEventArgs e)
        {
            String modstring = "-mod=";
            foreach (String item in functions.getModlist())
            {
                modstring = modstring + item + ";";
            }

            try
            {
                System.Diagnostics.Process game = new System.Diagnostics.Process();
                game.StartInfo.WorkingDirectory = a3path;
                game.StartInfo.FileName = "arma3.exe";
                game.StartInfo.Arguments = "-nosplash " + modstring;
                game.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: %1" + ex);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FormLoad();
        }
    }
}
