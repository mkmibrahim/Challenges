using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _77_CheckSSLCertificate.Models
{
    public class ModelOne
    {
        public string Method1()
        {
            return "This test is succesful.";
        }

        public string Method2()
        {
            const string CertName = "TestCertificate";

            var store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            var cert = store
                        .Certificates
                        .OfType<X509Certificate2>()
                        .OrderByDescending(c => c.NotAfter)
                        .FirstOrDefault(c => c.FriendlyName == CertName);

            if (cert == null)
            {
                return $"There is a problem. Certificate {CertName} is NOT found";
            }
            else
            {
                return $"Certificate {CertName} is found";                                
            }
            

        }
    }
}
