using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivate : MonoBehaviour {

    public GameObject inputField;
    public bool pressed;

    private void Start()
    {
        pressed = false;
    }
    public void ActivateAndDeactivate()
    {
        if (pressed)
        {
            inputField.SetActive(true);
            pressed = false;
        }
        if (!pressed)
        {
            inputField.SetActive(false);
            pressed = true;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
