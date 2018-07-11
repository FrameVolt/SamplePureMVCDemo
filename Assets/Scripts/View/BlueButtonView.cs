using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BlueButtonView : MonoBehaviour {
    [SerializeField]
    private Button addScoreButton;

    public Button AddScoreButton {
        get { return addScoreButton; }
    }

    public void StopActive() {
        addScoreButton.interactable = false;
    }

    public void Active()
    {
        addScoreButton.interactable = true;
    }
}
