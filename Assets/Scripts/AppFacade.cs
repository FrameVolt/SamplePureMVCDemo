using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class AppFacade : Facade {

    public new static IFacade Instance
    {
        get
        {
            if (null == m_instance)
            {
                lock (m_staticSyncRoot)
                {
                    if (null == m_instance)
                    {
                        Debug.Log("构造Facade,此处会自动构造View、Controller和Model");
                        m_instance = new AppFacade();
                    }
                }
            }
            return m_instance;
        }
    }

    public const string START_UP = "startUp";


    public void StartUp() {
        SendNotification(START_UP);
    }

    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(START_UP, typeof(StartupCommand));
    }
    protected override void InitializeFacade()
    {
        base.InitializeFacade();
    }

    protected override void InitializeModel()
    {
        base.InitializeModel();

    }

    protected override void InitializeView()
    {
        base.InitializeView();
    }
}
