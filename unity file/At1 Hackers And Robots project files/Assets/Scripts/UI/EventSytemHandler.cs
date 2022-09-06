using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSytemHandler : MonoBehaviour
{
    private EventSystem _eventSystem;
    private BaseInputModule _inputModule;
    private void Awake()
    {
        _eventSystem = EventSystem.current;
        _inputModule = GetComponent<BaseInputModule>();
    }

    public void ChangeSelectedButton(GameObject _gameObj)
    {
        _eventSystem.SetSelectedGameObject(_gameObj);
        StartCoroutine(ScrTimer());
    }
    private IEnumerator ScrTimer()
    {
        _inputModule.enabled = false;
        yield return new WaitForSeconds(0.25f);
        _inputModule.enabled = true;
    }
}
