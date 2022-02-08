using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private float timer;
    [SerializeField, Range(0.1f, 10)]
    private float fireRate;
    [SerializeField, Range(1, 100)]
    private int damage;
    [SerializeField]
    private Transform firePoint;
    [Space]
    [SerializeField] private Transform playerCamera;

    private void Update()
    {
        timer += Time.deltaTime * fireRate;
        if (Input.GetMouseButton(0) && timer > 1)
        {
            timer = 0f;
            FireGun();
        }

        firePoint.localRotation = Quaternion.Euler(playerCamera.localEulerAngles.x, 0, 0);
    }

    private void FireGun()
    {
        Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.red, 2f, true);
        Ray ray = new Ray(firePoint.position, firePoint.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100f))
        {
            var testCube = hitInfo.collider.GetComponent<Health>();
            if(testCube != null)
            {
                testCube.TakeDamage(damage);
            }
        }

    }
}
