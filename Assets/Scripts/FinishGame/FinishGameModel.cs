using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FinishGame
{
    public class FinishGameModel : MonoBehaviour
    {
        [Header("Button Main")]
        [SerializeField] private Button m_exitToStartButton = null;

        [Header("Time Game")] 
        [SerializeField] private TextMeshProUGUI m_timeGame = null;
        
        [Header("Mistake Game")] 
        [SerializeField] private TextMeshProUGUI m_answerGame = null;
        
        [Header("YourName")]
        [SerializeField] private TextMeshProUGUI m_yourName = null;
        [Header("Congratulation")]
        [SerializeField] private GameObject m_congratulationObject = null;

        [SerializeField] private Button m_congratulationButton = null;
        public GameObject CongratulationObject => m_congratulationObject;
        public Button ExitToStartButton => m_exitToStartButton;
        public Button CongratulationButton => m_congratulationButton;
        public TextMeshProUGUI TimeGame => m_timeGame;
        public TextMeshProUGUI AnswerGame => m_answerGame;
        public TextMeshProUGUI YourName => m_yourName;
    }
}
