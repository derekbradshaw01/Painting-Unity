using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    //Attach this script to a Dropdown GameObject
    Dropdown c_Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    string c_Message;
    //This Text outputs the current selection to the screen
    public Text c_Text;
    //This is the index value of the Dropdown
    public int c_DropdownValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        c_Dropdown = GetComponent<Dropdown>();
        //Output the first Dropdown index value
        //Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);
    }

    void Update()
    {
        //Keep the current index of the Dropdown in a variable
        c_DropdownValue = c_Dropdown.value;
        //Change the message to say the name of the current Dropdown selection using the value
        c_Message = c_Dropdown.options[c_DropdownValue].text;
        //Change the onscreen Text to reflect the current Dropdown selection
        //Debug.Log("current Dropdown Value : " + m_Dropdown.value);
    }
}
