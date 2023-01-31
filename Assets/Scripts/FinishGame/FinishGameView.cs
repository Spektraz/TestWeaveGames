using UnityEngine;

namespace FinishGame
{
    public class FinishGameView : MonoBehaviour
    {
        [SerializeField] private FinishGameModel m_viewModel = null;
        private FinishGameController m_controller = null;

        private void Start()
        {
            m_controller = new FinishGameController(m_viewModel);
            m_controller.Initialize();
        }

        private void OnDestroy()
        {
            if(m_controller == null)
                return;
            m_controller.Dispose();
        }
    }
}
