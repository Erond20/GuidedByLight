using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerShooting : MonoBehaviour
{
    public static PlayerShooting instance;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject DeathPanel;
    public float bulletSpeed = 10f;
    [SerializeField] float fireRate;
    float nextTimeToFire = 0.0f;
    public int shotCount = 0;
    public Light2D lightArea;
    private void Awake()
    {
            instance = this;
    }
    private void Update(){
        if(Input.GetMouseButton(0)){
            Shoot();
        }
        if (shotCount == 10){
            Time.timeScale = 0;
            DeathPanel.SetActive(true);
        }
    }
    void Shoot() {
        if(Time.time > fireRate + nextTimeToFire) {
             GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
            lightArea.pointLightOuterRadius--;
            shotCount++;
             Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
             rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
             nextTimeToFire = Time.time;
        }
    }
}
