using UnityEngine;

namespace Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioEventAutoplay : AudioEventBase
    {
        private AudioSource _audioSource;
    
        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void Start()
        {
            Play(_audioSource);
        }
    }
}

