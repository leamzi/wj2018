using UnityEngine;

namespace Interactable
{
    public class Collectible : MonoBehaviour {


        public string objectName;
        public int ID;

        public Collectible(string newName, int newID)
        {
            objectName = newName;
            ID = newID;
        }

    
    }
}
