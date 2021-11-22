//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MyRigidbody : MonoBehaviour
{
    //v0 = start velocity // velocity = m/s
    private Vector3 velocity = Vector3.zero;
    //acceleration, including gravitational acceleration and forward acceleration
    private Vector3 acceleration = new Vector3(1,-3,0);
    private float mass = 3;

    void Awake()
    {
        Launch(80f, 1000f);
    }

    void Update()
    {
        //Force (N) = mass (kg) × acceleration (m/s2)
        Vector3 force = mass * (acceleration * Time.deltaTime);
        velocity += force;
        transform.position += velocity * Time.deltaTime;
    }

    void Launch(float angleInDegrees, float LaunchMagnitude)
    {
        float angleInRadians = angleInDegrees * Mathf.Deg2Rad;
        Vector3 dir = new Vector3 (Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians), 0).normalized;
        velocity += dir * LaunchMagnitude * Time.deltaTime;
    }
}