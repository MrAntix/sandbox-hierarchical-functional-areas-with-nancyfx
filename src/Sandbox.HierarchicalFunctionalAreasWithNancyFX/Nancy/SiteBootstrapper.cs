using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace Sandbox.HierarchicalFunctionalAreasWithNancyFX.Nancy
{
    public class SiteBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(
            TinyIoCContainer container, IPipelines pipelines)
        {
            Conventions.ViewLocationConventions.Clear();
            FunctionalAreaLocations.Initialize(Conventions);

            Conventions.StaticContentsConventions
                       .Add(StaticContentConventionBuilder.AddDirectory("scripts", "Scripts"));
            Conventions.StaticContentsConventions
                       .Add(StaticContentConventionBuilder.AddDirectory("fonts", "Fonts"));
            Conventions.StaticContentsConventions
                       .Add(StaticContentConventionBuilder.AddDirectory("products/womens/_images", "Home/Products/Womens/_images"));
            Conventions.StaticContentsConventions
                       .Add(StaticContentConventionBuilder.AddDirectory("products/mens/_images", "Home/Products/Mens/_images"));
        }
    }
}