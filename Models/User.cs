using System;
using System.Collections.Generic;

namespace NetPcl.Models
{
    public enum UserPermissions {
        Guest = 0, TestCreator = 1, Tester = 2, Admin = 7
    }

    public class User {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserPermissions Permissions {get;set;} = UserPermissions.Guest;
    }
}