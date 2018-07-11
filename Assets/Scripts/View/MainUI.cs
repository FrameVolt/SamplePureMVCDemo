using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : Singleton<MainUI>
{
    [SerializeField]
    private BlueButtonView blueButtonView;
    [SerializeField]
    private ScoreView scoreView;

    public BlueButtonView BlueButtonView { get { return blueButtonView; } }
    public ScoreView ScoreView { get { return scoreView; } }
}
