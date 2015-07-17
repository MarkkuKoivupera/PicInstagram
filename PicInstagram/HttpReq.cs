using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace PicInstagram
{
    public class HttpReq
    {
        public String read_Address(String strAddress)
        {
           // String StrMScore = strAddress;
           // List<String> LSHerfID = new List<string>();
           // WebClient client = new WebClient();
           //// String jsessionid = client.DownloadString("http://www.mscorecard.com/mscorecard/login.php");
           // //action="/ogk/login.nxg;jsessionid=6800EBCF1A9CDAA8793755CB49935CD0"
           // ASCIIEncoding encoding = new ASCIIEncoding();
           // CookieContainer cookies = new CookieContainer();

           // string postData = "";// "Location=" + "";
           // //postData += ("&Email=" + strJNro);
           // //postData += ("&Password=" + strPass);
           // //postData += ("&Remember=1");
           // //postData += ("&OK=Login");
           // byte[] data = encoding.GetBytes(postData);
           // //Location=&Email=papakeke%40hotmail.com&Password=eemako96&Remember=1&OK=Login
           // // Prepare web request...
           // //String strDoLogin = StrMScore + "dologin.php?Location=&Email=" + strJNro + "&Password=" + strPass + "&Remember=1&OK=Login";
           // HttpWebRequest myRequest =
           //   (HttpWebRequest)WebRequest.Create(StrMScore);
           // myRequest.CookieContainer = cookies;


           // myRequest.Method = "POST"; // <<--- This is the key word of the day


           // //myRequest.ContentType = "application/x-www-form-urlencoded";
           // //myRequest.ContentLength = data.Length;
           // Stream newStream = myRequest.GetRequestStream();
           // //StreamWriter writer = new StreamWriter(newStream);
           // // Send the data.
           // //writer.Write("Location=&Email=" + strJNro + "&Password=" + strPass + "&Remember=1&OK=Login");
           // newStream.Write(data, 0, data.Length);
           // //writer.Close();
           // newStream.Close();
           // HttpWebResponse response = (HttpWebResponse)myRequest.GetResponse();

           // StreamReader reader = new StreamReader(response.GetResponseStream());

           // String Vastaus = reader.ReadToEnd();
           // //<div class="menuItem">
           // //<a href="/ogk/memberFlightQuery.nxg;jsessionid=2FFEB95AD2409D4601B5B08075DECA07" class="menuItem">Omat varaukset</a>	
           // //</div>
           // reader.Close();
            String Vastaus = String.Empty;
            Uri uri = new Uri(strAddress);
            if (uri.Scheme == Uri.UriSchemeHttps)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Http.Get;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Vastaus = reader.ReadToEnd();
                response.Close();
                //response.Write(tmp);
            }
            return Vastaus;

        }
    }
}
