using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Paint : MonoBehaviour
{
    public GameObject GO;
    GameObject thisTr;
    Plane obj;

    // Use this for initialization
    void Start()
    {
        obj = new Plane(Camera.main.transform.forward, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
        {
            Debug.Log("UI Touch Block");

            return;
        }
            
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("UI Click Block");

            return;

        }

        else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Start Point");

            thisTr = (GameObject)Instantiate(GO, this.transform.position, Quaternion.identity);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayD;
            if (obj.Raycast(ray, out rayD))
                thisTr.transform.position = ray.GetPoint(rayD);
        }
        else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {
            Debug.Log("Move Line");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayD;
            if (obj.Raycast(ray, out rayD))
                thisTr.transform.position = ray.GetPoint(rayD);
         }


       obj = new Plane(Camera.main.transform.forward , thisTr.transform.position);

    }

}
