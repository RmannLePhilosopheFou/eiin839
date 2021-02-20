using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;


namespace HeaderRequest
{
    class Header
    {
        private HttpListenerRequest httpListnerRequest;

        public Header(HttpListenerRequest request)
        {
            this.httpListnerRequest = request;
        }

        public void displayAllHeader() //Affiche tous les types d'entêtes contenues dans l'enum HttpRequestHeader
        {
           Console.WriteLine("here");
           foreach (string str in Enum.GetNames(typeof(HttpRequestHeader)))
                {
                Console.WriteLine(" "+ str+ ", "+this.httpListnerRequest.Headers[str]);
            }
        }

        public void printOneHeder(HttpRequestHeader header)
        {
            Console.WriteLine(httpListnerRequest.Headers[header.ToString()]);
        }

       
    }
}
