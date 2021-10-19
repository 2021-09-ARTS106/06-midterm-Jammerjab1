using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBigCoin : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter (Collider other)
    {
        collectSound.Play();
        CoinSystem.theScore += 5;
        Destroy(gameObject);
    }
}
