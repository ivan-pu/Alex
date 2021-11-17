using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumboxController : MonoBehaviour
{
    public string thenumber;
    [SerializeField]
    private string password;

    private DoorController door;
    
    // Start is called before the first frame update
    void Start()
    {
        thenumber = "";
        door = this.transform.parent.parent.parent.GetComponentInChildren<DoorController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (thenumber.Length > 4){
            thenumber = thenumber.Substring(0, 4);
        }
        this.gameObject.GetComponent<TextMeshPro>().text = thenumber;
        if (thenumber == password){
            door.gotKey = true;
        }
    }
}
