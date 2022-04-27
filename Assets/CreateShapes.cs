using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShapes : MonoBehaviour
{

    public float distance = 10f;
    public float distanceChange = 1f;
    public float rotationAmount = 0f;
    public float roataionDelta = 0.0f;
    float posX = -1f;
    float posY = -1f;
    float posZ = -1f;
    int option = 0;
    int colorOption = 0;
    Color currentColor;

    
    

    // Start is called before the first frame update
    void Start()
    {
        currentColor = Color.black;//set the default color to black
    }

    // Update is called once per frame
    void Update()
    {   //get the color and shape dropdown values
        GameObject Dropdown = GameObject.Find("Dropdown");
        ChnageDropdown dropdownOption = Dropdown.GetComponent<ChnageDropdown>();
        option = dropdownOption.m_DropdownValue;

        GameObject DropdownColor = GameObject.Find("DropdownColor");
        ChangeColor dropdownOptionColor = DropdownColor.GetComponent<ChangeColor>();
        colorOption = dropdownOptionColor.c_DropdownValue;
        //Debug.Log("Option is: " + colorOption);
        //change the color of the objects
        if(colorOption == 0){
            currentColor = Color.black;
        }else if (colorOption == 1){
            currentColor = Color.white;
        }else if(colorOption == 2){
            currentColor = Color.red;
        }else  if (colorOption == 3){
            currentColor = Color.blue;
        }else if (colorOption == 4){
            currentColor = Color.yellow;
        }else if (colorOption == 5) {
            currentColor = Color.green;
        }

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(1))
        {
            distance += distanceChange;
            posX = -1f;
            posY = -1f;
            posZ = -1f;
            Vector3 clickPosition = new Vector3(posX, posY, posZ);
            clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0f, 0f, distance));
            Debug.Log(clickPosition);
            if (option == 0) {//cylinder
                GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                cylinder.GetComponent<Renderer>().material.color = currentColor;
                cylinder.transform.position = clickPosition;
                rotationAmount += roataionDelta;
                cylinder.transform.Rotate(new Vector3(rotationAmount, 0f, 0f));
            }else if (option == 1)//cube
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.GetComponent<Renderer>().material.color = currentColor;
                cube.transform.position = clickPosition;
                rotationAmount += roataionDelta;
                cube.transform.Rotate(new Vector3(rotationAmount, 0f, 0f));
            }
            else if (option == 2)//sphere
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.GetComponent<Renderer>().material.color = currentColor;
                sphere.transform.position = clickPosition;
                rotationAmount += roataionDelta;
                sphere.transform.Rotate(new Vector3(rotationAmount, 0f, 0f));
            }

        }
    }

    

}
