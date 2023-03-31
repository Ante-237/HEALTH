using Oculus.Interaction;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace anatomy.levelone
{
    public class dropPoints: OVRGrabbable
    {
        public completionSettings completionSettings;
        public anatomySettings settings;
        private bool ranOnce = true;

        
        /// <summary>
        /// method gets the tag linked to the current collider object
        /// compares it with the tag of the object it triggers.
        /// if they are equal, it uses a for loop to check if the body parts
        /// equals to the present and updates the status.
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (transform.CompareTag(other.transform.tag))
            {
               
                for(int i = 0; i < completionSettings.bodyParts.Count; i++)
                {
                    if (completionSettings.bodyParts[i].Equals(other.transform.tag)){
                       
                        StartCoroutine(CompleteStatus(i));                 
                        break;
                    }else if(ranOnce)
                    {
                        settings.errors += 1;
                        //completionSettings.activeStats = false;
                        ranOnce = false;
                    }
                }
            }
            else
            {
                
            }
        }


        /// <summary>
        /// sets the status only after three seconds if the body is allowed
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IEnumerator CompleteStatus(int index)
        {
            yield return new WaitForSeconds(settings.waitingTime);
            if (completionSettings.activeStats)
            {
               completionSettings.state[index] = completionSettings.status.COMPLETE;
               completionSettings.activeStats = false;
            }
        }

        public void grabbingNow()
        {
            completionSettings.activeStats = false;
            
        }

        public void notGrabbing()
        {
            completionSettings.activeStats = true;
           
        }
    }
}
