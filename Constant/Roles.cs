using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermissionBasedSystem.Constant
{
    public enum Roles
    {
        //These are the default roles that we would try to seed to the database as soon as the application fires up.
        SuperAdmin,
        Admin,
        Basic
    }
}
