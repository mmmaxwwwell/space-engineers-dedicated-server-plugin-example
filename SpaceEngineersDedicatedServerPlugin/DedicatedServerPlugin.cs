using Sandbox;
using System.IO;
using System.Xml.Serialization;
using VRage.Plugins;

namespace SpaceEngineersDedicatedServerPluginExample
{
    public class DedicatedServerPlugin : IConfigurablePlugin
    {
        private PluginConfiguration m_configuration;

        public void Init(object gameInstance)
        {
            var game = (MySandboxGame)gameInstance;
            m_configuration = new PluginConfiguration();
        }

        public void Update()
        {

        }

        public IPluginConfiguration GetConfiguration(string userDataPath)
        {
            if (m_configuration == null)
            {
                string configFile = Path.Combine(userDataPath, "SpaceLink.cfg");
                if (File.Exists(configFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(PluginConfiguration));
                    using (FileStream stream = File.OpenRead(configFile))
                    {
                        m_configuration = serializer.Deserialize(stream) as PluginConfiguration;
                    }
                }

                if (m_configuration == null)
                {
                    m_configuration = new PluginConfiguration();
                }
            }

            return m_configuration;
        }

        public void Dispose()
        {
        }

        public string GetPluginTitle()
        {
            return "SpaceEngineersDedicatedServerPluginExample";
        }
    }
}
