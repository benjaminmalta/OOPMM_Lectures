using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chessboardScript : MonoBehaviour {

	GameObject chessboardParent,chessboardTile;
	
	// Use this for initialization
	void Start () {
		chessboardParent = new GameObject();
		chessboardParent.name="chessboard";
		chessboardTile = Resources.Load<GameObject>("prefabs/BoardSquare");
		StartCoroutine(createChessboard());
	}

	IEnumerator createChessboard()
	{
		for (int r=0;r<4;r++)
		{
			for (int c=0;c<4;c++)
			{
				
				GameObject t = Instantiate(chessboardTile,new Vector3(c,r),Quaternion.identity);
				t.transform.parent = chessboardParent.transform;
				if (r%2==0){
					if (c%2 == 0)
					{
						t.GetComponent<SpriteRenderer>().color = Color.black;
					}
				}else {
					if (c%2 != 0)
					{
						t.GetComponent<SpriteRenderer>().color = Color.black;
					}				
				}
				
				
				
				yield return new WaitForSeconds(0.1f);
			}
		}
		yield return moveChessboard();
	}

	IEnumerator moveChessboard()
	{
		//top left corner
		Vector3 topLeftCorner = new Vector3(
			-Camera.main.orthographicSize * Camera.main.aspect,
			Camera.main.orthographicSize
		);

		Vector3 topRightCorner = new Vector3(
			Camera.main.orthographicSize * Camera.main.aspect,
			Camera.main.orthographicSize
		);

		Vector3 bottomRightCorner = new Vector3(
			Camera.main.orthographicSize * Camera.main.aspect,
			-Camera.main.orthographicSize
		);

		Vector3 bottomLeftCorner = new Vector3(
			-Camera.main.orthographicSize * Camera.main.aspect,
			-Camera.main.orthographicSize
		);

		float timeToMove = 1f;
		float elapsedTime = 0f;
		chessboardParent.transform.position = new Vector3(-1.5f,-1.5f);
		Vector3 currentPosition = chessboardParent.transform.position;
		while (elapsedTime<timeToMove)
		{
			chessboardParent.transform.position = 
			Vector3.Lerp(currentPosition,topLeftCorner-new Vector3(-0.5f,3.5f),elapsedTime/timeToMove);
			elapsedTime += Time.deltaTime;
			Debug.Log(elapsedTime);
			yield return null;
		}
		elapsedTime = 0f;
		currentPosition = chessboardParent.transform.position;
		while (elapsedTime<timeToMove)
		{
			chessboardParent.transform.position = 
			Vector3.Lerp(currentPosition,topRightCorner-new Vector3(3.5f,3.5f),elapsedTime/timeToMove);
			elapsedTime += Time.deltaTime;
			Debug.Log(elapsedTime);
			yield return null;
		}
		elapsedTime = 0f;
		currentPosition = chessboardParent.transform.position;
		while (elapsedTime<timeToMove)
		{
			chessboardParent.transform.position = 
			Vector3.Lerp(currentPosition,bottomRightCorner-new Vector3(3.5f,-0.5f),elapsedTime/timeToMove);
			elapsedTime += Time.deltaTime;
			Debug.Log(elapsedTime);
			yield return null;
		}
		
		elapsedTime = 0f;
		currentPosition = chessboardParent.transform.position;
		while (elapsedTime<timeToMove)
		{
			chessboardParent.transform.position = 
			Vector3.Lerp(currentPosition,bottomLeftCorner-new Vector3(-0.5f,-0.5f),elapsedTime/timeToMove);
			elapsedTime += Time.deltaTime;
			Debug.Log(elapsedTime);
			yield return null;
		} 


		elapsedTime = 0f;
		currentPosition = chessboardParent.transform.position;
		while (elapsedTime<timeToMove)
		{
			chessboardParent.transform.position = 
			Vector3.Lerp(currentPosition,new Vector3(0f,0f)-new Vector3(1.5f,1.5f),elapsedTime/timeToMove);
			elapsedTime += Time.deltaTime;
			Debug.Log(elapsedTime);
			yield return null;
		} 

		

		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(moveChessboard());
		}
	}
}
