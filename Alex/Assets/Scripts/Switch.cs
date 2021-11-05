using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Switch : MonoBehaviour
{
    public int gender = 1;
    public bool boy;
    [SerializeField]
    private GameObject boyView;
    [SerializeField]
    private GameObject girlView;

    
    // Start is called before the first frame update
    void Start()
    {
        GetView();
    }

    // Update is called once per frame
    void Update()
    {
        GetView();

        if (Input.GetKeyDown(KeyCode.F)){
            gender= (-1) * gender;
        }
    }

    void GetView(){
        if (gender>=1){
            boyView.SetActive(true);
            girlView.SetActive(false);
        }
        if(gender<=-1){
            boyView.SetActive(false);
            girlView.SetActive(true);
        }
    }
}
