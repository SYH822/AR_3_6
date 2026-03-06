using UnityEngine;

public class cube : MonoBehaviour
{

    public float rotaionSpeed = 0;
  
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Rotate(0.0f, rotaionSpeed, 0.0f);
        }
    }
}
