using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody ballRigidbody;

    private void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d") ||
            Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            Vector3 inputValue = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            ballRigidbody.MovePosition(transform.position + inputValue * (Time.deltaTime * 5f));
        }
    }
}