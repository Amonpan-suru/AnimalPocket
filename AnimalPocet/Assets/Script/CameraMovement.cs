using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform traget;

    private Vector3 previousPosiion;
    private void Start()
    {
        cam.transform.position = traget.position;
        cam.transform.Translate(new Vector3(0, 0.5f, -4));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosiion = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 direction = previousPosiion - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = traget.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180,Space.World);
            cam.transform.Translate(new Vector3(0, 0.5f, -4));


            previousPosiion = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
