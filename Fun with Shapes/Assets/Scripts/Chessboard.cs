using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject myprefab= Resources.Load("Prefabs/Square") as GameObject;
        for (int r=0;r<4;r++)
		{
			for (int c=0;c<4;c++)
			{
				
				GameObject t = Instantiate(myprefab,new Vector3(c,r),Quaternion.identity);
				
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
				
				
				
			
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
