using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {

    public int HP;
    public int score;

    public const int MAX_SCORE = 100;

    public PlayerData(){}

    public PlayerData(int hp,int score) {
        this.HP = hp;
        this.score = score;
    }
}
