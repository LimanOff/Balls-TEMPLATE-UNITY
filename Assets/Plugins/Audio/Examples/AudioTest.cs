using Plugins.Audio.Core;
using Plugins.Audio.Utils;
using UnityEngine;

namespace Plugins.Audio.Examples
{
    public class AudioTest : MonoBehaviour
    {
        [SerializeField] private SourceAudio musicUnitySource;
        [SerializeField] private SourceAudio soundUnitySource;
        [SerializeField] private AudioDataProperty _musicClip;
        [SerializeField] private AudioDataProperty _soundClip;

        private void Start()
        {
            musicUnitySource.Play(_musicClip);
        }

        public void PlaySound()
        {
            soundUnitySource.Play(_soundClip);
        }

        public void SetGlobalAudioVolumeJS(float value)
        {
            WebAudio.Volume = value;
        }
    }
}
