using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLock : MonoBehaviour
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
        }
    }

    public void backtoNormal()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camera.main.GetComponent<FirstPersonLook>().enabled = true;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        gameObject.SetActive(false);
    }
}
