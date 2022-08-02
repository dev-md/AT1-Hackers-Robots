using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnimetionMenu : MonoBehaviour
{
    private Animator animator;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if(TryGetComponent(out Animator anim) == true)
        {
            animator = anim;
        }
        else
        {
            Debug.Log("WHERE THE FUCK IS YOUR ANIMATOR");
        }
    }

    public void ToggleAnim()
    {
        if (animator.GetBool("ToggleMenu") == true)
        {
            animator.SetBool("ToggleMenu", false);
        }
        else
        {
            animator.SetBool("ToggleMenu", true);
        }
    }
}
