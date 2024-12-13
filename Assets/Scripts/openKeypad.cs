using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openKeypad : MonoBehaviour
{
    public GameObject keypadOB;
    //public GameObject keypadtxt;

    public bool inreach;

    //[Header("Input")]
    //[SerializeField] private KeyCode interact;

    void Start()
    {
        inreach = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inreach = true;
            //keypadtxt.SetActive(true);
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inreach = false;
            //keypadtxt.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.E) && inreach)
        {
            keypadOB.SetActive(true);
           // Cursor.lockState = CursorLockMode.None;
        }

       // Cursor.lockState = CursorLockMode.Locked;
    }
}
