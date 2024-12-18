using NAudio.Wave;
using System;

namespace SlotMachine
{
    public class AudioManager
    {
        private WaveOutEvent backgroundMusicPlayer;
        private AudioFileReader backgroundAudioFile;

        /// <summary>
        /// Plays the background music and allows volume control.
        /// </summary>
        /// <param name="filePath">Path to the audio file.</param>
        public void PlayBackgroundMusic(string filePath)
        {
            try
            {
                StopBackgroundMusic(); // Ensure any currently playing music is stopped

                backgroundAudioFile = new AudioFileReader(filePath);
                backgroundMusicPlayer = new WaveOutEvent();
                backgroundMusicPlayer.Init(backgroundAudioFile);
                backgroundMusicPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing background music: {ex.Message}");
            }
        }

        /// <summary>
        /// Stops the background music.
        /// </summary>
        public void StopBackgroundMusic()
        {
            try
            {
                if (backgroundMusicPlayer != null)
                {
                    backgroundMusicPlayer.Stop();
                    backgroundMusicPlayer.Dispose();
                    backgroundMusicPlayer = null;
                }

                if (backgroundAudioFile != null)
                {
                    backgroundAudioFile.Dispose();
                    backgroundAudioFile = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error stopping background music: {ex.Message}");
            }
        }

        /// <summary>
        /// Sets the volume of the background music.
        /// </summary>
        /// <param name="volume">Volume level (0.0 to 1.0).</param>
        public void SetBackgroundMusicVolume(float volume)
        {
            try
            {
                if (backgroundAudioFile != null)
                {
                    backgroundAudioFile.Volume = Math.Clamp(volume, 0.0f, 1.0f); // Ensure volume is between 0.0 and 1.0
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting background music volume: {ex.Message}");
            }
        }

        /// <summary>
        /// Plays a sound effect.
        /// </summary>
        /// <param name="filePath">Path to the sound effect file.</param>
        public void PlaySoundEffect(string filePath)
        {
            try
            {
                var audioFile = new AudioFileReader(filePath);
                using (var soundEffectPlayer = new WaveOutEvent())
                {
                    soundEffectPlayer.Init(audioFile);
                    soundEffectPlayer.Play();
                    soundEffectPlayer.PlaybackStopped += (s, e) => audioFile.Dispose(); // Dispose after playback
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound effect: {ex.Message}");
            }
        }
    }
}
