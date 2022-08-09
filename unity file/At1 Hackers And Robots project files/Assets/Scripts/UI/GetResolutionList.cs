using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetResolutionList : MonoBehaviour
{
    private List<string> resList = new List<string>();
    private Text resText;
    private Dropdown boxDrop;
    void Awake()
    {
        Resolution[] resolutions = Screen.resolutions; //all resolution
        foreach (Resolution res in resolutions)
        {
            resList.Add(res.width + "x" + res.height + ":  " + res.refreshRate + "Hz");
            //Debug.Log(res.width + "x" + res.height + ":  " + res.refreshRate + "Hz");
        }

        if (TryGetComponent(out Dropdown dropdown))
        {
            boxDrop = dropdown;

            //Clear the old options of the Dropdown menu
            boxDrop.ClearOptions();
            boxDrop.AddOptions(resList);
            boxDrop.value = resList.Count;
        }
        else
        {
            Debug.Log("WHERES YOUR DROPDOWN");
        }

    }
}
