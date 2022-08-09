using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSytemHandler : MonoBehaviour
{
    EventSystem _eventSystem;
    private void Awake()
    {
        _eventSystem = EventSystem.current;
    }

    public void ChangeSelectedButton(GameObject _gameObj)
    {
        _eventSystem.SetSelectedGameObject(_gameObj);
    }
}
