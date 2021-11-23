using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDisable : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            timer = 3f;
            this.gameObject.SetActive(false);
        }
    }
}
