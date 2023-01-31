namespace System
{
    public class ApplicationContainer : Singleton<ApplicationContainer>
    {
        private ResultGame m_resultGame = null;
        private EventHolder m_eventHolder = null;
        private FileManager m_fileManager = null;
        public EventHolder EventHolder
        {
            get { return m_eventHolder; }
        }
        public FileManager FileManager
        {
            get { return m_fileManager; }
        }
        public ResultGame ResultGame
        {
            get { return m_resultGame; }
        }
        private void Awake()
        {
            Construct(new EventHolder(), new ResultGame());
        }
        private void Construct(
            EventHolder eventHolder,
             ResultGame resultGame
        )
        {
            m_eventHolder = eventHolder;
            m_resultGame = resultGame;
        }
    }
}