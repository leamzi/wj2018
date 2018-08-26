using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    PlayerRespawner respawner;

    private void Start()
    {
        respawner = GameObject.Find("PlayerRespawner").GetComponent<PlayerRespawner>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawner.SetPosition(this.transform.position);
        }
    }
}

