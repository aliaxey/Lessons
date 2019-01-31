using System.Collections;
using UnityEngine;

public class Bootstrapper : MonoBehaviour {

	void Start () {

        IObjectCreator creator = new ObjectCreator();
        IObjectPublisher publisher = new ObjectPubisher(creator);
        IMeshManager meshManager = new MeshManager(publisher);
        IBallsUpdater ballsUpdater = new BallsUpdater(meshManager);
        IMeshFiller meshFiller = new MeshFiller(meshManager);


        var updateManagerHolder = new GameObject("UpdateManagerHolder");
        updateManagerHolder.AddComponent<UpdateManager>();
        updateManagerHolder.AddComponent<Corutinier>();
        
		
        IUpdateManager updateManager = updateManagerHolder.GetComponent<UpdateManager>();
        updateManager.AddSubscriber(ballsUpdater);
        ICorutinier corutinier = updateManagerHolder.GetComponent<Corutinier>();
        meshFiller.Coroutinier = corutinier;
        
        meshFiller.FillMesh();

    }

    void Update () {
		
	}
}
        

        //publisher.Publish(creator.CreateNewBall(BallType.GREEN), new Vector3(0, 1, 0));
        //_objectStorage.AddUpdateManager

        // А он создается как new GameObject("UpdateManager")

        //  А потом AddComponent
        /*StartCoroutine(Lol());
          	IEnumerator Lol()
          	{
          		yield return new WaitForSeconds(1);
          		Debug.Log("ogo");
          	}
                 meshManager.AddBall(BallType.BLUE, 2);
              meshManager.AddBall(BallType.GREEN, 2);
              meshManager.AddBall(BallType.RED, 0);
              meshManager.AddBall(BallType.RED, 4);
               */
        /*
 for(int i = 0; i < Constants.HEIGHT; i++) {
     for (int j = 0; j < Constants.WIDTH; j++) {
         int rand = Random.Range(0, 4);
         switch (rand) {
             case 0:
                 meshManager.AddBall(BallType.RED,j);
                 break;
             case 1:
                 meshManager.AddBall(BallType.GREEN, j);
                 break;
             case 2:
                 meshManager.AddBall(BallType.BLUE, j);
                 break;
             case 3:
                 meshManager.AddBall(BallType.YELLOW, j);
                 break;
             
         }

     }
 }
 */