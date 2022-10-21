using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using CommunicationApp.Models;

namespace CommunicationApp.Services
{
    public class SmsService
    {
        // Sätt användarnamn, lösenord och URL.
        private string mosms_username = ""; //Lägg in användarnamn
        private string mosms_password = ""; //Lägg in lösenord
        private string mosms_url = "http://www.mosms.com/se/sms-send.php";
        private string call_string;
        private string result;
        private Encoding enc = CodePagesEncodingProvider.Instance.GetEncoding(1252);

        //private string mosms_number = ""; // Ersatt av string phoneNumber i SendSms-metoden.
        private string mosms_type = "text";
        private string mosms_allowlong = "";
        private string mosms_customsender = "1";

        private string EncodeData(string mosms_data)
        {
            return HttpUtility.UrlEncode(mosms_data, enc);
        }

        public void SendSms(List<Person> recipients, string message)
        {
            foreach (var person in recipients)
            {
                SingleSmsSend(person.PhoneNumber, message);
            }
        }

        private void SingleSmsSend(string phoneNumber, string message)
        {

            var encodedData = EncodeData(message);
            call_string = mosms_url +
                          "?username=" + mosms_username +
                          "&password=" + mosms_password +
                          "&nr=" + phoneNumber +
                          "&type=" + mosms_type +
                          "&allowlong=" + mosms_allowlong +
                          "&customsender=" + mosms_customsender +
                          "&data=" + encodedData;

            StringBuilder sb = new StringBuilder();

            byte[] buf = new byte[8092];

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(call_string);

            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            Stream resStream = response.GetResponseStream();
            string tempstring = null;
            int count = 0;

            do
            {
                // fyll bufferten
                count = resStream.Read(buf, 0, buf.Length);
                // kontrollera att data finns att läsa
                if (count != 0)
                {
                    // koda som ISO text
                    tempstring = enc.GetString(buf, 0, count);

                    // bygg upp svarssträngen
                    sb.Append(tempstring);
                }
            } while (count > 0); // finns mer data att läsa?

            result = HttpUtility.UrlDecode(tempstring, enc);

            if (result == "0")
            {
                Debug.WriteLine("SMS skickat korrekt");
            }
            else
            {
                Debug.WriteLine("Fel vid anrop: " + result);
            }
        }
    }
}