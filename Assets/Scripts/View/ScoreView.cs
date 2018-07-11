using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour {
    [SerializeField]
    private Text ScoreText;

    public void DisplayScore(int scoreNum) {
        ScoreText.text = scoreNum.ToString();
    }
}
