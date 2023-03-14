
using UnityEngine;

class Mover : MonoBehaviour
{
    /*[SerializeField] Vector3 velocity;

    void Start()
    {
        Vector2 v2a = new Vector2(1, 4);
        Vector3 v3a = new Vector3(4, 5, 7.545f);

        float f1 = v2a.x;
        float f2 = v3a.z;

        Transform t = transform;

        t.position = v3a;

    }
        */

    
    [SerializeField] Transform cameraTransform
    [SerializeField] float speed = 5;
    [SerializeField] bool moveInCameraSpace = true;
    [SerializeField] angularVelocity

    void Update()
    {
        bool up = Input.GetKey(KeyCode.UpArrow) ||  Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        /*
        Vector3 upDir = Vector3.up;
        Vector3 upDir2 = new Vector3(0,1,0);
        Vector3 localUp = transform.up
         */

        float y = 0;
        if (up && down)
            y = 0;
        else if (up)
            y = 1;
        else if (down)
            y = -1;

        float x = 0;
        if(right)
            x += 1;
        if (left)
            x -= 1;

        // Vector3 rightDir = Vector3.right;
        //Vector3 forwardDir = Vector3.forward;
        

        Vector3 rightDir = moveInCameraSapace ? cameraTransform.right : Vector3.right;
        Vector3 forwardDir = moveInCameraSpace ? cameraTransform.forward : Vector3.forward;

        // Vector3 velocity = new Vector3(x, 0, y);
        Vector3 velocity = rightDir * forwardDir * z;
        velocity.y = 0;

        velocity.Normalize();

        velocity *= speed;

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);
      
        transform.position = newPos;



        if (velocity != Vector3.zero)
        {
            //transform.rotation = Quaternion.LookRotation(velocity);
            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            Quaternoin currentRotation = tarnsform.rotation;
            Transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angularVelocity * Time.deltaTime);
        }

    }
}
