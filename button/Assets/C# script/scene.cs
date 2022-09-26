using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    
        public void ChangeScenes(int scenenumb )
        {
        SceneManager.LoadScene(scenenumb);
        }
    

    // Update is called once per frame
  
}
