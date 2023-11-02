using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Audio;
using Terraria.ID;

namespace HatSimulator.Content.Sounds.Custom
{
    public class HatSimulatorSounds
    {
        public static readonly SoundStyle UnusualOpenSound = new($"{nameof(HatSimulator)}/Content/Sounds/Custom/UnusualOpen", 1)
        {
            Volume = 1.0f,
            Pitch = -1.0f,
            PitchVariance = 0.1f
        };

        public static readonly SoundStyle UnusualPop = new($"{nameof(HatSimulator)}/Content/Sounds/Custom/UnusualPop", 1)
        {
            Volume = 0.7f,
            Pitch = -1.0f,
            PitchVariance = 0.1f
        };

        public static readonly SoundStyle UnusualPopVanilla = SoundID.Item14 with
        {
            Volume = 0.7f,
            Pitch = 1.0f,
            PitchVariance = 0.1f
        };
    }
}
