﻿using Demo.BLL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;
using static WebApp.Admin.Security.Settings;

// You can learn about Database Initialization Strategies in EF6 via
// http://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx

namespace WebApp.Admin.Security
{
    /// <summary>
    /// Provide functionality for setting up the database for the ApplicationDbContext.
    /// The specific functionality is to create the database if it does not exist.
    /// </summary>
    public class SecurityDbContextInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //To "seed" a database is to provide it with some initial data
            // when the databaase is created

            #region Seed the security rolesC:\Users\nbignell2\Documents\GitHub\DMIT-2018-Workbook\src\Custom Identity\WebApp\Web.config
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //The RoleManager<T> and RoleStore<T> are BLL classes that give flexibility 
            // to the design/structure of how we're using Asp.Net identity.
            // The identityrole is an entity class that represents a security role



            foreach (var role in DefaultSecurityRoles)
                roleManager.Create(new IdentityRole { Name = role });
            #endregion


            #region Seed the users
            // Create a user 
            var adminUser = new ApplicationUser
            {
                UserName = "WebAdmin",
                Email = "Fake@Hackers.ru",
                EmailConfirmed = true
            };

            // Get the BLL user manager 
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            // - The ApplicationUserManager is a BLL class in the IdentityConfig.cs file
            var result = userManager.Create(adminUser, "Pa$$w0rd");
            if(result.Succeeded)
            {
                // Get the Id that was generated for the user we created/added
                var found = userManager.FindByName("WebAdmin").Id;
                // Add the user to the Administrators role
                userManager.AddToRole(found, AdminRole);
            }

            // Create the other user accounts for all the other people in my demo database
            var demoManager = new DemoController();
            var people = demoManager.ListImportantPeople();
            foreach (var person in people)
            {
                var user = new ApplicationUser
                {
                    UserName = $"{person.FirstName}.{person.LastName}",
                    Email = $"{person.FirstName}.{person.LastName}@DemoIsland.com",
                    EmailConfirmed = true,
                    PersonId = person.PersonID
                };
                result = userManager.Create(user, "Pa$$w0rd1");
                if (result.Succeeded)
                {
                    var userId = userManager.FindByName(user.UserName).Id;
                    userManager.AddToRole(userId, UserRole);
                }

            }
            #endregion

            //Keep the call to the base class to do its seeding work
            base.Seed(context);
        }
    }
}