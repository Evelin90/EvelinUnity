using UnityEngine;

class Folower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    [SerializeField] float bigRango = 10;
    [SerializeField] float smallRango = 10;

    void Update()
    {
        Vector3 selfPosition = tarsform.position;
        Vector3 targetPosition = target.position;
        /*
        Vector3 diriction = targetPosition - selfPosition;
        diriction.Normalize();

        Vector3 velocity = diriction * speed;

        transform.position = trasform.position + velocity * Time.deltaTime;
        

        float distance = Vector3.Distance(selfPosition, targetPosition);
        if (distance <= rango)
            transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);

        if(diriction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(diriction);
        */

        if (distance <= bigRango)
        {
            float t = Mathf.InverseLerp(bigRango, smallRango, distance);
            float actualSpeed = Math.Lerp(0, speed, t);

            transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);
        }
    }
    void onDrawGizmosSelected()
    {
        Gizmos.colored = Color.blue;
        Gizmos.DrawireSphere(tarnsform.position, smallRango);
        Gizmos.DrawireSphere(tarnsform.position, bigRango);
    }
}
