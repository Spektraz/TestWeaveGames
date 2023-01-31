using System;
using UnityEngine.SceneManagement;

namespace FinishGame
{
    public class FinishGameController
    {
        private FinishGameModel m_viewModel = null;
        public FinishGameController(FinishGameModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeButtons();
            InitializeName();
            SetResult();
            SetWin(ApplicationContainer.Instance.ResultGame.IsWin);
        }
        private void InitializeButtons()
        {
            m_viewModel.ExitToStartButton.onClick.AddListener(StartGame);
            m_viewModel.CongratulationButton.onClick.AddListener((() => SetWin(false)));
        }
        private void InitializeName()
        {
            m_viewModel.YourName.text = SaveManager.LoadString(GlobalConst.NameKey);
        }

        private void SetResult()
        {
            m_viewModel.AnswerGame.text = ApplicationContainer.Instance.ResultGame.WinCount.ToString();
            m_viewModel.TimeGame.text = ApplicationContainer.Instance.ResultGame.TimeCount;
            if (ApplicationContainer.Instance.ResultGame.WinCount >
                SaveManager.LoadInt(GlobalConst.BestPlayerNameKey))
            {
                SaveManager.Save(GlobalConst.BestPlayerNameKey, ApplicationContainer.Instance.ResultGame.WinCount);
            }
        }
        private void StartGame()
        {
            SceneManager.LoadScene(GlobalConst.SceneStartGame);
        }

        private void SetWin(bool state)
        {
            m_viewModel.CongratulationObject.SetActive(state);
        }
        private void DisposeButtons()
        {
            m_viewModel.ExitToStartButton.onClick.RemoveAllListeners();
            m_viewModel.CongratulationButton.onClick.RemoveAllListeners();
        }
        public void Dispose()
        {
            DisposeButtons();
        }
    }
}
