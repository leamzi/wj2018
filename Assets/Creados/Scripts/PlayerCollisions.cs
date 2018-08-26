using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    Inventory inventory;
    PlayerRespawner respawner;
    private void Start()
    {
        respawner = GameObject.Find("PlayerRespawner").GetComponent<PlayerRespawner>();
        inventory = GetComponent<Inventory>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Collectible"))
        {
            var collideCollectable = other.GetComponent<Collectible>();
            Debug.Log("objeto agarra2");

            if (inventory.itemList.Find(collectable => collectable.ID != collideCollectable.ID))
            {

                Collectible newItem = new Collectible(collideCollectable.objectName, collideCollectable.ID);

                inventory.itemList.Add(newItem);
            }

            other.gameObject.SetActive(false);
        }


        if (other.gameObject.CompareTag("Hazard"))
        {
            Die();
        }
    }

    public void Die()
    {
        this.gameObject.SetActive(false);
        respawner.Respawn();
        this.gameObject.SetActive(true);
    }
}
