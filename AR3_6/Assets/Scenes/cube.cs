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
        
    }

    private void OnMouseDrag()
    {
        this.transform.Rotate(0.0f, rotaionSpeed, 0.0f);

        if (Input.GetMouseButtonUp(0))
        {
            this.transform.Rotate(0.0f, rotaionSpeed*0.95f, 0.0f);
        }
    }

    public void cubeRoate()
    {
        this.transform.Rotate(0.0f, rotaionSpeed, 0.0f);
    }
}
