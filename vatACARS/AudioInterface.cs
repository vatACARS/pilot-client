using System.Media;
using System.Runtime.InteropServices;

namespace vatACARS
{
    public static class AudioInterface
    {
        private static string dirPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\vatACARS\\audio";
        private static Logger logger = new Logger("AudioInterface");
        private static SoundPlayer SoundPlayer = new SoundPlayer();

        public static void playSound(string sound)
        {
            try
            {
                int volume = Properties.Settings.Default.Volume;
                volume = Math.Max(0, Math.Min(100, volume));
                int scaledVolume = (int)(volume * 65535 / 100.0);
                SetVolume(scaledVolume);

                SoundPlayer.SoundLocation = $"{dirPath}\\{sound}.wav";
                SoundPlayer.Play();
            }
            catch (Exception ex)
            {
                logger.Log($"Error playing sound: {ex.Message}");
            }
        }

        private static void SetVolume(int volume)
        {
            // Ensure volume is within valid range [0, 65535]
            uint newVolume = (uint)(volume & 0xFFFF);
            waveOutSetVolume(IntPtr.Zero, newVolume | (newVolume << 16));
        }

        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
    }
}