using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;

    void OnTriggerEnter(Collider other)
    {
        HealthObject ho = other.GetComponent<HealthObject>();

        // Rigidbody rb1 = GetComponentInChildren<>(); gyerek
        //Rigidbody rb2 = GetComponentInParent<>(); szülõ
        //Rigidbody[] rigidbodies = GetComponents<>(); több komponens visszaadása

        if (ho != null)
        {
            ho.Damage(damage);
        }
    }
}
