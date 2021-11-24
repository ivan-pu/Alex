using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    private static bool paused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused) resume();
            else pause();
        }
    }

    public void pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Camera.main.GetComponent<FirstPersonLook>().enabled = false;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Camera.main.GetComponentInParent<Crouch>().enabled = false;
        pauseMenu.SetActive(true);
        DialogueManager.Pause();
        paused = true;
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Camera.main.GetComponent<FirstPersonLook>().enabled = true;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        Camera.main.GetComponentInParent<Crouch>().enabled = true;
        DialogueManager.Unpause();
        paused = false;

    }

    public void quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
