using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;

    private static bool paused = false;
    // Start is called before the first frame update

    private CursorLockMode previous;
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
        previous = Cursor.lockState;
        Cursor.lockState = CursorLockMode.None;
        Camera.main.GetComponent<FirstPersonLook>().enabled = false;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        pauseMenu.SetActive(true);
        DialogueManager.Pause();
        paused = true;
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Cursor.lockState = previous;
        Camera.main.GetComponent<FirstPersonLook>().enabled = true;
        Camera.main.GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        DialogueManager.Unpause();
        paused = false;
    }

    public void startmenu(){
        resume();
        DialogueManager.StopConversation();
        SceneManager.LoadScene("StartMenu");
    }
    public void quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
