using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("93_Attributes.Tests")]

namespace _93_Attributes
{
    internal class Trolls
    {
    }

    enum AccountType
    {
        Guest,
        User,
        Moderator
    }

    [Flags]
    enum Permission
    {
          None = 0,   // Binary 0000000
          Read = 1,   // Binary 0000001
          Write = 2,  // Binary 0000010
          Delete = 4, // Binary 0000100
          All = 7,    // Binary 0000111
    }

    static class Permissions
        {
        public static Permission Default(AccountType accountType) => 
            accountType switch
            {
                AccountType.Guest => Permission.Read,
                AccountType.User => Permission.Read | Permission.Write,
                AccountType.Moderator => Permission.All,
                _ => Permission.None
            };
        
        public static Permission Grant(Permission current, Permission grant) =>
             current | grant;
        //{
        //    //if (current == Permission.None)
        //    //    return grant;
        //    //else if (current == Permission.All)
        //    //    return current;
        //    //else if (current == Permission.Read)
        //    //        return current | grant;
        //    //if (current == (Permission.Read | Permission.Write) && grant == Permission.Delete)
        //    //    return Permission.All;
        //    //else
        //    //    return grant;
        //}
        public static Permission Revoke(Permission current, Permission revoke) =>
            current & ~revoke;
        //{
        //    if (current == Permission.None | revoke == Permission.None)
        //        return current;
        //    else if (current == Permission.Read | current == Permission.Write 
        //        | current == Permission.Delete | revoke == Permission.All)
        //        return Permission.None;
        //    else 
        //    {
        //       if (current.HasFlag(Permission.Read) & revoke.HasFlag(Permission.Read))
        //        {
        //            var result = current;
        //            result &= ~Permission.Read;
        //            return result;
        //        }
        //       if (current.HasFlag(Permission.Write) & revoke.HasFlag(Permission.Write))
        //        {
        //            var result = current;
        //            result &= ~Permission.Write;
        //            return result;
        //        }
        //       if (current.HasFlag(Permission.Delete) & revoke.HasFlag(Permission.Delete))
        //        {
        //            var result = current;
        //            result &= ~Permission.Delete;
        //            return result;
        //        }
        //       else
        //            return current;
        //    }
        //}
        public static bool Check(Permission current, Permission check) =>
            current.HasFlag(check);
        //{
        //    var result = true;
        //    if (current == check | current == Permission.All)
        //        result = true;
        //    else
        //    {
        //        if (!current.HasFlag(Permission.Read) & check.HasFlag(Permission.Read) | 
        //            !current.HasFlag(Permission.Write) & check.HasFlag(Permission.Write) |
        //            !current.HasFlag(Permission.Delete) & check.HasFlag(Permission.Delete))
        //        {
        //            result = false;
        //        }
        //    }
        //    return result;
        //}
    }

}
