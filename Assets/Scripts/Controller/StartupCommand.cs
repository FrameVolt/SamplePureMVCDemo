using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupCommand : SimpleCommand {

    public override void Execute(INotification notification)
    {
        PlayerProxy playerProxy = new PlayerProxy();
        Facade.RegisterProxy(playerProxy);

        Facade.RegisterMediator(new ScoreMediator(MainUI.Instance.ScoreView));
        Facade.RegisterMediator(new BlueButtonMediator(MainUI.Instance.BlueButtonView));
    }
}
