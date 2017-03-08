using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip hitTargetSound;

    void Start ()
    {
        audioSource = GetComponent <AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "projectile")
        {
            audioSource.PlayOneShot(hitTargetSound);
        }
    }
}
