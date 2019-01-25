using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionTrigger : MonoBehaviour
{
    public GameObject currentTriggerGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "InteractionObject")
        {
            Debug.Log(collision.transform.name);
            currentTriggerGameObject = collision.gameObject;
            //collision.getComponent<ScriptName>().methodName();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "InteractionObject")
        {
            Debug.Log(other.transform.name);
            //collision.getComponent<ScriptName>().methodName();
        }
    }
}
