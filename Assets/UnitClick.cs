using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " is at position " + this.gameObject.transform.position);
        Debug.Log(name + " is at position " + transform.position);
        Debug.Log("Time is " + Time.time);
    }

}
