using UnityEngine;

public class OversizedBall : MonoBehaviour
{
    public void PlayerLargeSize()
    {
        //Increases the scale of the object to 3 on each axis.
        GameController.playerObject.transform.localScale = new Vector3(3, 3, 3);

        //Raises the larger ball so it is the appropriate height to sit on the arena floor.
        GameController.playerObject.transform.localPosition = 
            new Vector3(GameController.playerObject.transform.localPosition.x, 
            GameController.playerObject.transform.localPosition.y+1, 
            GameController.playerObject.transform.localPosition.z);
    }

    public void PlayerSmallSize()
    {
        //Returns the scale of each axis to 1.
        GameController.playerObject.transform.localScale = new Vector3(1, 1, 1);

        //Adjusts the position of the ball so the smaller ball doesn't drop when the size is changed.
        GameController.playerObject.transform.localPosition = 
            new Vector3(GameController.playerObject.transform.localPosition.x, 
            GameController.playerObject.transform.localPosition.y - 0.5f, 
            GameController.playerObject.transform.localPosition.z);
    }
}