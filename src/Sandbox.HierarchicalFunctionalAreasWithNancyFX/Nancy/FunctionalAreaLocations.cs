using System;
using System.Collections.Generic;
using System.Linq;

using Nancy.Conventions;
using Nancy.ViewEngines;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy
{
    public class FunctionalAreaLocations
    {
        public const string ROOT_MODULE = "Home";

        public static void Initialize(NancyConventions conventions)
        {
            for (var i = 0; i < 5; i++)
            {
                var level = i;
                conventions.ViewLocationConventions
                           .Add(
                               (v, m, ctx) =>
                               FunctionalAreaLocation(v, m, ctx, level));
            }
        }

        static string FunctionalAreaLocation(
            string viewName, object model, ViewLocationContext context, int level)
        {
            if (viewName.StartsWith("~/")) return viewName.Substring(2);

            var location = new List<string> {ROOT_MODULE};
            var modulePathParts = context.ModulePath.Split(
                new[] {'/'}, StringSplitOptions.RemoveEmptyEntries);

            if (modulePathParts.Length - level > 0)
            {
                location.AddRange(modulePathParts.Skip(level));
            }

            location.Add("_views");
            location.Add(viewName);

            return string.Join("/", location);
        }
    }
}