using GameCore;
using Interactable;
using UnityEngine;

namespace Player
{
    
    public class PlayerCollisions : MonoBehaviour
    {
        MusicPlayer musicplayer;

        public Inventory inventory;
        public PlayerRespawner respawner;
        Transform player;

        private void Awake()
        {
            player = this.transform;
        }

        private void Start()
        {
            
            musicplayer = GameObject.Find("Music Player").GetComponent<MusicPlayer>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.CompareTag("Collectible"))
            {
                var collideCollectable = other.GetComponent<Collectible>();
                Debug.Log("objeto agarra2");
                musicplayer.PlayCollectible();
                //if (inventory.itemList.Find((collectable => collectable.ID == collideCollectable.ID)))
                

                Collectible newItem = new Collectible(collideCollectable.objectName, collideCollectable.ID);

                inventory.itemList.Add(newItem);
                inventory.UpdateAmount();
                Debug.Log("agarra el item");
              

                other.gameObject.SetActive(false);
            }


            if (other.gameObject.CompareTag("Hazard"))
            {
                player.gameObject.SetActive(false);
                musicplayer.PlayDie();
                Invoke("Die",.5f);
                //

                Debug.Log("hajshdk");
            }

            if (other.gameObject.CompareTag("WinLevel"))
            {
                if (inventory.CheckInvetoryFull())
                {
                musicplayer.PlayCheckpoint();
                other.gameObject.GetComponent<GameSceneLoader>(). LoadNextLevel();

                }
            }
        }

        public void Die()
        {
            player.gameObject.SetActive(true);
            if (respawner != null) respawner.Respawn();
            
        }
    }
}
