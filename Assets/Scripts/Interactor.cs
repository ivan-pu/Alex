using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask Interactable = 8;
    [SerializeField]
    private GameObject interactText;
    private GameObject itembeinginteracted;

    private bool forcedclose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, Interactable)){
            
            if (!forcedclose){
                interactText.SetActive(true);
            }
            itembeinginteracted = hit.collider.gameObject;
            if (hit.collider.GetComponent<Interactable>() != false){
                if (Input.GetKeyDown(KeyCode.E)){
                    hit.collider.GetComponent<Interactable>().interacted = true;
                    interactText.SetActive(false);
                    forcedclose = true;
                }
            }
        }
        else{
            if (itembeinginteracted != null && itembeinginteracted.GetComponent<Interactable>() != false){
                itembeinginteracted.GetComponent<Interactable>().interacted = false;
                itembeinginteracted = null;
                forcedclose = false;
            }
            interactText.SetActive(false);
        }
    }
}

