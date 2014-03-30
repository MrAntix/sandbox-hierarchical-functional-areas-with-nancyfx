using System.Diagnostics;

using Nancy;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy
{
    public abstract class FunctionalAreaModule : NancyModule
    {
        protected FunctionalAreaModule()
        {
            var type = GetType();

            Debug.Assert(type.Namespace != null, "type.Namespace != null");
            ModulePath = type.Namespace
                             .Substring(type.Assembly.GetName().Name.Length
                                        + FunctionalAreaLocations.ROOT_MODULE.Length + 1)
                             .Replace(".", "/");
        }
    }
}