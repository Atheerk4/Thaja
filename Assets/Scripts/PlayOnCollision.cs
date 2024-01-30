using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume;
    
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(clip, volume);
        }
    }
}
