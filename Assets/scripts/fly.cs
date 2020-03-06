
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fly : MonoBehaviour
{
    public float speed;
    public GameObject plane;
    float xRot = 0;
    float zRot = 0;
    float yRot = 0;
    public Rigidbody rb;
    public Vector3 originalPos;
    public Transform explosionFire;
    public float zRotP = 125;
    public float zRotN = -125;

    private void Start()
    {
        originalPos = plane.transform.position;

    }
    void Update()
    {

        if (transform.rotation.z >= zRotP)
        {
            Instantiate(explosionFire, transform.position, explosionFire.rotation);
            plane.transform.position = originalPos;
        }
        if (transform.rotation.z <= zRotN)
        {
            Instantiate(explosionFire, transform.position, explosionFire.rotation);
            plane.transform.position = originalPos;
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * ( speed));
            

        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.up * (speed));
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * ( speed));
            zRot++;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * ( speed));
            zRot--;
        }
        transform.rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.magnitude * yRot, 0.0f, GetComponent<Rigidbody>().velocity.magnitude * zRot);

        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(transform.position.y, -4, 6);
        pos.x = Mathf.Clamp(transform.position.x, -7, 8);
        transform.position = pos;

        
    }
    public void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag.Equals("enemy"))
        {
            Instantiate(explosionFire, transform.position, explosionFire.rotation);
            plane.transform.position = originalPos;
            TakeScene();


        }
        if (col.gameObject.tag.Equals("goal"))
        {
          
            AddScene();


        }
    }
    public void AddScene()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TakeScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }

    }

}