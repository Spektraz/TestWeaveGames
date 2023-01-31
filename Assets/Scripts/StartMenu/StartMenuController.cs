using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StartMenu
{
    public class StartMenuController
    {
        private StartMenuModel m_viewModel = null;
        public StartMenuController(StartMenuModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeButtons();
            InitializeBestPlayer();
        }
        private void InitializeButtons()
        {
            m_viewModel.CloseButton.onClick.AddListener(CloseGame);
            m_viewModel.StartButton.onClick.AddListener(StartGame);
        }

        private void InitializeBestPlayer()
        {
            m_viewModel.BestPlayer.text = SaveManager.LoadInt(GlobalConst.BestPlayerNameKey).ToString();
        }
        private void DisposeButtons()
        {
            m_viewModel.CloseButton.onClick.RemoveListener(CloseGame);
            m_viewModel.CloseButton.onClick.RemoveListener(StartGame);
        }
        public void Dispose()
        {
            DisposeButtons();
        }
        private void StartGame()
        {
            SceneManager.LoadScene(GlobalConst.SceneMainGame);
        }
        private void CloseGame()
        {
            Application.Quit();
        }
        
    }
}
