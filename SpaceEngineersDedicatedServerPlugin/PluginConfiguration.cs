using VRage.Plugins;

namespace SpaceEngineersDedicatedServerPluginExample
{
    public class PluginConfiguration : IPluginConfiguration
    {
        //[Display(Name = "Enum")]
        //[Category("General")]
        //public TestEnum TestEnumMember = TestEnum.EnumValue1;

        //[Display(Name = "Float")]
        //[Category("General")]        
        //[Range(1, 100)]
        //public float FloatMember = 10;

        //[Display(Name = "Double")]
        //[Category("General")]
        //[Range(1, 100)]
        //public double DoubleMember = 20;

        //[Display(Name = "Byte")]
        //[Category("General")]
        //[Range(1, 10)]
        //public byte ByteMember = 4;

        //[Display(Name = "SByte")]
        //[Category("General")]
        //[Range(1, 10)]
        //public sbyte SByteMember = 4;

        //[Display(Name = "Short")]        
        //[Category("General")]
        //[Range(2, 32)]
        //public short ShortMember = 4;

        //[Display(Name = "UShort")]
        //[Category("General")]
        //[Range(2, 32)]
        //public ushort UShortMember = 8;

        //[Display(Name = "Int")]                
        //[Category("General")]
        //[Range(0, int.MaxValue)]
        //public int IntMember = 50000;

        //[Display(Name = "UInt")]        
        //[Category("General")]
        //[Range(0, uint.MaxValue)]
        //public uint UIntMember = 100000;

        //[Display(Name = "Long")]
        //[Category("General")]
        //[Range(0, long.MaxValue)]
        //public long LongMember = 1;

        //[Display(Name = "ULong")]
        //[Category("General")]
        //[Range(0, ulong.MaxValue)]
        //public ulong ULongMember = 2;

        //[Display(Name = "Bool")]
        //[Category("General")]
        //public bool BoolMember = true;

        //[Display(Name = "String")]
        //[Category("General")]
        //public string StringMember = "String value";

        //[Display(Name = "Hidden")]
        //[Category("General")]
        //[Browsable(false)]
        //public string HiddenMember = null;

        //[Display(Name = "Webserver")]
        //[Category("General")]
        public string Webserver = "";

        //[Display(Name = "Port")]
        //[Category("General")]
        public string Port = "80";

        //[Display(Name = "ClientID")]
        //[Category("General")]
        public string ClientID = "Enter your ClientID";

        //[Display(Game = "ClientSecret")]
        //[Category("General")]
        public string ClientSecret = "Enter your ClientSecret";

        public void Save(string userDataPath)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(PluginConfiguration));

            //string configFile = Path.Combine(userDataPath, "SpaceLink.cfg");
            //using(StreamWriter stream = new StreamWriter(configFile, false, Encoding.UTF8))
            //{
            //    serializer.Serialize(stream, this);
            //}
        }
    }

    public enum TestEnum
    {
        EnumValue1,
        EnumValue2,
        EnumValue3
    }
}
