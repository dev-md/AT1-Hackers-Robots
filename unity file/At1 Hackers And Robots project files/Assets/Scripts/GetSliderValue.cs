using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSliderValue : MonoBehaviour
{
    private Slider slider;
    private Text text;
    [SerializeField] private string mode = "Normal";

    private void Awake()
    {
        if(this.transform.parent.TryGetComponent(out Slider _slider))
        {
            slider = _slider;
            if(transform.TryGetComponent(out Text _text))
            {
                text = _text;
            }
        }
    }
    private void Update()
    {
        switch (mode)
        {
            case "Normal":
                text.text = slider.value.ToString("");
                break;

            case "F2":
                text.text = slider.value.ToString("F2");
                break;

            case "%%":
                text.text = (Mathf.Round(slider.value * 100f)).ToString("") + "%";
                break;

            default:
                text.text = slider.value.ToString("");
                break;

        }
    }
}
