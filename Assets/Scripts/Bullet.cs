using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int enemyCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyCount++;
            Destroy(collision.gameObject);
            PlayerShooting.instance.lightArea.pointLightOuterRadius += .5f;
            Destroy(this.gameObject, 2f);
        }
    }
}
