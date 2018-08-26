using GameCore;
using UnityEngine;

namespace Player
{
    class PlayerInput : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                MakeSwap();
            }
        }

        private void MakeSwap()
        {
            var currentMode = TimeToggle.GameMode;

            if(currentMode == GameMode.Past)
                TimeToggle.SwitchGameMode(GameMode.Present);
            else
                TimeToggle.SwitchGameMode(GameMode.Past);

        }
    }
}
