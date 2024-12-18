using NAudio.Wave;

public class AudioManager
{
    private WaveOutEvent backgroundMusicPlayer;
    private WaveOutEvent soundEffectPlayer;

    public void PlayBackgroundMusic(string filePath)
    {
        if (backgroundMusicPlayer != null)
        {
            backgroundMusicPlayer.Stop();
            backgroundMusicPlayer.Dispose();
        }

        var audioFile = new AudioFileReader(filePath);
        backgroundMusicPlayer = new WaveOutEvent();
        backgroundMusicPlayer.Init(audioFile);
        backgroundMusicPlayer.Play();
    }

    public void PlaySoundEffect(string filePath)
    {
        var audioFile = new AudioFileReader(filePath);
        soundEffectPlayer = new WaveOutEvent();
        soundEffectPlayer.Init(audioFile);
        soundEffectPlayer.Play();
    }
}