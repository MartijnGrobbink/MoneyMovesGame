using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callange_Script : MonoBehaviour

  {
      public void OpenURL()
      {
          Application.OpenURL("https://www.ah.nl/?gclid=CjwKCAjwtpGGBhBJEiwAyRZX2vNBTaDf9n3NL5Wkpb7B49F9P2fWhIWpg49EVVzsQCTPaHHuOqCYJRoCPUMQAvD_BwE/");
          Debug.Log("is this working?");
      }
  
  }