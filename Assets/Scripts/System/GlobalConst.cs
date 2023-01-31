using UnityEngine;

namespace System
{
    public class GlobalConst 
    {
        [Header("Save")]
        public const string QuestionAnswerKey = "QuestionAnswer";
        public const string BestPlayerNameKey = "BestPlayer";
        public const string NameKey = "Name";
        public const string SoundKey = "Sound";
        public const string QuestionKey = "Question";
        
        public const string SceneMainGame = "mainGame";
        public const string SceneFinishGame = "finishGame";
        public const string SceneStartGame = "SampleScene";
        public const string DefaultName = "YourName";
        public const string QuestionItems = "QuestionItems";
        [Header("Time")] 
        public const int TimeDuration = 3;

        [Header("Count mistake")]
        public const int CountMistake = 3;

        public enum VariantAnswer
        {
            Unset = 0,
            FirstVar = 1,
            SecondVar = 2,
            ThirdVar = 3,
            FourthVar = 4
        }
    }
}
