using System;
using System.Runtime.CompilerServices;

namespace _90_Sets
{
    internal class Faceid2
    {
    }

    public class FacialFeatures
    {
        public string EyeColor { get; }
        public decimal PhiltrumWidth { get; }

        public FacialFeatures(string eyeColor, decimal philtrumWidth)
        {
            EyeColor = eyeColor;
            PhiltrumWidth = philtrumWidth;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is FacialFeatures)
            {
                var otherObject = (FacialFeatures)obj;
                if (otherObject.EyeColor == EyeColor & otherObject.PhiltrumWidth == PhiltrumWidth)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }

    public class Identity
    {
        public string Email { get; }
        public FacialFeatures FacialFeatures { get; }

        public Identity(string email, FacialFeatures facialFeatures)
        {
            Email = email;
            FacialFeatures = facialFeatures;
        }

        public override bool Equals(object? obj)
        {
            if ( obj != null && obj is Identity)
            {
                var otherIdentity = (Identity)obj;
                if (otherIdentity.Email == Email && otherIdentity.FacialFeatures.Equals(FacialFeatures))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }

    public class Authenticator
    {
        List<Identity> _registeredIdentities = new List<Identity>();

        public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        {
            return faceA.Equals(faceB);
        }

        public bool IsAdmin(Identity identity)
        {
            if (identity != null 
                && identity.Email == "admin@exerc.ism" 
                && identity.FacialFeatures.Equals(new FacialFeatures("green", 0.9m)))
                return true;
            else
                return false;
        }

        public bool Register(Identity identity)
        {
            if (identity != null)
            { 
                if (_registeredIdentities.Contains(identity))
                    return false;
                else
                { 
                    _registeredIdentities.Add(identity);
                    return true;
                }
            }
            return false;
        }

        public bool IsRegistered(Identity identity)
        {
            var result = false;
            if (identity != null)
            {
                for (int i = 0; i < _registeredIdentities.Count; i++)
                {
                    if (_registeredIdentities[i].Equals(identity))
                        result = true;
                }

            }
            return result;
        }

        public static bool AreSameObject(Identity identityA, Identity identityB)
        {
            return System.Object.ReferenceEquals(identityA, identityB);
        }
    }

}
