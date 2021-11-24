using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class LaptopPassword : MonoBehaviour
{
    [SerializeField]
    private InputField passwordField;
    [SerializeField]
    private GameObject disableParent;
    [SerializeField]
    private string password1;
    [SerializeField]
    private string password2;
    [SerializeField]
    private string password3;
    [SerializeField]
    private GameObject wrongPasswordMessage;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            checkPassword();
        }
    }

    public void checkPassword(){
        if(checkHelper()){
            disableParent.SetActive(false);
            this.gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
        } else {
            wrongPasswordMessage.SetActive(true);
        }
    }

    private bool checkHelper(){
        return ((password1 != null && passwordField.text.ToUpper() == password1) 
        || (password2 != null && passwordField.text.ToUpper() == password2) 
        || (password3 != null && passwordField.text.ToUpper() == password3));
    }
}
