using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class GameplayUI : MonoBehaviour
    {
        
        public GameObject PastText;
        public GameObject PresentText;

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
                    PastText.SetActive(false);
                    PresentText.SetActive(true);
                    break;
                case GameMode.Past:
                    PastText.SetActive(true);
                    PresentText.SetActive(false);
                    break;
            }
        }

    }
}
