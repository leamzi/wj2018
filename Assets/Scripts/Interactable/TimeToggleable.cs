using GameCore;
using UnityEngine;

namespace Interactable
{
    public class TimeToggleable : MonoBehaviour {

        public GameObject ObjectInPresent;
        public GameObject ObjectInPast;

        public void Start()
        {
            Swap();
        }

        public void OnEnable()
        {
            TimeToggle.OnPress += Swap;
        }

        public void OnDisable()
        {
            TimeToggle.OnPress -= Swap;
        }

        void Swap()
        {
            switch (TimeToggle.GameMode)
            {
                case GameMode.Past:
                    SetToPast();
                    break;
                case GameMode.Present:
                    SetToPresent();
                    break;
            }
        }
        

        private void SetToPresent()
        {
            ObjectInPast.SetActive(false);
            ObjectInPresent.SetActive(true);
        }

        private void SetToPast()
        {
            ObjectInPast.SetActive(true);
            ObjectInPresent.SetActive(false);
        }
    }
}

