using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagiguess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       public class BecomeVisible : MonoBehaviour
    {
        // Disable this script when the GameObject moves out of the camera's view
        void OnBecameInvisible()
        {
            enabled = false;
        }

        // Enable this script when the GameObject moves into the camera's view
        void OnBecameVisible()
        {
            enabled = true;
        }

        void Update()
        {
            Debug.Log("Script is enabled");
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
