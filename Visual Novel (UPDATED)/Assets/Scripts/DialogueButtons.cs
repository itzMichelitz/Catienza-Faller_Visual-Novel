using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueButtons : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject Choice;
    public GameObject Choice1;
    public GameObject Choice2;

    // Start is called before the first frame update
    void Awake()
    {
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        Choice.SetActive(false);    
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else { 
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue() {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() {
        foreach (char c in lines[index].ToCharArray()) {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        if (index == 1)
        {
            Choice.SetActive(true);
            Choice1.SetActive(true);
            Choice2.SetActive(true);

        }
        else
        {

            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        }


    public void one() {
        Choice1.SetActive(true);
        Choice.SetActive(false);
        gameObject.SetActive(false);
    }
    public void two()
    {
        Choice2.SetActive(true);
        Choice.SetActive(false);
        gameObject.SetActive(false);
    }
}

    


