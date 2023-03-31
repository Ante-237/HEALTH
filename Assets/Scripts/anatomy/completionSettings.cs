using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace anatomy.levelone
{
    [CreateAssetMenu(fileName = "completionSettings", menuName = "anatomy/completionSettings")]
    public class completionSettings : ScriptableObject
    {

        public bool activeStats = false;

        public Sprite[] completionStatus = new Sprite[2];
        

        public enum status
        {
            DEFAULT,
            COMPLETE
        }

        public List<String> bodyParts  = new List<string> (8);

        public status[] state = new status[8];

        public List<String> completionText = new List<string> (2);


       

    }

}
