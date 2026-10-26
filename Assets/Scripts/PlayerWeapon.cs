using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject laser;

    bool isFiring = false;

    private void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    } 

    void ProcessFiring()
    {
        ParticleSystem.EmissionModule emmisionModule = laser.GetComponent<ParticleSystem>().emission;
        emmisionModule.enabled = isFiring;
    }

}
