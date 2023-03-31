using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour
{

   public Animator animator;


   public void fadeIn()
    {
        animator.SetBool("fadeout", false);
        animator.SetBool("fadein", true);
    }

    public void fadeOut()
    {
        animator.SetBool("fadein", false);
        animator.SetBool("fadeout", true);
    }

}
