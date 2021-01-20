using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    AudioSource hitSound;

    private void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        hitSound.Play();
        // AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
