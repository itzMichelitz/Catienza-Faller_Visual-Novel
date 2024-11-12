using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class View : MonoBehaviour
{
    //public TMP_Text scoreText;

    public Text playerDisplay;
    public Text rateDisplay;
    public Text FeedbackDisplay;

    private void Awake() {
        playerDisplay.text = ReadInput.input;
        rateDisplay.text = Rating.rate;
        FeedbackDisplay.text = Rating.Feedback;
    }

}
