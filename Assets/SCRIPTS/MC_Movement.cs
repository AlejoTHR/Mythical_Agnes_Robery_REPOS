using UnityEngine;
using UnityEngine.InputSystem;

public class MC_Movement : MonoBehaviour
{

    public float SPEED;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // CREATE VECTOR FOR MOVEMENT
        Vector3 Dir = new Vector3(0, 0, 0);

        if (Keyboard.current.wKey.IsPressed())
        {
            Dir.y = 1;
        }
        if (Keyboard.current.sKey.IsPressed())
        {
            Dir.y = -1;
        }
        if (Keyboard.current.dKey.IsPressed())
        {
            Dir.x = 1;
        }
        if (Keyboard.current.aKey.IsPressed())
        {
            Dir.x = -1;
        }

        // MOV REMAIN CONSTANT FOR FPS
        transform.position += Dir * SPEED * Time.deltaTime;

        //TURN AROUND
        if (Dir.x > 0)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0);
        }
        else if (Dir.x < 0)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0);

        }




    }
}
