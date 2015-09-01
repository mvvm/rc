using Microsoft.Practices.Unity;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rc.Web.App_Start
{
    public static class AppHelper
    {
        public static IDocumentStore Store = null;
        public static IUnityContainer Container = null;
    }
}