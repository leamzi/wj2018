using GameCore;
using UnityEngine;

namespace UI
{
    public class GameplayUI : MonoBehaviour
    {
        
        public GameObject PastText;
        public GameObject PresentText;

        public ParticleSystem RainVfx;
        public ParticleSystem RainVfx02;

        public void Start()
        {
            UpdateMode();
        }

        public void OnEnable()
        {
            TimeToggle.OnPress += UpdateMode;
        }

        public void OnDisable()
        {
            TimeToggle.OnPress -= UpdateMode;
        }

        void UpdateMode()
        {
            switch (TimeToggle.GameMode)
            {
                case GameMode.Present:
                    SetPresentUI();
                    break;
                case GameMode.Past:
                    SetPastUI();
                    break;
            }
        }

        private void SetPresentUI()
        {
            PastText.SetActive(false);
            PresentText.SetActive(true);
            
            RainVfx.Stop();
            RainVfx.Clear();
            RainVfx02.Stop();
            RainVfx02.Clear();
        }

        private void SetPastUI()
        {
            PastText.SetActive(true);
            PresentText.SetActive(false);
            
            RainVfx.Play();
            RainVfx02.Play();
        }
    }
}
