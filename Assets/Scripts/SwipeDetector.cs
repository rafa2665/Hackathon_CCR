using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetector : MonoBehaviour
{
    int swipeDirection = 0;
    Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	float dragDistance; //distancia minima pra verificar se moveu
    public GameObject cam;
	void Start()
	{
		dragDistance = Screen.height * (15.0f / 100.0f);
	}
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			//pega posicao inicial do toque
			firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
		}
		if(Input.GetMouseButtonUp(0))
		{
			//salva a posicao final do toque
			secondPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
			//cria novo vetor para verificacao
			currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            if (currentSwipe.magnitude >= dragDistance){
                //normaliza os dois vetores
                currentSwipe.Normalize();
                //swipe upwards
                if(currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("up swipe");
                }
                //swipe down
                if(currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("down swipe");
                }
                //swipe left
                if(currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("left swipe");
                    swipeDirection = 1;
                }
                //swipe right
                if(currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("right swipe");
                    swipeDirection = -1;
                }
            }
            if (swipeDirection != 0){
                swipeDirection = 0;
                cam.GetComponent<FeedMenu>().MenuButtonClicked();
            }
		}
		
	}
}
