using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SceneManager : MonoBehaviour
{
	private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
       videoPlayer = GetComponent<VideoPlayer>(); 
    }

   public void changeScene(VideoClip newVideo)
   {
   		videoPlayer.clip = newVideo;
   }

   // IEnumerator playVideo()
   // {
   // 		yield return new WaitForSeconds(2f);
   // }
   
}
