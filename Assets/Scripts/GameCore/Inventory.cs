using System.Collections.Generic;
using Interactable;
using UnityEngine;


    public class Inventory : MonoBehaviour {

        public int totalItems = 5;
        public List<Collectible> itemList = new List<Collectible>();
        public CanvasBar bars;
        public void UpdateAmount()
         {
            bars.UpdateBars(itemList.Count);
            Debug.Log(itemList.Count);
            Debug.Log("asdasd");
        }

        public bool CheckInvetoryFull()
        {
        Debug.Log(itemList.Count);
            if (itemList.Count == totalItems)
            {
                return true;
            }
            else
                return false;
            }
    }

