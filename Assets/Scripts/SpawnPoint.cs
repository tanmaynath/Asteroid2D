using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    #region fields

    [SerializeField]
    string direction;
    Transform position;

    #endregion

    #region Properties

    public string GetDirection
    {
       get { return direction; }
    }

    public Vector3 GetPosition
    {
        get { return this.transform.position; }
    }

    #endregion

}
