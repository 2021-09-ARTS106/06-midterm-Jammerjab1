using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource collectSound;


    void OnTriggerEnter (Collider other)
    {
        collectSound.Play();
        CoinSystem.theScore += 1;
        Destroy(gameObject);
        
    }
    
}
