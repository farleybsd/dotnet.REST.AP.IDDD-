using Autofac;

namespace RestApiModeloTdd.Infrastruture.CrossCutting.IOC
{
    public class ModeIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}