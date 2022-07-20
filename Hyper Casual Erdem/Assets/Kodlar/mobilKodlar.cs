using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mobilKodlar : MonoBehaviour
{
    public GameObject küp;
    public Text yazý;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*foreach(Touch dokunma in Input.touches)
        {
            if (dokunma.phase == TouchPhase.Began)
            {
                küp.transform.position += new Vector3(0f, 10f, 0f);
            }
        }*/


       for(int i=0;i<Input.touchCount; i++)
        {
            yazý.text = Input.touchCount + "Parmak Dokunyor";
        }  

    }
}
