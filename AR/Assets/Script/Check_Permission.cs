using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Check_Permission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            // The user authorized use of the microphone.
            Debug.Log("권한 허용");
        }
        else
        {
            // We do not have permission to use the microphone.
            // Ask for permission or proceed without the functionality enabled.
            Debug.Log("권한 비허용");
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
