using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Collision detected with {other.gameObject.name}");
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
