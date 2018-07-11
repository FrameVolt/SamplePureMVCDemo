using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class PlayerProxy : Proxy {

    public new const string NAME = "PlayerProxy";

    public PlayerData PlayerData { get; set; }

    public PlayerProxy():base(NAME) {
        PlayerData = new PlayerData();
    }

    public void AddScore(int num) {

        if (PlayerData.score >= PlayerData.MAX_SCORE) {
            return;
        }
        PlayerData.score += num;
        if (PlayerData.score >= PlayerData.MAX_SCORE) {
            PlayerData.score = PlayerData.MAX_SCORE;
            SendNotification(DomainLogicEvents.MAX_SCORE_EVENT);
        }
    }
    public int GetScore() {
        return PlayerData.score;
    }
}
