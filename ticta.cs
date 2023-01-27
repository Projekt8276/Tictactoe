using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class  ticta : MonoBehaviour
{
    static bool playerIsX = true;

    static String getPlayerChar(String current_value)
    {
        if (current_value != "X" && current_value != "O")
        {
            if (playerIsX == true) {
                playerIsX = false;
                return ("X");
            }
            else
            {
                playerIsX = true;
                return ("O");
            }
        }
        else
        {
            return(current_value);
        }
        
    }

    // Start is called before the first frame update
    // Static void Start()
    // {
    //     Debug.Log("FART");
    // }

    // // Update is called once per frame
    // void Update()
    // {
         
    public void Reset()
    {
        Button button = GetComponent<Button>();
        //Debug.Log("pressed");
        button = GameObject.Find("Button A0").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button A1").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button A2").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button B0").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button B1").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button B2").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button C0").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button C1").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";

        button = GameObject.Find("Button C2").GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = "";
       
    }
    
    public void Button_Pressed_A0()
    {
        Text txt = transform.Find("Text A0").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: A0");
    }
    public void Button_Pressed_A1()
    {
        Text txt = transform.Find("Text A1").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: A1");
    }
    public void Button_Pressed_A2()
    {
        Text txt = transform.Find("Text A2").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: A2");
    }
    public void Button_Pressed_B0()
    {
        Text txt = transform.Find("Text B0").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: B0");
    }
    public void Button_Pressed_B1()
    {
        Text txt = transform.Find("Text B1").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: B1");
    }
    public void Button_Pressed_B2()
    {
        Text txt = transform.Find("Text B2").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: B2");
    }
     public void Button_Pressed_C0()
    {
        Text txt = transform.Find("Text C0").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: C0");
    }
    public void Button_Pressed_C1()
    {
        Text txt = transform.Find("Text C1").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: C1");
    }
    public void Button_Pressed_C2()
    {
        Text txt = transform.Find("Text C2").GetComponent<Text>();
        txt.text = getPlayerChar(txt.text);
        Debug.Log("Button: C2");
    }
}
