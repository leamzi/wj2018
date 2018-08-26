using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBar : MonoBehaviour {

    public Transform[] bars = new Transform[5];

    public void UpdateBars(int i)
    {
        for (int n = 0; n < bars.Length; n++)
        {
            bars[n].gameObject.SetActive(false);
        }

        bars[i-1].gameObject.SetActive(true);
    }
}
