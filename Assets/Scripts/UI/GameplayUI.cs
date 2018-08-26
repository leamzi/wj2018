using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class GameplayUI : MonoBehaviour
    {

        public Text GameModeText;


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
            GameModeText.text = string.Format("{0}", TimeToggle.GameMode);
        }

    }
}
