using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopPassword : MonoBehaviour
{
    [SerializeField]
    private InputField passwordField;
    [SerializeField]
    private GameObject disableParent;
    [SerializeField]
    private string password;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkPassword(){
        if(passwordField.text.ToUpper() == password){
            disableParent.SetActive(false);
        }
    }
}
