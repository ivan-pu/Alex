using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask Interactable = 8;
    [SerializeField]
    private GameObject interactText;
    private GameObject itemBeingInteracted;

    private bool turnoffInttext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, Interactable))
        {

            if (!turnoffInttext)
            {
                interactText.SetActive(true);
            }
            itemBeingInteracted = hit.collider.gameObject;
            if (itemBeingInteracted.GetComponent<Interactable>() != false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<Interactable>().interacted = true;
                    interactText.SetActive(false);
                    turnoffInttext = true;
                }
            }
        }
        else
        {
            if (itemBeingInteracted != null && itemBeingInteracted.GetComponent<Interactable>() != false)
            {
                itemBeingInteracted.GetComponent<Interactable>().interacted = false;
                itemBeingInteracted = null;
                turnoffInttext = false;
            }
            interactText.SetActive(false);
        }
    }
}

