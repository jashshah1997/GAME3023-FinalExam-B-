using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> footstepSoundClips;

    [SerializeField]
    private AudioSource bellSounClip;
    private bool m_bells_enabled = false;

    [SerializeField]
    private AudioSource soundSource;

    [SerializeField] 
    private float pitchVariance = 0.15f;

    void PlayRandomFootsep()
    {
        soundSource.clip = footstepSoundClips[Random.Range(0, footstepSoundClips.Count)];
        soundSource.pitch = 1.0f + Random.Range(-pitchVariance, pitchVariance);
        soundSource.Play();

        if (m_bells_enabled)
            bellSounClip.Play();
    }

    public void SetBellsActive(bool flag)
    {
        m_bells_enabled = flag;
    }

}
