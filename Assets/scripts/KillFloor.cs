using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    public AudioSource tickSource;

    void Start () {

        tickSource = GetComponent<AudioSource> ();
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawn_point.transform.position;
        tickSource.Play ();
    }
}
