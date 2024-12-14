using System.Security.Claims;
using Examen.utils;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using project.users;
using project.utils.interfaces;

namespace project.utils.services
{
    public class interceptorDb : SaveChangesInterceptor
    {
        localStorage localStoragSvc;
        public interceptorDb(localStorage localData)
        {
            localStoragSvc = localData;
        }
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            addUpdate(eventData);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            addUpdate(eventData);
            return base.SavingChanges(eventData, result);
        }
        private void addUpdate(DbContextEventData eventData)
        {
            string id= localStoragSvc.get("user");
            if (id == null)
            {
                Application.Exit();
            }
            foreach (var entry in eventData.Context.ChangeTracker.Entries<ICommonModelHeader>())
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.createAt = DateTime.UtcNow;
                    entry.Entity.userCreateId = id;
                }
                if (  entry.State == EntityState.Modified)
                {
                    entry.Entity.userUpdateId = id;
                    entry.Entity.updateAt = DateTime.UtcNow;
                }
            }
        }

    }
}