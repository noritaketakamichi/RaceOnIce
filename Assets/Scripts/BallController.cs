using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public int RedScore=0;
    public int BlueScore=0;
    public Text RedScoreText;
    public Text BlueScoreText;

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
            if(transform.position.x>-7.5 &&transform.position.x<7.5){
                if(transform.position.z>40){
                    //赤の得点の時
                    AddRedPoint();
                }else if (transform.position.z<-40){
                    //青の得点の時
                    AddBluePoint();
                }
            }
        BackToStart();
        };
    }

    void AddRedPoint(){
        RedScore++;
        RedScoreText.text=RedScore.ToString();
        BackToStart();
    }

    void AddBluePoint(){
        BlueScore++;
        BlueScoreText.text=BlueScore.ToString();
        BackToStart();
    }

    //最初に戻す関数
    void BackToStart()
    {
        Debug.Log("HHHHHHHHHHH");
        transform.position = new Vector3(0,35,10);
    }
}
