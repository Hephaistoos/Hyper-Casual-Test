using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;

    void Start()
    {



    }

    private void LateUpdate()
    {

        this.transform.position = Vector3.Lerp(this.transform.position, hedef.transform.position + mesafe, Time.deltaTime);

    }

}
