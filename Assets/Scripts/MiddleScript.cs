using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public float moveSpeed = 1;
    public float pipeDeadZone = -3;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < pipeDeadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
