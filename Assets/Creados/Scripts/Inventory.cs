using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    List<Collectible> itemList = new List<Collectible>();



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            var collideCollectable = other.GetComponent<Collectible>();
            Debug.Log("objeto agarra2");

            if(itemList.Find(collectable => collectable.ID != collideCollectable.ID))    {

                Collectible newItem = new Collectible(collideCollectable.objectName, collideCollectable.ID);

                itemList.Add(newItem);
            }

            other.gameObject.SetActive(false);
        }

    }


}
