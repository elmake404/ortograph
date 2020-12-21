using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Camera _cam;
    private Builder _builder;
    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag== "Builder")
                {
                    Debug.Log(1);
                    Builder builder = hit.collider.GetComponent<Builder>();
                    builder.SpawnDetail();
                    builder.DetailScale();
                    builder.ActivationDetail();
                }
            }
        }
        else if (Input.GetMouseButton(0))
        {

        }
    }
}
