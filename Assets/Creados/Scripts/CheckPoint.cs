using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    Respawner respawner;

    private void Start()
    {
        respawner = GameObject.Find("Respawner").GetComponent<Respawner>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawner.SetPosition(this.transform.position);
        }
    }
}

