using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;

namespace Auth.gg
{
    class auth
    {

        static void Main(string[] args)
        {


            Console.Title = "Auth.gg AIO | aryn#5511";

            if (File.Exists("auth.chickenn"))
            {


            }
            else
            {

                using (StreamWriter sw = File.CreateText("auth.chickenn")) ;
              
                Console.Clear();

            }





            int count1 = File.ReadAllLines("auth.chickenn").Count();
            if (count1 == 0)
            {
                Console.Clear();
                Console.Write("Enter your auth");
                Console.Write(" > ");
                string read = Console.ReadLine();
                using (StreamWriter auth = new StreamWriter("auth.chickenn"))
                {
                    auth.WriteLine(read);

                }
                Console.Clear();
                Console.WriteLine("saved in auth.chicken");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                main();
            }
            else
            {
                Console.Clear();
                main();
            }


           

        }
     
        public static void main()
        {
            Console.Clear();
            string hello1 = File.ReadLines("auth.chickenn").ElementAt(1 - 1);


            Console.Write(" 0]");
            Console.Write(" Total user count");
            Console.WriteLine();
            Console.Write(" 1]");
            Console.Write(" Key Generator");
            Console.WriteLine();
            Console.Write(" 2]");
            Console.Write(" User info");
            Console.WriteLine();
            Console.Write(" 3]");
            Console.Write(" delete a user");
            Console.WriteLine();
            
            Console.Write(" 4]");
            Console.Write(" delete key");
            Console.WriteLine();
            Console.Write(" 5]");
            Console.Write(" reset hwid");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" >> ");
            
            string choose = Console.ReadLine();
            


            if (choose == "0")
            {
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/USERS/?type=count&authorization=" + hello1));
                
                    string read = (string)jobject["value"];
                Console.Clear();
                Console.WriteLine("Total User Count = " + read);
                
              



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
            else if ( choose == "1")
            {
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/LICENSES/?type=generate&days=3000&amount=1&level=1&authorization=" + hello1));
                
                    string read = (string)jobject["0"];
                Console.Clear();
                Console.WriteLine("License Generated = " + read);
               
               





                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
           else if (choose == "2")
            {
                Console.Clear();
                Console.WriteLine("Name of the user?");
                string read = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/USERS/?type=fetch&authorization=" + hello1 +"&user=" + read));

                string reada = (string)jobject["email"];
                string readb = (string)jobject["rank"];
                string readc = (string)jobject["hwid"];
                string readd = (string)jobject["lastlogin"];
                string reade = (string)jobject["lastip"];
                string readf = (string)jobject["expiry"];
                Console.Clear();
                Console.WriteLine("Username - " + read);
                Console.WriteLine("Email - " + reada);
                Console.WriteLine("Rank - " + readb);
                Console.WriteLine("Hwid - " + readc);
                Console.WriteLine("LastLogin - " + readd);
                Console.WriteLine("LastIP - " + reade);
                Console.WriteLine("ExpiryDate - " + readf);
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
           
           else if (choose == "3")
            {
                Console.Clear();
                Console.WriteLine("Name of the user?");
                string read = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/USERS/?type=delete&authorization=" +hello1+"&user=" + read));
                string reada = (string)jobject["info"];
                Console.Clear();
                Console.WriteLine("'" +read +"' "+ reada);

                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
          
            else if (choose == "4")
            {
                Console.Clear();
                Console.WriteLine("license?");
                string read = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/LICENSES/?type=delete&license=" + read + "&authorization=" +hello1 + "&user="));
              
                string reada = (string)jobject["info"];
                Console.Clear();
                Console.WriteLine(reada);

                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
        else if (choose == "5")
            {
                Console.Clear();
                Console.WriteLine("Name of the user?");
                string read = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Getting info..");
                JObject jobject = JObject.Parse(new WebClient().DownloadString("https://developers.auth.gg/HWID/?type=reset&authorization=" + hello1 + "&user=" + read));

                string reada = (string)jobject["info"];
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(reada);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Go Back To The Main menu");
                Console.ReadLine();
                Console.Clear();
                auth.main();
            }
          else
          {
              Console.clear();
            }
        }
    }
}
