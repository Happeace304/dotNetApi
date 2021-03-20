using dotNetProject.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace dotNetProject.DAL
{
    public class UserSeeder : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {

            var users = new List<User>
            {
                new User{FirstName= "Nhat", LastName="Phan", IsDisabled= false},
                new User{FirstName= "Meo", LastName="Nguyen", IsDisabled= false}

            };

            users.ForEach(u => context.Users.Add(u));

            var permissionGroups = new List<PermissionGroup>
            {
                new PermissionGroup{Name= "NhatGroup",  IsDisabled= false},
                new PermissionGroup{Name= "MeoGroup", IsDisabled= false}

            };

            permissionGroups.ForEach(u => context.PermissionGroups.Add(u));
            context.SaveChanges();

            var userPermissionGroups = new List<UserPermissionGroup>
            {
                new UserPermissionGroup{ID=1, PermissionGroupID=1, IsDisabled= false},
                new UserPermissionGroup{ID=2, PermissionGroupID=2, IsDisabled= false}

            };

            userPermissionGroups.ForEach(u => context.UserPermissionGroups.Add(u));
            context.SaveChanges();
        }

    }
}