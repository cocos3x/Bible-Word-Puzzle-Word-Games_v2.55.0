using UnityEngine;

namespace Utils.Util.Email
{
    public class EmailUtil
    {
        // Methods
        public static void Send(string toEmail, string subject = "", string body = "")
        {
            int val_5;
            string[] val_1 = new string[6];
            val_5 = val_1.Length;
            val_1[0] = "mailto:";
            if(toEmail != null)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[1] = toEmail;
            val_5 = val_1.Length;
            val_1[2] = "?subject=";
            if(subject != null)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[3] = subject;
            val_5 = val_1.Length;
            val_1[4] = "&body=";
            if(body != null)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[5] = body;
            System.Uri val_3 = new System.Uri(uriString:  +val_1);
            UnityEngine.Application.OpenURL(url:  AbsoluteUri);
        }
        public EmailUtil()
        {
        
        }
    
    }

}
