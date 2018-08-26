using Player;
using UnityEngine;

namespace Interactable
{
    public class CheckPoint : MonoBehaviour
    {
        PlayerRespawner respawner;
        MusicPlayer musicplayer;

        private void Start()
        {
            respawner = GameObject.Find("PlayerRespawner").GetComponent<PlayerRespawner>();
            musicplayer = GameObject.Find("Music Player").GetComponent<MusicPlayer>();

        }


        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                musicplayer.PlayCheckpoint();
                respawner.SetPosition(this.transform.position);
            }
        }
    }
}

