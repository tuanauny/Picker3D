using UnityEngine;
using System.Collection.Generic;


namespace Data.UnityObjects {

   [CreateAssetMenu(fileName ="CD_Level", menuName ="Picker3D/CD_Level")]
    public class CD_Level: ScriptableObject
    {
       public List<LevelData> LevelList = new List<LevelData>();
    }


}

