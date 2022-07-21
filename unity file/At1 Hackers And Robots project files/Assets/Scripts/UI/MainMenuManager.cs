using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private int childCount;
    private List<GameObject> listMenu = new List<GameObject>();
    private Animator _anim;

    private static readonly int mainMenuAnim = Animator.StringToHash("Main Menu");

    private void Awake()
    {
        _anim = GetComponent<Animator>();
                
        if (transform.childCount > 0)
        {
            childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                //Debug.Log(transform.GetChild(i).gameObject);
                if (transform.GetChild(i).gameObject.GetComponent<MenuNav>() != null)
                {
                    listMenu.Add(transform.GetChild(i).gameObject);
                }
            }
            _anim.CrossFade(mainMenuAnim, 0, 0);

        }
    }
}
