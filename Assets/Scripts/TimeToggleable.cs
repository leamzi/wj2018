using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggleable : MonoBehaviour {
    public bool status = true;
    public GameObject presentToggle;
    public GameObject pastToggle;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnEnable()
    {
        TimeToggle.onPress += Swap;
    }

    private void OnDisable()
    {
        TimeToggle.onPress -= Swap;
    }

    void Swap()
    {
        if (status)
        {
            status = false;
            pastToggle.SetActive(true);
            presentToggle.SetActive(false);
        }
        else
        {
            status = true;
            pastToggle.SetActive(false);
            presentToggle.SetActive(true);
        }
    }
 }
