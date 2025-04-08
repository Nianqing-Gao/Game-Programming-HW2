using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletAmount;
    public float fireRate;
    Animator animator;

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

    // public void OnFire(InputValue value)
    // {
    //     if (value.isPressed && bulletAmount > 0 && Time.timeScale > 0)
    //     {
    //         bulletAmount--;
    //         GameObject clone = Instantiate(prefab);
    //         clone.transform.position = shootPoint.transform.position;
    //         clone.transform.rotation = shootPoint.transform.rotation;
    //         muzzleEffect.Play();
    //         shootSound.Play();
    //     }
    // }

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void OnFire(InputValue value) {
        animator.SetBool("Shooting", value.isPressed);
        if (value.isPressed) {
            InvokeRepeating("Shoot", fireRate, fireRate);
        } else {
            CancelInvoke();
        }
    }

    private void Shoot() {
        if (bulletAmount > 0 && Time.timeScale > 0) {
            bulletAmount--;
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
            muzzleEffect.Play();
            shootSound.Play();
        }
    }
}
