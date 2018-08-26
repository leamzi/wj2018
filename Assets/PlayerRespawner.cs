using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawner : MonoBehaviour {

    Vector2 respawnPosition;
    public GameObject player;

    void Start()
    {
        respawnPosition = GameObject.Find("InitialSpawner").transform.position;
        player = Instantiate(player, respawnPosition, Quaternion.identity);
       /// Respawn();
    }

    public void Respawn()
    {
        player.transform.position = respawnPosition;
    }

    public void SetPosition(Vector2 trans)
    {
        respawnPosition = trans;
    }
}
