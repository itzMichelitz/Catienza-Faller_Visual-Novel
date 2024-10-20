using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Speaker;
    void Awake()
    {
        Speaker.text = ReadInput.input; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
