using UnityEngine;

class Mover : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] float speed = 5;

    [SerializeField] bool moveInCameraSpace = true;
    [SerializeField] float angularVelocíty = 180;

    [SerializeField] HealthObject healthObject;

    void OnValidate()
    {
        if (healthObject == null)
            healthObject = GetComponent<HealthObject>();
    }
    void Update()
    {
        if (healthObject != null && !healthObject.IsAlive())
            return;

        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        float z = 0;
        if (up && down)
            z = 0;
        else if (up)
            z = 1;
        else if (down)
            z = -1;

        float x = 0;
        if (right)
            x += 1;
        if (left)
            x -= 1;

        Vector3 rightDir = moveInCameraSpace ? cameraTransform.right : Vector3.right;
        Vector3 forwardDir = moveInCameraSpace ? cameraTransform.forward : Vector3.forward;

        Vector3 velocity = rightDir * x + forwardDir * z;
        velocity.y = 0;

        velocity.Normalize();

        velocity *= speed;

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);

        transform.position = newPos;

        if (velocity != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            Quaternion currentRotation = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angularVelocíty * Time.deltaTime);
        }
    }
}
