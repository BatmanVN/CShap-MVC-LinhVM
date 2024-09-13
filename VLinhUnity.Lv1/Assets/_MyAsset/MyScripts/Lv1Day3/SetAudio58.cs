using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAudio58 : MonoBehaviour
{
    AudioSource music;
    public float time;
    private void Start()
    {
        music = GetComponent<AudioSource>();
        music.clip = Resources.Load<AudioClip>("Alone");
        AudioPlay();
    }

    void AudioPlay()
    {
        //music.Play();
        music.PlayDelayed(time);
        Invoke("AudioStop", time*5);
    }
    void AudioStop()
    {
        music.Stop();
        Debug.Log("STOPPED");
    }

}
