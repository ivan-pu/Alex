using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public bool gotKey;                  //Has the player acquired key

    private Animation doorAnim;
    private BoxCollider doorCollider;           //To enable the player to go through the door if door is opened else block him

    private bool doorOpened;


    /// <summary>
    /// Initial State of every variables
    /// </summary>
    private void Start()
    {
        gotKey = false;
        doorOpened = false;
        doorAnim = transform.parent.gameObject.GetComponent<Animation>();
        doorCollider = transform.parent.gameObject.GetComponent<BoxCollider>();

    }

    private void Update()
    {

        if (gotKey && !doorOpened)
        {
            doorAnim.Play("Door_Open");
            doorOpened = true;
        }
    }
}
