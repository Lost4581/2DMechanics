using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private float startTime;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform rotateZone;
    private float currTime;
    private bool isFollowingPlayer = false;

    private void Awake()
    {
        currTime = startTime;
    }
    private void Update()
    {
        currTime -= Time.deltaTime;
        if (currTime <= 0)
        {
            currTime = startTime;
            Instantiate(bulletPref, transform);
        }
        Vector2 dir = Player.position - rotateZone.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rotateZone.transform.Rotate(0, 0, angle);
    }
}
