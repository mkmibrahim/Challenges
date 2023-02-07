using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace _75_ListCertificates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\r\nExists Certs Name and Location");
            Console.WriteLine("------ ----- -------------------------");

            foreach (StoreLocation storeLocation in (StoreLocation[])
                Enum.GetValues(typeof(StoreLocation)))
            {
                foreach (StoreName storeName in (StoreName[])
                    Enum.GetValues(typeof(StoreName)))
                {
                    X509Store store = new X509Store(storeName, storeLocation);

                    try
                    {
                        store.Open(OpenFlags.OpenExistingOnly);
                        Console.WriteLine("\r\n");
                        Console.WriteLine("------ ----- -------------------------");
                        Console.WriteLine("Exisits: Yes    , Certs:{0,4}  , Name and Location: {1}, {2}",
                            store.Certificates.Count, store.Name, store.Location);

                        var test = store.Certificates
                                                    .OfType<X509Certificate2>()
                                                    .OrderByDescending(c => c.Subject);
                                                    


                        Console.WriteLine ("{1}Store name: {0}", store.Name, Environment.NewLine);

                        foreach (X509Certificate2 x509 in test)
                        {
                            Console.WriteLine ("certificate name: {0}, expiration date: {1}", x509.Subject, x509.GetExpirationDateString());
                        }

                    }
                    catch (CryptographicException)
                    {
                        Console.WriteLine("No           {0}, {1}",
                            store.Name, store.Location);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
