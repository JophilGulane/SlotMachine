using NAudio.Wave;

namespace SlotMachine
{
    public class AudioManager
    {
        private WaveOutEvent backgroundMusicPlayer;
        private WaveOutEvent soundEffectPlayer;

        public void PlayBackgroundMusic(string filePath)
        {
            StopBackgroundMusic(); // Stop any currently playing music

            var audioFile = new AudioFileReader(filePath);
            backgroundMusicPlayer = new WaveOutEvent();
            backgroundMusicPlayer.Init(audioFile);
            backgroundMusicPlayer.Play();
        }

        public void StopBackgroundMusic()
        {
            if (backgroundMusicPlayer != null)
            {
                backgroundMusicPlayer.Stop();
                backgroundMusicPlayer.Dispose();
                backgroundMusicPlayer = null;
            }
        }

        public void PlaySoundEffect(string filePath)
        {
            var audioFile = new AudioFileReader(filePath);
            soundEffectPlayer = new WaveOutEvent();
            soundEffectPlayer.Init(audioFile);
            soundEffectPlayer.Play();
            soundEffectPlayer.PlaybackStopped += (s, e) => audioFile.Dispose(); // Dispose after playback
        }
    }
}