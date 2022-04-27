using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour
{
    public Text MousePos;
    float posX = -1f, posY = -1f, posZ = -1f;
    int X, Y;
    // Start is called before the first frame update
    void Start()
    {
        MousePos = gameObject.GetComponent<Text>();
        MousePos.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clickPosition = new Vector3(posX, posY, posZ);
        clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0f, 0f, 0f));
        X = (int)Input.mousePosition.x;
        Y = (int)Input.mousePosition.y;

        MousePos.text = "X: " + X + "  Y: " + Y;

    }
}
