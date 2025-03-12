using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Mouse0)) {
    //         Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);
    //     }
    // }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
            muzzleEffect.Play();
        }
    }
}
