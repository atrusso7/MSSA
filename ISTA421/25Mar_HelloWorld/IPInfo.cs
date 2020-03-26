

using System;
using System.Net;

namespace _25Mar_HelloWorld
{
    public class IPInfo
    {
        private string ipAddress;
        public string IPAddress { get => ipAddress; set => ipAddress = GetIPAddress(); }
        public string Location { get; set; }
        public string ISP { get; set; }
        public IPInfo()
        {
            this.IPAddress = null;
            this.Location = null;
            this.ISP = null;
        }
        public string GetIPAddress()
        {
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
    }
}