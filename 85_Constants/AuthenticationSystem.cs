using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _85_Constants
{
    internal class AuthenticationSystem
    {
    }
    

    public class Authenticator
    {
        private class EyeColor
        {
            public const string Blue = "blue";
            public const string Green = "green";
            public const string Brown = "brown";
            public const string Hazel = "hazel";
            public const string Brey = "grey";
        }

        public Authenticator(Identity admin)
        {
            this.admin = admin;
        }

        private Identity admin;

        private readonly IDictionary<string, Identity> developers
            = new Dictionary<string, Identity>
            {
                ["Bertrand"] = new Identity
                {
                    Email = "bert@ex.ism",
                    EyeColor = "blue"
                },

                ["Anders"] = new Identity
                {
                    Email = "anders@ex.ism",
                    EyeColor = "brown"
                }
            };

        public Identity Admin
        {
            get { return new Identity {
                                        Email= admin.Email.Normalize(),
                                        EyeColor = admin.EyeColor.Normalize()} ;
            }
            //set { admin = value; }
        }

        public IDictionary<string, Identity> GetDevelopers()
        {
            var result = new Dictionary<string, Identity>();
            foreach(var developer in developers)
            {
                result.Add(developer.Key, new Identity { Email = developer.Value.Email, EyeColor = developer.Value.EyeColor });
            }
            return result; 
        }
    }

    public struct Identity
    {
        public string Email { get; set; }

        public string EyeColor { get; set; }
    }

}
