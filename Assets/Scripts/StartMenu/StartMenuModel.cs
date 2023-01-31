using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace StartMenu
{
    public class StartMenuModel : MonoBehaviour
    {
        [Header("Button Main")]
        [SerializeField] private Button m_closeButton = null;
        [SerializeField] private Button m_startButton = null;

        [Header("Best Player")] 
        [SerializeField] private TextMeshProUGUI m_bestPlayer = null;
        
        
        public Button CloseButton => m_closeButton;
        public Button StartButton => m_startButton;
        public TextMeshProUGUI BestPlayer => m_bestPlayer;
        
    }
}
