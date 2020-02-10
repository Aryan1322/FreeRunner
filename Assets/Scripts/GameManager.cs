using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Score;
    public Text textScore;
    

    // Update is called once per frame
    void Update()
    {
        Score += 2 * Time.deltaTime;

        if(Score >= 500)
        {
            //spawn Platform


        }
        if(Score >= 1500)
        {
            //despawn the platfrom on the sides
        }
        textScore.text = Score.ToString();
    }
}
