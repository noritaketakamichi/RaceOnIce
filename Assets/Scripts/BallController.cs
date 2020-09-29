using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //穴に落ちたら最初に戻す
        if(transform.position.y<20){
            BackToStart();
        };
    }

    //最初に戻す関数
    void BackToStart()
    {
        SceneManager.LoadScene (0);
    }
}
