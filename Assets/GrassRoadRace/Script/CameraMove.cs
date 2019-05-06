
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{

    public float moveSpeed;
    public float rotateAmount;
    public GameObject mainCamera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        Moveplayer();

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            
        }
    }


    void Moveplayer()
    {
        float moveAmount = Time.smoothDeltaTime * moveSpeed;
        transform.Translate(-moveAmount, 0f, 0f);
        transform.Rotate(0, rotateAmount, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Finish":
                transform.Rotate(0, 90, 0);
                break;
        }

        }

}























