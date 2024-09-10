using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class moveCharacter : MonoBehaviour
{
    public GameObject character;
    public float speed;  // Speed of the balls

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement direction
        Vector2 movement = new Vector2(horizontalInput, 0) * speed * Time.deltaTime;

        // Move the character
        character.transform.Translate(movement);

    }

}