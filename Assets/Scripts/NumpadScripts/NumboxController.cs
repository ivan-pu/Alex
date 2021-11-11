using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumboxController : MonoBehaviour
{
    public static string thenumber;
    // Start is called before the first frame update
    void Start()
    {
        thenumber = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (thenumber.Length > 4){
            thenumber = thenumber.Substring(0, 4);
        }
        this.gameObject.GetComponent<TextMeshPro>().text = thenumber;
    }
}
