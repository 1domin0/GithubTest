using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject playerCamera;
    [SerializeField] private float mouseSensivity = 2f;
    private float xRotation = 0f;
    private float yRotation = 0f;

    private void OnEnable()
    {
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        playerCamera.transform.Rotate(new Vector3(0, 0, 0));
        transform.Rotate(new Vector3(0, 0, 0));
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKeyDown("n")) Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKeyDown("m")) Cursor.lockState = CursorLockMode.None;

        var mouseX = Input.GetAxis("Mouse X");
        var mouseY = Input.GetAxis("Mouse Y");

        xRotation -= mouseY * mouseSensivity;
        xRotation = Mathf.Clamp(xRotation, -40f, 50f);
        yRotation = mouseX * mouseSensivity;

        transform.Rotate(Vector3.up * yRotation);
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
