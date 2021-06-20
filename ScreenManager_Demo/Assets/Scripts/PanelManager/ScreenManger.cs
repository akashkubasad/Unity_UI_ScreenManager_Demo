using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class ScreenManger : MonoBehaviour
{
    private static ScreenManger _instance = null;

    private BaseScreen[] _screens = new BaseScreen[] { };
    private Dictionary<string, BaseScreen> _allScreens = new Dictionary<string, BaseScreen>();
    private BaseScreen previousScreen = null , _currentScreen = null;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        FindAllPanels();
    }


    public static ScreenManger GetInstance()
    {
        return _instance;
    }

    private void FindAllPanels()
    {
        _screens = FindObjectsOfType<BaseScreen>().ToArray();

        Debug.Log("No of Screens : "+_screens.Length);
        foreach(BaseScreen baseScreen in _screens)
        {
            _allScreens.Add(baseScreen.GetType().Name, baseScreen);
            Debug.Log(baseScreen.GetType().Name);
        }
    }

    private BaseScreen GetPanel(string type)
    {
        if(_allScreens.TryGetValue(type,out BaseScreen screen))
        {
            return screen;   
        }
        else
        {
            return null;
        }
    }

    public void OpenUI(Type type)
    {
        previousScreen = _currentScreen;
        RemovePreviousScreen();

        _currentScreen = GetPanel(type.Name);

        if (_currentScreen == null)
        {
            Debug.Log("SCREEN NOT REGISTERED "+ type.Name);
            return;
        }

        _currentScreen.ShowPanel();
    }

    public void RemovePreviousScreen()
    {
        previousScreen?.HidePanel();
    }


    //Temporary for teting purpose
    public void TestPanel()
    {
        OpenUI(typeof(FirstScreen));
    }

}
