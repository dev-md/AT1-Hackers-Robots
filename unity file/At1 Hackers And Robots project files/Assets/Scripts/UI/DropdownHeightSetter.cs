using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropdownHeightSetter : MonoBehaviour
{
    private Scrollbar scrBar;
    private RectTransform xyPos;
    private float yHeight;

    private void Awake()
    {
        if (TryGetComponent(out RectTransform _xyPos))
        {
            xyPos = _xyPos;
        }
        scrBar = GetComponentInChildren<Scrollbar>();

    }

    private void Update()
    {
        if((scrBar != null)&&(xyPos != null))
        {
            if(scrBar.IsActive() != false)
            {
                yHeight = xyPos.rect.height + 20;
                xyPos.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, yHeight);
            }
        }
    }
}