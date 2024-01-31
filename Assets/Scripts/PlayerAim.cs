using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.EventSystems;

public class PlayerAim : MonoBehaviour
{
    public Transform aimTarget;
    [SerializeField] private GameObject crossHair;
    private Vector2 aimDirection;
    void Update(){
        aimDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        aimDirection = aimDirection.normalized;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0,0,aimAngle);
        crossHair.transform.position = Input.mousePosition;
    }
}
