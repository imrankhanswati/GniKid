using UnityEngine;
using System.Collections;

public class AnimatedBackground : MonoBehaviour {

    public float speed;
    public Vector3 spritePos;
    public RectTransform sprite;
    public float tempX;
    public bool isLeftReached = true;


	// Use this for initialization
	void Start () {
        spritePos = sprite.GetComponent<RectTransform>().position;
        tempX = spritePos.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (tempX > 140)
        {
            isLeftReached = true;
        }
        else if (tempX < -145)
        {
            isLeftReached = false;
        }
        if (isLeftReached==false)
            tempX += speed * Time.deltaTime;
        else if (isLeftReached==true)
            tempX -= speed * Time.deltaTime;
        spritePos = new Vector3(tempX, spritePos.y, spritePos.z);
        sprite.GetComponent<RectTransform>().position = spritePos;
	}
}
