using UnityEngine;

public class DogMove : MonoBehaviour
{

    //public GameObject[] ch = new GameObject[3]; // 캐릭터
   

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            this.transform.Translate(Vector3.left * 5.0f * Time.deltaTime); 

        }
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(Vector3.right * 5.0f * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.J))
        {
            this.transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Translate(Vector3.back * 5.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.U))
        {
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.O))
        {
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }

    }
}
