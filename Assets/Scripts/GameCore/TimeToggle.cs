namespace GameCore
{
    public static class TimeToggle
    {
        public static GameMode GameMode;

        public delegate void SwapButton();
        public static event SwapButton OnPress;

        public static void SwitchGameMode(GameMode mode)
        {
            GameMode = mode;
            OnPress();
        }
    }
}