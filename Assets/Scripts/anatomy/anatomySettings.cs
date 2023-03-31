using System.Collections.Generic;
using UnityEngine;


namespace anatomy.levelone
{
    public enum  difficulty
    {
        EASY,
        NORMAL,
        HARD
    }

    [CreateAssetMenu(fileName = "anatomySettings", menuName = "anatomy/anatomySettings")]
    public class anatomySettings : ScriptableObject
    {
        [Header("Game Score")]
        public int score = 0;
        public int highestScore = 8;
        public string[] resultText = new string[3];


        [Header("Error System")]
        public int errors = 0;

        [Header("Game Start")]
        [Tooltip("Sets the state of the Game")]
        public bool isStarted = false;


        [Header("Platform Rotation")]
        [Tooltip("Set the rotation of the snap points platforms")]
        [Range(0.0f, 100.0f)]
        public float rotSpeed = 20.0f;

        [Header("Difficulty")]
        [Tooltip("Sets the difficulty")]
        public difficulty difficulty;

        


        [Header("Timer")]
        [Tooltip("Sets the value for the timer")]
        [Range(0.0f, 300.0f)]
        public float timer;

        public bool timerRunning = false;

        [Tooltip("Increase the reduction Speed of Timer")]
        [Range(0.0f, 4.0f)]
        public float timerReduction = 0.0f;


        [Header("WaitingTime DropDown")]
        [Tooltip("The time to wait to verify if the object was dropped in right spot")]
        [Range(2.0f, 10.0f)]
        public float waitingTime = 2.0f;


        [Header("Number of Retry")]
        [Tooltip("Keeps Track of the number of trials")]
        public int retries = 0;
        

    }
}
