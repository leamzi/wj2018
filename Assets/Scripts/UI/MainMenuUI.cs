using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
	public class MainMenuUI : MonoBehaviour
	{

		public GameObject InstructionPanel;
		public GameObject CreditsPanel;

		public Button PlayBtn;
		public Button InstructionsBtn;
		public Button CreditsBtn;
		public Button ExitBtn;

		private const string GameplayScene = "Gameplay";


		public void ClearAllPanels()
		{
			InstructionPanel.SetActive(false);
			CreditsPanel.SetActive(false);
		}

		private void Start()
		{
			PlayBtn.onClick.AddListener(PlayGame);
			InstructionsBtn.onClick.AddListener(ShowInstructions);
			CreditsBtn.onClick.AddListener(ShowCredits);
			ExitBtn.onClick.AddListener(ExitGame);
		}

		void ShowInstructions()
		{
			InstructionPanel.SetActive(true);
		}

		void ShowCredits()
		{
			CreditsPanel.SetActive(true);
		}

		void PlayGame()
		{
			SceneManager.LoadScene(GameplayScene);
		}

		void ExitGame()
		{
			Application.Quit();
		}
	}
}
