using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Camera.main.GetComponent<FirstPersonLook>().enabled = false;
            Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Camera.main.GetComponentInParent<Crouch>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.E)){
            backtoNormal();
        }
    }

    public void backtoNormal()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camera.main.GetComponent<FirstPersonLook>().enabled = true;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        Camera.main.GetComponentInParent<Crouch>().enabled = true;
        GameObject.Find("Phone").GetComponent<Interactable>().interacted = false;
        gameObject.SetActive(false);
    }
}
