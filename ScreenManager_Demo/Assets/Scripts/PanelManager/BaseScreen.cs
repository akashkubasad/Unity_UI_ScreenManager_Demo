using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseScreen : UIBehaviour
{
    // _mainObject is a child of the main GameObject in the scene.
    public GameObject _mainContent;


    protected override void Awake()
    {
        base.Awake();
    }

    protected virtual void OnPanelShow()
    {
        if (_mainContent == null)
            return;

        _mainContent?.SetActive(true);
    }

    protected virtual void OnPanelHidden()
    {
        if (_mainContent == null)
            return;

        _mainContent?.SetActive(false);
    }

    public void ShowPanel()
    {
        OnPanelShow();
    }

    public void HidePanel()
    {
        OnPanelHidden();
    }

}

