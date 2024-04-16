using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private float Cooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject Bullet;
    private float cooldownTimer;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Shoot()
    {
        anim.SetTrigger("PlantShoot");
        cooldownTimer = 0;
        Bullet.transform.position = firePoint.position;
        Bullet.GetComponent<Projectile>().ActivateBullet();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= Cooldown)
        {
            Shoot();
        }
    }
}
