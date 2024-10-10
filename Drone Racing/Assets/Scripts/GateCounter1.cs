using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateCounter1 : MonoBehaviour
{
    private int passedGates = 0;

    public Text passedGatesText; // Reference to the Text component for displaying passed gates
    public Text controlInputText; // Reference to the Text component for displaying control input
    public Text timeText; // Reference to the Text component for displaying time
    public Text positionText; // Reference to the Text component for displaying position

    //public GameObject GateText;


    void UpdateText()
    {
        //GateText.GetComponent<Text>().text = "Gates Passed:" + passedGates.ToString();
        // Update passed gates text
        passedGatesText.text = "Gates Passed: " + passedGates.ToString();

        // Update control input text (example)
        controlInputText.text = "Control Input: " + GetControlInput();

        // Update time text
        timeText.text = "Time: " + Time.time.ToString("F2"); // Display time with two decimal places

        // Update position text
        positionText.text = "Position: " + transform.position.ToString();
    }


        // Function to simulate control input (example)
    private string GetControlInput()
    {
        string controlInput = "";

        if (Input.GetKey(KeyCode.W))
            controlInput += "W ";
        if (Input.GetKey(KeyCode.A))
            controlInput += "A ";
        if (Input.GetKey(KeyCode.S))
            controlInput += "S ";
        if (Input.GetKey(KeyCode.D))
            controlInput += "D ";

        return controlInput;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            passedGates++;
            //Debug.Log("Gate passed! Total gates: " + passedGates);
            //Debug.Log("Time: " + Time.time.ToString("F2"));
            //UpdateText();
        }
    }
    
    void OnGUI()
    {
        //style.normal.textColor = Color.red;
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(800,0,1000,1000), "Gates Passed: " + passedGates.ToString(),"color");
        GUI.Label(new Rect(800,15,100,100), "Control Input: " + GetControlInput(),"color");
        GUI.Label(new Rect(800,30,100,100), "Time: " + Time.time.ToString("F2"),"color");
        GUI.Label(new Rect(800,45,100,100), "Position: " + transform.position.ToString(),"color");
    }

}
