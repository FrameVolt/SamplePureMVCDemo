using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System;

public class BlueButtonMediator : Mediator{


    private PlayerProxy playerProxy = null;
    public new const string NAME = "BlueButtonMediator";

    public BlueButtonView BlueButtonView {
        get {
            return (BlueButtonView)base.ViewComponent;
        }
    }

    public BlueButtonMediator(BlueButtonView view) : base(NAME, view){
        view.AddScoreButton.onClick.AddListener(() => { SendNotification(DomainLogicEvents.ADD_SCORE_EVENT); });
    }

    public override void OnRegister()
    {
        base.OnRegister();
        playerProxy = Facade.RetrieveProxy(PlayerProxy.NAME) as PlayerProxy;
        if (null == playerProxy)
            throw new Exception(PlayerProxy.NAME + "is null.");
        BlueButtonView.Active();
    }


    public override IList<string> ListNotificationInterests()
    {
        List<string> interestList = new List<string>();
        interestList.Add(DomainLogicEvents.MAX_SCORE_EVENT);
        return interestList;
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case DomainLogicEvents.MAX_SCORE_EVENT:
                BlueButtonView.StopActive();
                break;

        }
    }


}