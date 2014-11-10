using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace StargateArmALauncher
{
    class Functions
    {
        public string getLocalVersion()
        {
            if (File.Exists(MainWindow.modpath + "/localversion"))
            {
                String file = MainWindow.modpath + "/localversion";
                try
                {
                    StreamReader sr = new StreamReader(file);
                    return sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    return ex.ToString() + "\n" + file;
                }
            }
            return "0.0.0";
        }

        public List<String> getModlist()
        {
            List<String> tmplist = new List<String>();
            String line;

            if (File.Exists(MainWindow.modpath + "/addonList"))
            {
                StreamReader file = new StreamReader(MainWindow.modpath + "/addonList");
                while ((line = file.ReadLine()) != null)
                {
                    tmplist.Add(line);
                }
                file.Close();
            }

            return tmplist;
        }

        public bool httpCheck(String Server)
        {
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(Server);
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    rspFP.Close();
                    return true;
                }
                else
                {
                    rspFP.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        public String getAdditionalParameters()
        {
            if (File.Exists(MainWindow.modpath + "/additionalParamters"))
            {
                String file = MainWindow.modpath + "/additionalParamters";
                try
                {
                    StreamReader sr = new StreamReader(file);
                    return sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    // LOG!
                }
            }
            return "0.0.0";
        }

        public void logIt(String what)
        {

        }
    }
}
