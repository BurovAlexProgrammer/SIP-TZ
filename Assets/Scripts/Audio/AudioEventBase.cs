using UnityEngine;

namespace Audio
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class AudioEventBase : MonoBehaviour, IAudioEvent
    {
        [SerializeField] protected AudioClip _audioClip;
        
        public virtual void Play(AudioSource audioSource)
        {
            audioSource.clip = _audioClip;
            audioSource.volume = Random.Range(0.9f, 1.1f);
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            audioSource.Play();
        }
    }
}
