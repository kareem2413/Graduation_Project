
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float moveSpeed;
	public GameObject mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera.transform.localPosition = new Vector3 ( 0, 0, 0 );
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void FixedUpdate()
	{
		Moveplayer ();
		
		if (Input.GetKeyDown (KeyCode.A)) {
			ChangeView01();
		}
		
		if (Input.GetKeyDown (KeyCode.S)) {
			ChangeView02();
		}
	}
	
	
	void Moveplayer() {		
		float moveAmount = Time.smoothDeltaTime * moveSpeed ;
		transform.Translate (-moveAmount, 0f, 0f  );	
	}
    
    void OnCollisionEnter (Collision collision)
    {

    }



	void ChangeView01() {
		transform.position = new Vector3 (0, 2, 10);
		// x:0, y:1, z:52
		mainCamera.transform.localPosition = new Vector3 ( -8, 2, 0 );
		mainCamera.transform.localRotation = Quaternion.Euler (14, 90, 0);
	}

	void ChangeView02() {
		transform.position = new Vector3 (0, 2, 10);
		// x:0, y:1, z:52
		mainCamera.transform.localPosition = new Vector3 ( 0, 0, 0 );
		mainCamera.transform.localRotation = Quaternion.Euler ( 19, 180, 0 );
		moveSpeed = -20f;
		
	}
}























