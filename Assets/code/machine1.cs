using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machine1 : MonoBehaviour
{
    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public Collider2D target;
    public Animator anim;
    GameManager kapat;
    public GameObject next;
    public GameObject back;


    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        pos = this.transform.position;
        anim = anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDrag()
    {
        Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "icinde")
        {
            isinside = true;
            
        }
        else
        {
            isinside = false;
        }

    }
    private void OnMouseUp()
    {
        if (isinside)
        {
            transform.position = target.transform.position;
            anim.Play("machine1");
            next.SetActive(true);
            back.SetActive(true);
        }
        else
        {
            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);
        }




    }
}
