using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ReadInput : MonoBehaviour
{
    public Button next;
    public GameObject confirm;
    public InputField tempname;
    public Text playername;
    public static string input;

    // Start is called before the first frame update
    void Awake()
    {
        confirm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

   
    public void Confirm()
    {
        confirm.SetActive(true);
        playername.text = tempname.text;
        input = playername.text;
    }
    public void Back()
    {
        confirm.SetActive(false);
    }

  
}
