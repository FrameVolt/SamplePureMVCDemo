using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System;

public class ScoreMediator : Mediator {

    private PlayerProxy playerProxy = null;
    public new const string NAME = "ScoreMediator";

    public ScoreView ScoreView
    {
        get { return (ScoreView)base.ViewComponent; }
    }

    public ScoreMediator(ScoreView view) : base(NAME , view)
    {
        
    }
    public override void OnRegister()
    {
        base.OnRegister();
        playerProxy = Facade.RetrieveProxy(PlayerProxy.NAME) as PlayerProxy;
        if (null == playerProxy)
            throw new Exception(PlayerProxy.NAME + "is null.");

        ScoreView.DisplayScore(playerProxy.GetScore());
    }
    public override IList<string> ListNotificationInterests()
    {
        List<string> interestList = new List<string>();
        interestList.Add(DomainLogicEvents.ADD_SCORE_EVENT);

        return interestList;
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case DomainLogicEvents.ADD_SCORE_EVENT:
                playerProxy.AddScore(10);
                ScoreView.DisplayScore(playerProxy.GetScore());
                break;

        }
    }
}
