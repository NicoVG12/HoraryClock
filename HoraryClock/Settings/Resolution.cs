using System.Reflection;

namespace Settings
{
    public class Resolution
    {
        public const String HIGH = "HIGH";
        public const String MID = "MID";
        public const String LOW = "LOW";
        public struct FontSizeData
        {
            public double Title { get; set; }
            public double Full { get; set; }
            public double Menu { get; set; }
            public double Setting { get; set; }
        }

        public struct ResolutionData
        {
            public int Height { get; set; }
            public int Width { get; set; }
        }

        public string Name { get; private set; }
        public double Scale { get; private set; }
        public FontSizeData FontSize { get; private set; }
        public ResolutionData FullWindowResolution { get; private set; }
        public ResolutionData MiniWindowResolution { get; private set; }

        private Resolution() { }
        public Resolution(string resolution)
        {
            switch (resolution)
            {
                case HIGH:
                    FullResolution();
                    break;
                case MID:
                    MidResolution();
                    break;
                case LOW:
                    LowResolution();
                    break;
            }
        }




        private Resolution FullResolution()
        {
            return new Resolution()
            {
                Name = HIGH,
                Scale = 2,
                FullWindowResolution = new ResolutionData
                {
                    Height = 664,
                    Width = 1058
                },
                MiniWindowResolution = new ResolutionData
                {
                    Height = 208,
                    Width = 478
                },
                FontSize = new FontSizeData
                {
                    Title = 24,
                    Full = 32,
                    Menu = 24,
                    Setting = 18
                }
            };

        }

        private Resolution MidResolution()
        {
            return new Resolution()
            {
                Name = MID,
                Scale = 1.5,
                FullWindowResolution = new ResolutionData
                {
                    Height = 498,
                    Width = 794
                },
                MiniWindowResolution = new ResolutionData
                {
                    Height = 156,
                    Width = 359
                },
                FontSize = new FontSizeData
                {
                    Title = 18,
                    Full = 24,
                    Menu = 18,
                    Setting = 13.5
                }
            };
        }

        private Resolution LowResolution() 
        {
            return new Resolution()
            {
                Name = LOW,
                Scale = 1,
                FullWindowResolution = new ResolutionData
                {
                    Height = 332,
                    Width = 529
                },
                MiniWindowResolution = new ResolutionData
                {
                    Height = 104,
                    Width = 239
                },
                FontSize = new FontSizeData
                {
                    Title = 12,
                    Full = 16,
                    Menu = 12,
                    Setting = 9
                }
            };
        }
    }
}
