using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public bool gotKey;

    private Animation doorAnim;
    private BoxCollider doorCollider;

    private bool doorOpened;

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
            doorCollider.enabled = false;
        }
    }
}
