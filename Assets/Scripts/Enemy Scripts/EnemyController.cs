using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private CharacterController enemy;
    private Vector3 dir;
    private float speed;
    private float gravity = -20f;

    void Start()
    {
        enemy = GetComponent<CharacterController>();
        speed = Random.Range(-5, -1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dir.z = speed;
        dir.y += gravity * Time.fixedDeltaTime;
        enemy.Move(dir * Time.fixedDeltaTime);
    }
}
