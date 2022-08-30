using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetResolutionList : MonoBehaviour
{
    private List<string> resList = new List<string>();
    private Text resText;
    private Dropdown boxDrop;

    [SerializeField] private Text noDropText;
    void Awake()
    {
        Resolution[] resolutions = Screen.resolutions; //all resolution

        if(resolutions.Length == 1)
        {
            noDropText.text = (resolutions[0].width + "x" + resolutions[0].height + ":  " + resolutions[0].refreshRate + "Hz: (Can't Change)");
            noDropText.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else if (resolutions.Length == 0)
        {
            noDropText.text = ("Can't Change Screen in this mode.");
            noDropText.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }

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
