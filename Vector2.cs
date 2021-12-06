//"transform" holds all the things like rotation and position and size

Instance.transform.position = new Vector2(1f, -1f)//we use Vector2 because people playground is a 2d game, so there are only 2 dimensions. 0.05 is around half a pixel
Instance.transform.localPosition += new Vector2(0.5f, 0f) //moves it to the side relative to the Instances original position
