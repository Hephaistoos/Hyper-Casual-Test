using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilHareket : MonoBehaviour
{
    bool sagagit;
    bool solagit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, 0.02f);
        if (Input.touchCount>0) //Dokunma sayýmýzý þartladýk.
        {

            Touch dokunma = Input.GetTouch(0); //0 sayýsý began methoduna eþit
            Vector3 sag = new Vector3(11, transform.position.y, transform.position.z);
            Vector3 sol = new Vector3(-1, transform.position.y, transform.position.z);
            if (dokunma.deltaPosition.x>50.0f)
            {
                sagagit = true;
                solagit = false;
            }
            if (dokunma.deltaPosition.x < -50.0f)
            {
                sagagit = false;
                solagit = true;
            }
            if (sagagit == true)
            {
                transform.position = Vector3.Lerp(transform.position,sag,2f*Time.deltaTime);
            }
            if (solagit == true)
            {
                transform.position = Vector3.Lerp(transform.position, sol, 2f * Time.deltaTime);
            }
        }
    }
}
