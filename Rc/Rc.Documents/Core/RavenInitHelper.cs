using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Documents.Core
{
    public static class RavenInitHelper
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Must be called on every init
        /// </summary>
        public static IDocumentStore InitBriefBoxIds(this IDocumentStore store)
        {
            store.Conventions.FindIdentityProperty = memberInfo => memberInfo.Name == "Id";

            // store.Conventions.RegisterIdConvention<WorkroomCalendar>((dbname, commands, workroomCalendar) => WorkroomCalendar.IdPrefix + workroomCalendar.WorkroomId);
            // store.Conventions.RegisterIdConvention<UserImage>((dbname, commands, userImage) => "userimage/");

            store.Conventions.RegisterIdConvention<ApplicationUser>((dbname, commands, applicationUser) => "ApplicationUser/");

            return store;
        }        
    }
}
