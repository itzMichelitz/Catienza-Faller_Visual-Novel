using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rating : MonoBehaviour
{
    public Text rating;
    public Text feed;
    public InputField tempRate;
    public InputField tempFeed;
    public static string rate;
    public static string Feedback;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        rating.text = tempRate.text;
        rate = rating.text;
        feed.text = tempFeed.text;
        Feedback = feed.text;
    }
    public void Rate() {
        
    }
}
