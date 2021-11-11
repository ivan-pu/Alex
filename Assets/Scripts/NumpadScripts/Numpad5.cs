using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numpad5 : MonoBehaviour
{
    public LayerMask layer;

    private GameObject itembeinginteracted;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, layer))
        {
            itembeinginteracted = hit.collider.gameObject;
            if (Input.GetMouseButtonUp(0) && this.gameObject == itembeinginteracted)
            {
                NumboxController.thenumber += "5";
            }
        }
    }
}
