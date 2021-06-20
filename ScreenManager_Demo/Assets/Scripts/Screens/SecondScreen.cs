using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScreen : BaseScreen
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnPanelShow()
    {
        // before enabling the main container do all the calculation, web requests if using, loading and saving data.

        //TODO if required



        // overide the OnPanelShow to enable the main container
        base.OnPanelShow();
    }

    protected override void OnPanelHidden()
    {
        // before disabling save things and stuff if required

        //TODO if required



        // override the OnPanelHidden to disable the main Container
        base.OnPanelHidden();
    }

    public void ShowFirstScreen()
    {
        ScreenManger.GetInstance().OpenUI(typeof(FirstScreen));
    }
}
