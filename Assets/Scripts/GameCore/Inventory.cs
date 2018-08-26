using System.Collections.Generic;
using Interactable;
using UnityEngine;


    public class Inventory : MonoBehaviour {

        public List<Collectible> itemList = new List<Collectible>();
        public CanvasBar bars;
        public void UpdateAmount()
        {
            bars.UpdateBars(itemList.Count);
            Debug.Log(itemList.Count);
            Debug.Log("asdasd");
        }
    }

