using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips = new Dictionary<AudioClipName, AudioClip>();

    public static void Initialize(AudioSource source)
    {
        audioSource = source;
        audioClips.Add(AudioClipName.AsteroidHit, Resources.Load<AudioClip>("asteroidExplode"));
        audioClips.Add(AudioClipName.PlayerDeath, Resources.Load<AudioClip>("shipExplode"));
        audioClips.Add(AudioClipName.PlayerShot, Resources.Load<AudioClip>("laserShot1"));
    }
	
	public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
    }
}
