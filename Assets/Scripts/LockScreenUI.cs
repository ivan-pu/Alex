using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScreenUI : MonoBehaviour
{
    [SerializeField]

    private GameObject attachedObject;
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
    }

    public void backtoNormal()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camera.main.GetComponent<FirstPersonLook>().enabled = true;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        Camera.main.GetComponentInParent<Crouch>().enabled = true;
        if (attachedObject) attachedObject.GetComponent<Interactable>().interacted = false;
        gameObject.SetActive(false);
    }
}
