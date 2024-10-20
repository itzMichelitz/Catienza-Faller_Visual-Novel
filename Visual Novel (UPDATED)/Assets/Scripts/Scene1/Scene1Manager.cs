using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1Manager : MonoBehaviour
{
    // Start is called before the first frame update
    //public Text Speaker;
    public GameObject Next;
    public GameObject Choice;
    public GameObject Prev;
    void Awake()
    {
        Choice.SetActive(false);
        //Speaker.text = ReadInput.input; 
        Next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene() {
        Prev.SetActive(false);
        Next.SetActive(true);
    }


}
