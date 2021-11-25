using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCrossword : MonoBehaviour
{
    private int childCount;
    [SerializeField]
    private GameObject endingSequence;
    // Start is called before the first frame update
    void Start()
    {
        childCount = this.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        bool passed = true;
        Transform temp;
        for (int i = 0; i < childCount; i++){
            temp = this.transform.GetChild(i);
            if (!(temp.GetComponent<InputField>().text != null && temp.GetComponent<InputField>().text == temp.gameObject.name)) passed = false;
        }
        if (passed){
            endingSequence.SetActive(true);
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}
